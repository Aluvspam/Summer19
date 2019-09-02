using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyMP3Player
{
    public partial class Form1 : Form
    {
        MusicPlayer player = new MusicPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            player.Play();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            label1.Text = openFileDialog1.FileName;
            player.Open(openFileDialog1.FileName);
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            player.Pause();
        }

        private void Volume_Scroll(object sender, EventArgs e)
        {
            
        }
    }
}
