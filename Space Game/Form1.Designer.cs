namespace SpaceWar
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MoveBackGround = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.LeftMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.RigthMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.UpMoveTImer = new System.Windows.Forms.Timer(this.components);
            this.DownMoveTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBackGround
            // 
            this.MoveBackGround.Enabled = true;
            this.MoveBackGround.Interval = 10;
            this.MoveBackGround.Tick += new System.EventHandler(this.MoveBackGround_Tick);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(251, 399);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 50);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // LeftMoveTimer
            // 
            this.LeftMoveTimer.Interval = 5;
            this.LeftMoveTimer.Tick += new System.EventHandler(this.LeftMoveTimer_Tick);
            // 
            // RigthMoveTimer
            // 
            this.RigthMoveTimer.Interval = 5;
            this.RigthMoveTimer.Tick += new System.EventHandler(this.RigthMoveTimer_Tick);
            // 
            // UpMoveTImer
            // 
            this.UpMoveTImer.Interval = 5;
            this.UpMoveTImer.Tick += new System.EventHandler(this.UpMoveTImer_Tick);
            // 
            // DownMoveTimer
            // 
            this.DownMoveTimer.Interval = 5;
            this.DownMoveTimer.Tick += new System.EventHandler(this.DownMoveTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space War";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer MoveBackGround;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer LeftMoveTimer;
        private System.Windows.Forms.Timer RigthMoveTimer;
        private System.Windows.Forms.Timer UpMoveTImer;
        private System.Windows.Forms.Timer DownMoveTimer;
    }
}

