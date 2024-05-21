using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisGraficzny
{
    [Serializable]
    class Gra
    {
        int hits = 0;
        int score = 0;
        int Cols = 10;
        int Rows = 20;
        bool test;
        public bool sound = true;
        Brick klocek;     
        Plansza field;
        List<Brick> allBricks;
        Random r = new Random();
        int[,] obrocona;

        public Gra()
        {
            field = new Plansza(Rows, Cols);
            IEnumerable<Brick> aux;
            aux = typeof(Brick).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(Brick))).Select(t => (Brick)Activator.CreateInstance(t));
            allBricks = aux.Cast<Brick>().ToList();
            NewBrick();
        }
        private void NewBrick()
        {
            klocek = allBricks[r.Next(allBricks.Count)];
            klocek.Start(r.Next(Cols - klocek.Shape.GetLength(0)));

        }
        private void Score(int hits, SoundPlayer smallStrikePlayer, SoundPlayer bigStrikePlayer)
        {
            if (hits == 1)
            {
                score += 100;
                if(sound == true)
                    smallStrikePlayer.Play();
            }
            else if (hits == 2)
            {
                score += 300;
                if (sound == true)
                    smallStrikePlayer.Play();
            }
            else if (hits == 3)
            {
                score += 500;
                if (sound == true)
                    smallStrikePlayer.Play();
            }
            else if (hits == 4)
            {
                score += 1000;
                if (sound == true)
                    bigStrikePlayer.Play();
            }
        }
        public void KeyInput(Keys k, Timer timer, Label pause)
        {

            if (timer.Enabled == false && k != Keys.P) return;

            switch (k)
            {
                case Keys.Right:
                    if (field.Kolizja(klocek.Shape, 1, 0, klocek.PosX, klocek.PosY))
                    {
                        klocek.Right();
                        test = true;
                    }
                    else
                        test = false;
                    break;
                case Keys.Left:
                    if (field.Kolizja(klocek.Shape, -1, 0, klocek.PosX, klocek.PosY))
                    {
                        klocek.Left();
                        test = true;
                    }
                    else
                        test = false;
                    break;
                case Keys.G:
                    obrocona = klocek.Rotate(false);
                    if (field.Kolizja(obrocona, 0, 0, klocek.PosX, klocek.PosY))
                    {
                        klocek.Przepisz(obrocona);
                        test = true;
                    }
                    else
                        test = false;
                    break;
                case Keys.H:
                    obrocona = klocek.Rotate(true);
                    if (field.Kolizja(obrocona, 0, 0, klocek.PosX, klocek.PosY))
                    {
                        klocek.Przepisz(obrocona);
                        test = true;
                    }
                    else
                        test = false;
                    break;
                case Keys.Down:
                    if (field.Kolizja(klocek.Shape, 0, 1, klocek.PosX, klocek.PosY))
                    {
                        klocek.Down();
                        test = true;
                    }
                    else
                        test = false;
                    break;
                case Keys.P:
                    if (timer.Enabled == true)
                    {
                        timer.Stop();
                        pause.Visible = true;
                    }
                    else
                    {
                        timer.Start();
                        pause.Visible = false;
                    }
                    break;
                case Keys.M:
                    sound = !sound;
                    break;
            }
            field.PlytkieCzyszczenie();
            field.Przekaz(klocek);

        }

        public void Play(Label wynik, TextBox loseTextBox,Button closeButton, Button replayButton, Timer timer, SoundPlayer losePlayer, SoundPlayer smallStrikePlayer, SoundPlayer bigStrikePlayer)
        {

            test = false;

            {

                field.PlytkieCzyszczenie();
                if (field.Kolizja(klocek.Shape, 0, 1, klocek.PosX, klocek.PosY))
                {
                    klocek.Down();
                    field.Przekaz(klocek);
                }
                else
                {
                    field.Zamroz(klocek);
                    hits = field.Linia();
                    Score(hits,smallStrikePlayer, bigStrikePlayer);
                    if (field.End() || field.end == true)
                    {

                        field.GlebokieCzyszczenie();
                        if(sound == true)
                            losePlayer.Play();
                        loseTextBox.Text = Environment.NewLine + "Gra skończona!" +  Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + "Wynik: " + score;
                        closeButton.Visible = true;
                        replayButton.Visible = true;
                        loseTextBox.Visible = true;
                        timer.Stop();
                        score = 0;
                        field.end = false;
                                   
                    }
                    NewBrick();
                }
                test = true;
            }



            if (test)
            {
                field.PlytkieCzyszczenie();
                field.Przekaz(klocek);
                wynik.Text = "Wynik: " + score.ToString();
                FixWynik(wynik,loseTextBox.Width,loseTextBox.Location.X);
            }
        }

        private void FixWynik(Label wynik, int szerG, int xG)
        {
            int x = (szerG - wynik.Width) / 2 + xG;
            wynik.Location = new Point(x, wynik.Location.Y);
        }
        public void rysuj(Graphics g, int szer, int wys)
        {
            field.Wypisz(g, szer, wys,klocek);
        }

        public void Reset()
        {
            field.GlebokieCzyszczenie();
        }
        public void Wczytaj(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.Open);
                BinaryFormatter bFormatter = new BinaryFormatter();
                Save zapis = new Save();
                zapis = (Save)bFormatter.Deserialize(stream);
                field = zapis.board;
                score = zapis.wynik;
                klocek = zapis.brick;
                sound = zapis.sound;
                stream.Close();
            }
            catch
            {
                MessageBox.Show("Nie odnaleziono pliku zapisu!");
            }
        }
        public void Zapisz(string fileName)
        {
            Save zapis = new Save();
            zapis.wynik = score;
            zapis.board = field;
            zapis.brick = klocek;
            zapis.sound = sound;
            Stream stream = File.Open(fileName, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, zapis);
            stream.Close();
        }
    }
}
