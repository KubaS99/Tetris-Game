using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisGraficzny
{
    public partial class Form1 : Form
    {
        Assembly assembly;
        SoundPlayer themePlayer;
        SoundPlayer clickPlayer;
        SoundPlayer losePlayer;
        SoundPlayer smallStrikePlayer;
        SoundPlayer bigStrikePlayer;

        
       // bool sound = true;
        Gra game;
        public Form1()
        {
            InitializeComponent();
            game = new Gra();
            pictureBox1.BackColor = Color.Transparent;
            
            assembly = Assembly.GetExecutingAssembly();
            themePlayer = new SoundPlayer(assembly.GetManifestResourceStream("TetrisGraficzny.theme.wav"));
            themePlayer.Play();
            clickPlayer = new SoundPlayer(assembly.GetManifestResourceStream("TetrisGraficzny.click.wav"));
            losePlayer = new SoundPlayer(assembly.GetManifestResourceStream("TetrisGraficzny.lose.wav"));
            smallStrikePlayer = new SoundPlayer(assembly.GetManifestResourceStream("TetrisGraficzny.smallStrike.wav"));
            bigStrikePlayer = new SoundPlayer(assembly.GetManifestResourceStream("TetrisGraficzny.bigStrike.wav"));
                
            if(clickPlayer.Stream == null || themePlayer.Stream == null || losePlayer.Stream == null || smallStrikePlayer.Stream == null || bigStrikePlayer.Stream == null )
            {
                MessageBox.Show("Nie udało się wczytać pliku dźwięku!");
            }        
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            game.rysuj(e.Graphics, pictureBox1.Width, pictureBox1.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.Play(wynik,loseTextBox,closeButton,replayButton,timer1,losePlayer,smallStrikePlayer, bigStrikePlayer);
            pictureBox1.Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            game.KeyInput(e.KeyCode, timer1,pause);           
            if(game.sound==true)
                clickPlayer.Play();
            if (e.KeyCode == Keys.S)
            {
                loadLabel.Visible = false;
                game.Zapisz("Tetris_296745.Save");
                saveLabel.Visible = true;               
                saveTimer.Start();
                
            }              
            if (e.KeyCode == Keys.W)
            {
                saveLabel.Visible = false;
                game.Wczytaj("Tetris_296745.Save");
                loadLabel.Visible = true;               
                timer1.Stop();
                pause.Visible = true;
                saveTimer.Start();
            }
                
            pictureBox1.Refresh();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void replayButton_Click(object sender, EventArgs e)
        {
            closeButton.Visible = false;
            replayButton.Visible = false;
            loseTextBox.Visible = false;
            Focus();
            game.Reset();
            timer1.Start();
            
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            playButton.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            pictureBox2.Visible = false;
            CloseButton2.Visible = false;
            timer1.Start();
            Focus();
            themePlayer.Stop();   
        }

        private void CloseButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trayCloseLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveTimer_Tick(object sender, EventArgs e)
        {        
            saveLabel.Visible = false;          
            loadLabel.Visible = false;
            saveTimer.Stop();
        }
    }
}
