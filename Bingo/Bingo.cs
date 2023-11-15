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
            string path = "";
            string directory = GetAudioDirectory();

            switch (number)
            {
                case 1:
                    path = $"{directory}one.wav";
                    break;
                case 2:
                    path = $"{directory}two.wav";
                    break;
                case 3:
                    path = $"{directory}three.wav";
                    break;
                case 4:
                    path = $"{directory}four.wav";
                    break;
                case 5:
                    path = $"{directory}five.wav";
                    break;
                case 6:
                    path = $"{directory}six.wav";
                    break;
                case 7:
                    path = $"{directory}seven.wav";
                    break;
                case 8:
                    path = $"{directory}eight.wav";
                    break;
                case 9:
                    path = $"{directory}nine.wav";
                    break;
                case 10:
                    path = $"{directory}ten.wav";
                    break;
                case 11:
                    path = $"{directory}eleven.wav";
                    break;
                case 12:
                    path = $"{directory}twelve.wav";
                    break;
                case 13:
                    path = $"{directory}thirteen.wav";
                    break;
                case 14:
                    path = $"{directory}fourteen.wav";
                    break;
                case 15:
                    path = $"{directory}fifteen.wav";
                    break;
                case 16:
                    path = $"{directory}sixteen.wav";
                    break;
                case 17:
                    path = $"{directory}seventeen.wav";
                    break;
                case 18:
                    path = $"{directory}eighteen.wav";
                    break;
                case 19:
                    path = $"{directory}nineteen.wav";
                    break;
                case 20:
                    path = $"{directory}twenty.wav";
                    break;
                case 21:
                    path = $"{directory}twentyone.wav";
                    break;
                case 22:
                    path = $"{directory}twentytwo.wav";
                    break;
                case 23:
                    path = $"{directory}twentythree.wav";
                    break;
                case 24:
                    path = $"{directory}twentyfour.wav";
                    break;
                case 25:
                    path = $"{directory}twentyfive.wav";
                    break;
                case 26:
                    path = $"{directory}twentysix.wav";
                    break;
                case 27:
                    path = $"{directory}twentyseven.wav";
                    break;
                case 28:
                    path = $"{directory}twentyeight.wav";
                    break;
                case 29:
                    path = $"{directory}twentynine.wav";
                    break;
                case 30:
                    path = $"{directory}thirty.wav";
                    break;
                case 31:
                    path = $"{directory}thirtyone.wav";
                    break;
                case 32:
                    path = $"{directory}thirtytwo.wav";
                    break;
                case 33:
                    path = $"{directory}thirtythree.wav";
                    break;
                case 34:
                    path = $"{directory}thirtyfour.wav";
                    break;
                case 35:
                    path = $"{directory}thirtyfive.wav";
                    break;
                case 36:
                    path = $"{directory}thirtysix.wav";
                    break;
                case 37:
                    path = $"{directory}thirtyseven.wav";
                    break;
                case 38:
                    path = $"{directory}thirtyeight.wav";
                    break;
                case 39:
                    path = $"{directory}thirtynine.wav";
                    break;
                case 40:
                    path = $"{directory}fourty.wav";
                    break;
                case 41:
                    path = $"{directory}fourtyone.wav";
                    break;
                case 42:
                    path = $"{directory}fourtytwo.wav";
                    break;
                case 43:
                    path = $"{directory}fourtythree.wav";
                    break;
                case 44:
                    path = $"{directory}fourtyfour.wav";
                    break;
                case 45:
                    path = $"{directory}fourtyfive.wav";
                    break;
                case 46:
                    path = $"{directory}fourtysix.wav";
                    break;
                case 47:
                    path = $"{directory}fourtyseven.wav";
                    break;
                case 48:
                    path = $"{directory}fourtyeight.wav";
                    break;
                case 49:
                    path = $"{directory}fourtynine.wav";
                    break;
                case 50:
                    path = $"{directory}fifty.wav";
                    break;
                case 51:
                    path = $"{directory}fiftyone.wav";
                    break;
                case 52:
                    path = $"{directory}fiftytwo.wav";
                    break;
                case 53:
                    path = $"{directory}fiftythree.wav";
                    break;
                case 54:
                    path = $"{directory}fiftyfour.wav";
                    break;
                case 55:
                    path = $"{directory}fiftyfive.wav";
                    break;
                case 56:
                    path = $"{directory}fiftysix.wav";
                    break;
                case 57:
                    path = $"{directory}fiftyseven.wav";
                    break;
                case 58:
                    path = $"{directory}fiftyeight.wav";
                    break;
                case 59:
                    path = $"{directory}fiftynine.wav";
                    break;
                case 60:
                    path = $"{directory}sixty.wav";
                    break;
                case 61:
                    path = $"{directory}sixtyone.wav";
                    break;
                case 62:
                    path = $"{directory}sixtytwo.wav";
                    break;
                case 63:
                    path = $"{directory}sixtythree.wav";
                    break;
                case 64:
                    path = $"{directory}sixtyfour.wav";
                    break;
                case 65:
                    path = $"{directory}sixtyfive.wav";
                    break;
                case 66:
                    path = $"{directory}sixtysix.wav";
                    break;
                case 67:
                    path = $"{directory}sixtyseven.wav";
                    break;
                case 68:
                    path = $"{directory}sixtyeight.wav";
                    break;
                case 69:
                    path = $"{directory}sixtynine.wav";
                    break;
                case 70:
                    path = $"{directory}seventy.wav";
                    break;
                case 71:
                    path = $"{directory}seventyone.wav";
                    break;
                case 72:
                    path = $"{directory}seventytwo.wav";
                    break;
                case 73:
                    path = $"{directory}seventythree.wav";
                    break;
                case 74:
                    path = $"{directory}seventyfour.wav";
                    break;
                case 75:
                    path = $"{directory}seventyfive.wav";
                    break;
            }

            if (File.Exists(path))
            {
                SoundPlayer soundPlayer = new SoundPlayer(path);
                soundPlayer.Play();
            }
        }

        private string GetAudioDirectory()
        {
            string path = Application.StartupPath;
            return path.Replace(@"bin\Debug", @"Audio\");
        }

        private void ConvertAudio_M4aToWav()
        {
            //read through the audio directory and create a ffmpeg command to covert audio
            string directory = @"C:\Users\war4t\source\repos\Bingo\Bingo\Audio\";
            string[] files = System.IO.Directory.GetFiles(directory);
            foreach (string file in files)
            {
                string filePath = Path.GetFileNameWithoutExtension(file);
                string path = $"{directory}{filePath}.wav ";
                string args = $"-i {file} {path}";

                Process proc = new Process();
                proc.StartInfo.FileName = "ffmpeg";
                proc.StartInfo.Arguments = args;
                proc.StartInfo.RedirectStandardError = true;
                proc.StartInfo.UseShellExecute = false;

                if (!proc.Start())
                {
                    Console.WriteLine("Error starting");
                    return;
                }
            }
        }
        public string GetStringValue(int number)
        {
            string value = "";

            switch (number)
            {
                case 1:
                    value = "one";
                    break;
                case 2:
                    value = "two";
                    break;
                case 3:
                    value = "three";
                    break;
                case 4:
                    value = "four";
                    break;
                case 5:
                    value = "five";
                    break;
                case 6:
                    value = "six";
                    break;
                case 7:
                    value = "seven";
                    break;
                case 8:
                    value = "eight";
                    break;
                case 9:
                    value = "nine";
                    break;
                case 10:
                    value = "ten";
                    break;
                case 11:
                    value = "eleven";
                    break;
                case 12:
                    value = "twelve";
                    break;
                case 13:
                    value = "thirteen";
                    break;
                case 14:
                    value = "fourteen";
                    break;
                case 15:
                    value = "fifteen";
                    break;
                case 16:
                    value = "sixteen";
                    break;
                case 17:
                    value = "seventeen";
                    break;
                case 18:
                    value = "eighteen";
                    break;
                case 19:
                    value = "nineteen";
                    break;
                case 20:
                    value = "twenty";
                    break;
                case 21:
                    value = "twentyone";
                    break;
                case 22:
                    value = "twentytwo";
                    break;
                case 23:
                    value = "twentythree";
                    break;
                case 24:
                    value = "twentyfour";
                    break;
                case 25:
                    value = "twentyfive";
                    break;
                case 26:
                    value = "twentysix";
                    break;
                case 27:
                    value = "twentyseven";
                    break;
                case 28:
                    value = "twentyeight";
                    break;
                case 29:
                    value = "twentynine";
                    break;
                case 30:
                    value = "thirty";
                    break;
                case 31:
                    value = "thirtyone";
                    break;
                case 32:
                    value = "thirtytwo";
                    break;
                case 33:
                    value = "thirtythree";
                    break;
                case 34:
                    value = "thirtyfour";
                    break;
                case 35:
                    value = "thirtyfive";
                    break;
                case 36:
                    value = "thirtysix";
                    break;
                case 37:
                    value = "thirtyseven";
                    break;
                case 38:
                    value = "thirtyeight";
                    break;
                case 39:
                    value = "thirtynine";
                    break;
                case 40:
                    value = "fourty";
                    break;
                case 41:
                    value = "fourtyone";
                    break;
                case 42:
                    value = "fourtytwo";
                    break;
                case 43:
                    value = "fourtythree";
                    break;
                case 44:
                    value = "fourtyfour";
                    break;
                case 45:
                    value = "fourtyfive";
                    break;
                case 46:
                    value = "fourtysix";
                    break;
                case 47:
                    value = "fourtyseven";
                    break;
                case 48:
                    value = "fourtyeight";
                    break;
                case 49:
                    value = "fourtynine";
                    break;
                case 50:
                    value = "fifty";
                    break;
                case 51:
                    value = "fiftyone";
                    break;
                case 52:
                    value = "fiftytwo";
                    break;
                case 53:
                    value = "fiftythree";
                    break;
                case 54:
                    value = "fiftyfour";
                    break;
                case 55:
                    value = "fiftyfive";
                    break;
                case 56:
                    value = "fiftysix";
                    break;
                case 57:
                    value = "fiftyseven";
                    break;
                case 58:
                    value = "fiftyeight";
                    break;
                case 59:
                    value = "fiftynine";
                    break;
                case 60:
                    value = "sixty";
                    break;
                case 61:
                    value = "sixtyone";
                    break;
                case 62:
                    value = "sixtytwo";
                    break;
                case 63:
                    value = "sixtythree";
                    break;
                case 64:
                    value = "sixtyfour";
                    break;
                case 65:
                    value = "sixtyfive";
                    break;
                case 66:
                    value = "sixtysix";
                    break;
                case 67:
                    value = "sixtyseven";
                    break;
                case 68:
                    value = "sixtyeight";
                    break;
                case 69:
                    value = "sixtynine";
                    break;
                case 70:
                    value = "seventy";
                    break;
                case 71:
                    value = "sevetyone";
                    break;
                case 72:
                    value = "sevetytwo";
                    break;
                case 73:
                    value = "sevetythree";
                    break;
                case 74:
                    value = "sevetyfour";
                    break;
                case 75:
                    value = "sevetyfive";
                    break;
            }
            return value;
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
