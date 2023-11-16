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
