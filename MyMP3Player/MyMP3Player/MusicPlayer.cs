using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace MyMP3Player
{
    class MusicPlayer
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwndCallback);

        //private double volume;
       // public double Volume { get { return volume; } set { Volume = value; } }
        public void Open(string file)
        {
            string command = "open \"" + file + "\" type MPEGVideo alias MyMp3";
            mciSendString(command, null, 0, 0);
        }

        public void Play()
        {
            string command = "play MyMp3";
            mciSendString(command, null, 0, 0);
        }

        public void Stop()
        {
            string command = "stop MyMp3";
            mciSendString(command, null, 0, 0);

            command = "close MyMp3";
            mciSendString(command, null, 0, 0);
        }

        public void Pause()
        {
            string command = "stop MyMp3";
            mciSendString(command, null, 0, 0);
        }


    }
}
