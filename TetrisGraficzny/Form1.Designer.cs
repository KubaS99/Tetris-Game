namespace TetrisGraficzny
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.wynik = new System.Windows.Forms.Label();
            this.pause = new System.Windows.Forms.Label();
            this.loseTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.replayButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.CloseButton2 = new System.Windows.Forms.Button();
            this.trayCloseLabel = new System.Windows.Forms.Label();
            this.saveTimer = new System.Windows.Forms.Timer(this.components);
            this.saveLabel = new System.Windows.Forms.Label();
            this.loadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(41, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // wynik
            // 
            this.wynik.AutoSize = true;
            this.wynik.BackColor = System.Drawing.Color.Black;
            this.wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik.ForeColor = System.Drawing.SystemColors.Control;
            this.wynik.Location = new System.Drawing.Point(154, 9);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(76, 20);
            this.wynik.TabIndex = 1;
            this.wynik.Text = "Wynik: 0";
            // 
            // pause
            // 
            this.pause.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pause.AutoSize = true;
            this.pause.BackColor = System.Drawing.Color.Black;
            this.pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pause.ForeColor = System.Drawing.Color.Lime;
            this.pause.Location = new System.Drawing.Point(160, 330);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(79, 29);
            this.pause.TabIndex = 2;
            this.pause.Text = "Pauza";
            this.pause.Visible = false;
            // 
            // loseTextBox
            // 
            this.loseTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.loseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loseTextBox.ForeColor = System.Drawing.Color.Lime;
            this.loseTextBox.Location = new System.Drawing.Point(44, 35);
            this.loseTextBox.Multiline = true;
            this.loseTextBox.Name = "loseTextBox";
            this.loseTextBox.ReadOnly = true;
            this.loseTextBox.Size = new System.Drawing.Size(297, 600);
            this.loseTextBox.TabIndex = 3;
            this.loseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loseTextBox.Visible = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Black;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeButton.ForeColor = System.Drawing.Color.Lime;
            this.closeButton.Location = new System.Drawing.Point(44, 561);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(126, 74);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Wyjście";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Visible = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // replayButton
            // 
            this.replayButton.BackColor = System.Drawing.Color.Black;
            this.replayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.replayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.replayButton.ForeColor = System.Drawing.Color.Lime;
            this.replayButton.Location = new System.Drawing.Point(219, 561);
            this.replayButton.Name = "replayButton";
            this.replayButton.Size = new System.Drawing.Size(122, 74);
            this.replayButton.TabIndex = 5;
            this.replayButton.Text = "Zagraj ponownie";
            this.replayButton.UseVisualStyleBackColor = false;
            this.replayButton.Visible = false;
            this.replayButton.Click += new System.EventHandler(this.replayButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(72, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = " Witaj w grze Tetris!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(58, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sterowanie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(58, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Strzałki - poruszanie klockiem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(58, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "G / H - obracanie klocka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(58, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "P - pauza";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(58, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "M - dźwięki";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(58, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "S - zapisz grę";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(58, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "W - wczytaj grę";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.BackgroundImage = global::TetrisGraficzny.Properties.Resources.logoDuze;
            this.pictureBox2.Location = new System.Drawing.Point(44, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 600);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playButton.ForeColor = System.Drawing.Color.Lime;
            this.playButton.Location = new System.Drawing.Point(219, 561);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(122, 72);
            this.playButton.TabIndex = 16;
            this.playButton.Text = "Zagraj!";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // CloseButton2
            // 
            this.CloseButton2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CloseButton2.ForeColor = System.Drawing.Color.Lime;
            this.CloseButton2.Location = new System.Drawing.Point(48, 561);
            this.CloseButton2.Name = "CloseButton2";
            this.CloseButton2.Size = new System.Drawing.Size(122, 72);
            this.CloseButton2.TabIndex = 17;
            this.CloseButton2.Text = "Wyjdź";
            this.CloseButton2.UseVisualStyleBackColor = false;
            this.CloseButton2.Click += new System.EventHandler(this.CloseButton2_Click);
            // 
            // trayCloseLabel
            // 
            this.trayCloseLabel.AutoSize = true;
            this.trayCloseLabel.BackColor = System.Drawing.Color.Transparent;
            this.trayCloseLabel.Image = global::TetrisGraficzny.Properties.Resources.xCorrect;
            this.trayCloseLabel.Location = new System.Drawing.Point(359, 9);
            this.trayCloseLabel.Name = "trayCloseLabel";
            this.trayCloseLabel.Size = new System.Drawing.Size(10, 13);
            this.trayCloseLabel.TabIndex = 18;
            this.trayCloseLabel.Text = " ";
            this.trayCloseLabel.Click += new System.EventHandler(this.trayCloseLabel_Click);
            // 
            // saveTimer
            // 
            this.saveTimer.Interval = 2000;
            this.saveTimer.Tick += new System.EventHandler(this.saveTimer_Tick);
            // 
            // saveLabel
            // 
            this.saveLabel.AutoSize = true;
            this.saveLabel.BackColor = System.Drawing.Color.Black;
            this.saveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveLabel.ForeColor = System.Drawing.Color.Lime;
            this.saveLabel.Location = new System.Drawing.Point(130, 125);
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(121, 20);
            this.saveLabel.TabIndex = 19;
            this.saveLabel.Text = "Gra zapisana!";
            this.saveLabel.Visible = false;
            // 
            // loadLabel
            // 
            this.loadLabel.AutoSize = true;
            this.loadLabel.BackColor = System.Drawing.Color.Black;
            this.loadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadLabel.ForeColor = System.Drawing.Color.Lime;
            this.loadLabel.Location = new System.Drawing.Point(130, 126);
            this.loadLabel.Name = "loadLabel";
            this.loadLabel.Size = new System.Drawing.Size(123, 20);
            this.loadLabel.TabIndex = 20;
            this.loadLabel.Text = "Gra wczytana!";
            this.loadLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(381, 659);
            this.Controls.Add(this.loadLabel);
            this.Controls.Add(this.saveLabel);
            this.Controls.Add(this.trayCloseLabel);
            this.Controls.Add(this.CloseButton2);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.replayButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.loseTextBox);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetris 296745";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label wynik;
        private System.Windows.Forms.Label pause;
        private System.Windows.Forms.TextBox loseTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button replayButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button CloseButton2;
        private System.Windows.Forms.Label trayCloseLabel;
        private System.Windows.Forms.Timer saveTimer;
        private System.Windows.Forms.Label saveLabel;
        private System.Windows.Forms.Label loadLabel;
    }
}

