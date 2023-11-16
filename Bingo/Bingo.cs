using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace Bingo
{
    public class Bingo
    {
        public void PlaySound(int number)
        {
            string directory = Application.StartupPath.Replace(@"bin\Debug", @"Audio\");
            string path = $"{directory}{number}.wav";

            if (File.Exists(path))
            {
                SoundPlayer soundPlayer = new SoundPlayer(path);
                soundPlayer.Play();
            }
            else
            {
                MessageBox.Show($"Could not locate audio file for { number }");
            }
        }
    }

    public static class ThreadSafeRandom
    {
        [ThreadStatic] private static Random Local;

        public static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
        }
    }
}
