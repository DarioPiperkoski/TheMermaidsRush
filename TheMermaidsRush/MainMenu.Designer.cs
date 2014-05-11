namespace TheMermaidsRush
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSound = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHTP = new System.Windows.Forms.Button();
            this.btnHS = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSound
            // 
            this.btnSound.BackColor = System.Drawing.Color.Transparent;
            this.btnSound.BackgroundImage = global::TheMermaidsRush.Properties.Resources.SoundOn;
            this.btnSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSound.Location = new System.Drawing.Point(560, 10);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(50, 50);
            this.btnSound.TabIndex = 3;
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::TheMermaidsRush.Properties.Resources.Exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(410, 370);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // btnHTP
            // 
            this.btnHTP.BackgroundImage = global::TheMermaidsRush.Properties.Resources.HowToPlay;
            this.btnHTP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHTP.Location = new System.Drawing.Point(50, 370);
            this.btnHTP.Name = "btnHTP";
            this.btnHTP.Size = new System.Drawing.Size(180, 40);
            this.btnHTP.TabIndex = 2;
            this.btnHTP.UseVisualStyleBackColor = true;
            this.btnHTP.Click += new System.EventHandler(this.btnHTP_Click);
            this.btnHTP.MouseEnter += new System.EventHandler(this.btnHTP_MouseEnter);
            this.btnHTP.MouseLeave += new System.EventHandler(this.btnHTP_MouseLeave);
            // 
            // btnHS
            // 
            this.btnHS.BackgroundImage = global::TheMermaidsRush.Properties.Resources.HighScore;
            this.btnHS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHS.Location = new System.Drawing.Point(50, 315);
            this.btnHS.Name = "btnHS";
            this.btnHS.Size = new System.Drawing.Size(180, 40);
            this.btnHS.TabIndex = 1;
            this.btnHS.UseVisualStyleBackColor = true;
            this.btnHS.Click += new System.EventHandler(this.btnHS_Click);
            this.btnHS.MouseEnter += new System.EventHandler(this.btnHS_MouseEnter);
            this.btnHS.MouseLeave += new System.EventHandler(this.btnHS_MouseLeave);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::TheMermaidsRush.Properties.Resources.Play;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Location = new System.Drawing.Point(50, 260);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(180, 40);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseEnter += new System.EventHandler(this.btnPlay_MouseEnter);
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            // 
            // MainMenu
            // 
            this.AcceptButton = this.btnPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheMermaidsRush.Properties.Resources.MainMenuBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(622, 435);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHTP);
            this.Controls.Add(this.btnHS);
            this.Controls.Add(this.btnPlay);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHTP;
        private System.Windows.Forms.Button btnHS;
        private System.Windows.Forms.Button btnPlay;
    }
}

