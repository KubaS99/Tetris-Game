using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGraficzny
{
    [Serializable]
    class Plansza
    {
        Dictionary<int, Color> kolory = new Dictionary<int, Color>()
        {
            {2, Color.Cyan },
            {3,Color.Blue },
            {4, Color.Orange },
            {5, Color.Yellow },
            {6, Color.LightGreen },
            {7, Color.Purple },
            {8, Color.Red }

            //{2, Color.FromArgb(190,Color.Cyan) },
            //{3,Color.FromArgb(190,Color.DarkBlue) },
            //{4, Color.FromArgb(190,Color.Orange) },
            //{5, Color.FromArgb(190,Color.Yellow) },
            //{6, Color.FromArgb(190,Color.LightGreen) },
            //{7, Color.FromArgb(190,Color.Purple) },
            //{8, Color.FromArgb(190,Color.Red) }

        };

        public bool end = false;
        private int[,] board = null;
        public Plansza(int x, int y)
        {
            board = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    board[i, j] = 0;
                
                }
            }
        }
        public void Wypisz(Graphics g, int szer, int wys, Brick brick)
        {
            g.FillRectangle(new SolidBrush(Color.FromArgb(240,Color.Black)), 0, 0, szer, wys);
            int kwadratSzer = szer / 10;
            int kwadratWys = wys / 20;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 1)
                    {
                        g.FillRectangle(new SolidBrush(kolory[brick.kolor]), kwadratSzer * j + 1, kwadratWys * i + 1, kwadratSzer - 1, kwadratWys - 1);
                        g.FillRectangle(new SolidBrush(Color.FromArgb(100,Color.Black)),  kwadratSzer * j + (kwadratSzer/4), (kwadratWys * i) + (kwadratWys/4), kwadratSzer/2+2, kwadratWys/2+2);

                    }

                    if(board[i,j]>1)
                    {
                        //Random rnd = new Random();
                        //Color col = Color.FromArgb(rnd.Next(50, 255), rnd.Next(50, 255), rnd.Next(50, 255));
                        //g.FillRectangle(new SolidBrush(col), kwadratSzer * j + 1, kwadratWys * i + 1, kwadratSzer - 1, kwadratWys - 1);
                        // g.FillRectangle(new SolidBrush(Color.Red), kwadratSzer * j + 1, kwadratWys * i + 1, kwadratSzer - 1, kwadratWys - 1);
                        g.FillRectangle(new SolidBrush(kolory[board[i,j]]), kwadratSzer * j + 1, kwadratWys * i + 1, kwadratSzer - 1, kwadratWys - 1);
                        g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Black)), kwadratSzer * j + (kwadratSzer / 4), (kwadratWys * i) + (kwadratWys / 4), kwadratSzer / 2 + 2, kwadratWys / 2 + 2);
                    }
                }
                
            }
            
        }
        public void Przekaz(Brick brick)
        {
            int size = brick.Shape.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (brick.Shape[i, j] != 0)
                    {
                        if (board[brick.PosX + i, brick.PosY + j] > 1)
                        {
                            end = true;
                            return;
                        }
                        board[brick.PosX + i, brick.PosY + j] = brick.Shape[i, j];
                    }
                }
            }
        }
        public void GlebokieCzyszczenie()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = 0;
                }
            }
        }
        public void PlytkieCzyszczenie()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 1)
                        board[i, j] = 0;
                }
            }
        }
        public bool Kolizja(int[,] tablica, int x, int y, int PosX, int PosY)
        {
            int size = tablica.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (tablica[i, j] != 0)
                    {
                        if (PosX + i + y >= board.GetLength(0) 
                            || PosY + j + x >= board.GetLength(1) 
                            || PosX + i + y < 0 
                            || PosY + j + x < 0 
                            || board[PosX + i + y, PosY + j + x] > 1)
                            return false;

                    }
                }
            }
            return true;
        }

        public void Zamroz(Brick brick)
        {
            int size = brick.Shape.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (brick.Shape[i, j] != 0)
                    {
                        board[brick.PosX + i, brick.PosY + j] = brick.kolor;
                    }

                }
            }
        }
        public int Linia()
        {
            int wynik = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                bool test = true;
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] < 2)
                        test = false;
                }
                if (test == true)
                {
                    wynik += 1;
                    for (int k = i; k > 0; k--)
                    {
                        for (int l = board.GetLength(1) - 1; l >= 0; l--)
                        {
                            board[k, l] = board[k - 1, l];
                        }
                    }
                }
            }
            return wynik;
        }
        public bool End()
        {
            for (int i = 0; i < board.GetLength(1); i++)
            {
                if (board[0, i] > 1)
                {
                    return true;
                }
            }
            return false;
        }       
    }
}
