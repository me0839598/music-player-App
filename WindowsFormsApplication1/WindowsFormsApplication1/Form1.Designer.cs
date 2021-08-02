namespace WindowsFormsApplication1
{
    partial class MusicplayerApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicplayerApp));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ibllogo = new System.Windows.Forms.Label();
            this.listBoxsongs = new System.Windows.Forms.ListBox();
            this.btnselectSongs = new System.Windows.Forms.Button();
            this.WindowsMediaPlayermusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbfooter = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayermusic)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Controls.Add(this.ibllogo);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(844, 32);
            this.TopPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(808, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ibllogo
            // 
            this.ibllogo.AutoSize = true;
            this.ibllogo.Font = new System.Drawing.Font("Mistral", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibllogo.Location = new System.Drawing.Point(62, 0);
            this.ibllogo.Name = "ibllogo";
            this.ibllogo.Size = new System.Drawing.Size(161, 29);
            this.ibllogo.TabIndex = 0;
            this.ibllogo.Text = "Music player App";
            // 
            // listBoxsongs
            // 
            this.listBoxsongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxsongs.FormattingEnabled = true;
            this.listBoxsongs.ItemHeight = 20;
            this.listBoxsongs.Location = new System.Drawing.Point(586, 60);
            this.listBoxsongs.Name = "listBoxsongs";
            this.listBoxsongs.Size = new System.Drawing.Size(246, 304);
            this.listBoxsongs.TabIndex = 1;
            this.listBoxsongs.SelectedIndexChanged += new System.EventHandler(this.listBoxsongs_SelectedIndexChanged);
            // 
            // btnselectSongs
            // 
            this.btnselectSongs.BackColor = System.Drawing.Color.DarkOrange;
            this.btnselectSongs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnselectSongs.Location = new System.Drawing.Point(586, 370);
            this.btnselectSongs.Name = "btnselectSongs";
            this.btnselectSongs.Size = new System.Drawing.Size(246, 35);
            this.btnselectSongs.TabIndex = 2;
            this.btnselectSongs.Text = "Select Songs";
            this.btnselectSongs.UseVisualStyleBackColor = false;
            this.btnselectSongs.Click += new System.EventHandler(this.button1_Click);
            // 
            // WindowsMediaPlayermusic
            // 
            this.WindowsMediaPlayermusic.Enabled = true;
            this.WindowsMediaPlayermusic.Location = new System.Drawing.Point(35, 60);
            this.WindowsMediaPlayermusic.Name = "WindowsMediaPlayermusic";
            this.WindowsMediaPlayermusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayermusic.OcxState")));
            this.WindowsMediaPlayermusic.Size = new System.Drawing.Size(398, 304);
            this.WindowsMediaPlayermusic.TabIndex = 3;
            // 
            // lbfooter
            // 
            this.lbfooter.AutoSize = true;
            this.lbfooter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbfooter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbfooter.Location = new System.Drawing.Point(308, 421);
            this.lbfooter.Name = "lbfooter";
            this.lbfooter.Size = new System.Drawing.Size(292, 17);
            this.lbfooter.TabIndex = 4;
            this.lbfooter.Text = "Developed by : Mohammed Ahmed El Sayed ";
            // 
            // MusicplayerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(844, 451);
            this.Controls.Add(this.lbfooter);
            this.Controls.Add(this.WindowsMediaPlayermusic);
            this.Controls.Add(this.btnselectSongs);
            this.Controls.Add(this.listBoxsongs);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusicplayerApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicplayerAPP";
            this.Load += new System.EventHandler(this.MusicplayerApp_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayermusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ibllogo;
        private System.Windows.Forms.ListBox listBoxsongs;
        private System.Windows.Forms.Button btnselectSongs;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayermusic;
        private System.Windows.Forms.Label lbfooter;
    }
}

