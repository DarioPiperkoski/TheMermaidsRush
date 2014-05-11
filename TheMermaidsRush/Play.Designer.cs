namespace TheMermaidsRush
{
    partial class Play
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play));
            this.pbMermaid = new System.Windows.Forms.PictureBox();
            this.pbShark = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblNotes1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pbTime = new System.Windows.Forms.ProgressBar();
            this.lblLives = new System.Windows.Forms.Label();
            this.lblLives1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMermaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShark)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMermaid
            // 
            this.pbMermaid.BackColor = System.Drawing.Color.Transparent;
            this.pbMermaid.Image = ((System.Drawing.Image)(resources.GetObject("pbMermaid.Image")));
            this.pbMermaid.Location = new System.Drawing.Point(379, 309);
            this.pbMermaid.Margin = new System.Windows.Forms.Padding(4);
            this.pbMermaid.Name = "pbMermaid";
            this.pbMermaid.Size = new System.Drawing.Size(160, 100);
            this.pbMermaid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMermaid.TabIndex = 18;
            this.pbMermaid.TabStop = false;
            // 
            // pbShark
            // 
            this.pbShark.BackColor = System.Drawing.Color.Transparent;
            this.pbShark.Image = ((System.Drawing.Image)(resources.GetObject("pbShark.Image")));
            this.pbShark.Location = new System.Drawing.Point(-32, 280);
            this.pbShark.Margin = new System.Windows.Forms.Padding(4);
            this.pbShark.Name = "pbShark";
            this.pbShark.Size = new System.Drawing.Size(200, 170);
            this.pbShark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShark.TabIndex = 17;
            this.pbShark.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.BackColor = System.Drawing.Color.Transparent;
            this.lblNotes.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNotes.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.Color.Purple;
            this.lblNotes.Location = new System.Drawing.Point(280, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(32, 33);
            this.lblNotes.TabIndex = 1;
            this.lblNotes.Text = "0";
            // 
            // lblNotes1
            // 
            this.lblNotes1.AutoSize = true;
            this.lblNotes1.BackColor = System.Drawing.Color.Transparent;
            this.lblNotes1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNotes1.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes1.ForeColor = System.Drawing.Color.Purple;
            this.lblNotes1.Location = new System.Drawing.Point(0, 0);
            this.lblNotes1.Name = "lblNotes1";
            this.lblNotes1.Size = new System.Drawing.Size(280, 33);
            this.lblNotes1.TabIndex = 0;
            this.lblNotes1.Text = "Notes Collected:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Purple;
            this.lblTime.Location = new System.Drawing.Point(312, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(264, 33);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time remaining:";
            // 
            // pbTime
            // 
            this.pbTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbTime.Location = new System.Drawing.Point(566, 0);
            this.pbTime.Name = "pbTime";
            this.pbTime.Size = new System.Drawing.Size(231, 33);
            this.pbTime.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbTime.TabIndex = 3;
            this.pbTime.Value = 100;
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.BackColor = System.Drawing.Color.Transparent;
            this.lblLives.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLives.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblLives.Location = new System.Drawing.Point(859, 0);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(371, 33);
            this.lblLives.TabIndex = 4;
            this.lblLives.Text = "Pause - \"P\"    Lives left:";
            // 
            // lblLives1
            // 
            this.lblLives1.AutoSize = true;
            this.lblLives1.BackColor = System.Drawing.Color.Transparent;
            this.lblLives1.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLives1.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives1.ForeColor = System.Drawing.Color.Purple;
            this.lblLives1.Location = new System.Drawing.Point(1230, 0);
            this.lblLives1.Name = "lblLives1";
            this.lblLives1.Size = new System.Drawing.Size(32, 33);
            this.lblLives1.TabIndex = 5;
            this.lblLives1.Text = "3";
            // 
            // Play
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::TheMermaidsRush.Properties.Resources.PlayBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 675);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblLives1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pbTime);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblNotes1);
            this.Controls.Add(this.pbMermaid);
            this.Controls.Add(this.pbShark);
            this.Name = "Play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Play_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Play_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Play_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Play_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbMermaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbMermaid;
        public System.Windows.Forms.PictureBox pbShark;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblNotes1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ProgressBar pbTime;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label lblLives1;
    }
}