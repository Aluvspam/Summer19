namespace MyMP3Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Pause = new System.Windows.Forms.Button();
            this.Volume = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "your music here..";
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Play.ForeColor = System.Drawing.Color.Yellow;
            this.Play.Location = new System.Drawing.Point(178, 176);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 1;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Open.ForeColor = System.Drawing.Color.Yellow;
            this.Open.Location = new System.Drawing.Point(40, 176);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 2;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Stop.ForeColor = System.Drawing.Color.Yellow;
            this.Stop.Location = new System.Drawing.Point(434, 176);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Pause.ForeColor = System.Drawing.Color.Yellow;
            this.Pause.Location = new System.Drawing.Point(308, 176);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(75, 23);
            this.Pause.TabIndex = 4;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(40, 115);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(213, 45);
            this.Volume.TabIndex = 5;
            this.Volume.Scroll += new System.EventHandler(this.Volume_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(564, 228);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Corly\'s MP3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.TrackBar Volume;
    }
}

