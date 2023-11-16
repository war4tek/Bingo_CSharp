using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Bingo
{
    public partial class BingoBoard : Form
    {
        private int number;
        private List<int> bingoBalls;
        private List<int> numbersCalled;
        private readonly Bingo b;
        private const int slow_delay = 9000;
        private const int reg_delay = 7000;
        private const int fast_delay = 6000;
        private const int crazy_delay = 3800;
        
        private int delay = slow_delay;
        
        public BingoBoard()
        {
            b = new Bingo();
            numbersCalled = new List<int>();
            InitializeComponent();
            InitializeBackgroundWorker();
        }

        private void InitializeBackgroundWorker()
        {
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.WorkerSupportsCancellation = true;
        } 

        private void ScrambleBalls()
        {
            bingoBalls = new List<int>(Enumerable.Range(1, 75));
            bingoBalls.Shuffle(); 
        }

        private void MarkBoard(int number)
        {
            switch (number)
            {
                case 1:
                    oneLbl.ForeColor = Color.Yellow;
                    break;
                case 2:
                    twoLbl.ForeColor = Color.Yellow;
                    break;
                case 3:
                    threeLbl.ForeColor = Color.Yellow;
                    break;
                case 4:
                    fourLbl.ForeColor = Color.Yellow;
                    break;
                case 5:
                    fiveLbl.ForeColor = Color.Yellow;
                    break;
                case 6:
                    sixLbl.ForeColor = Color.Yellow;
                    break;
                case 7:
                    sevenLbl.ForeColor = Color.Yellow;
                    break;
                case 8:
                    eightLbl.ForeColor = Color.Yellow;
                    break;
                case 9:
                    nineLbl.ForeColor = Color.Yellow;
                    break;
                case 10:
                    tenLbl.ForeColor = Color.Yellow;
                    break;
                case 11:
                    elevenLbl.ForeColor = Color.Yellow;
                    break;
                case 12:
                    twelveLbl.ForeColor = Color.Yellow;
                    break;
                case 13:
                    thirteenLbl.ForeColor = Color.Yellow;
                    break;
                case 14:
                    fourteenLbl.ForeColor = Color.Yellow;
                    break;
                case 15:
                    fifteenLbl.ForeColor = Color.Yellow;
                    break;
                case 16:
                    sixteenLbl.ForeColor = Color.Yellow;
                    break;
                case 17:
                    seventeenLbl.ForeColor = Color.Yellow;
                    break;
                case 18:
                    eighteenLbl.ForeColor = Color.Yellow;
                    break;
                case 19:
                    nineteenLbl.ForeColor = Color.Yellow;
                    break;
                case 20:
                    twentyLbl.ForeColor = Color.Yellow;
                    break;
                case 21:
                    twentyoneLbl.ForeColor = Color.Yellow;
                    break;
                case 22:
                    twentytwoLbl.ForeColor = Color.Yellow;
                    break;
                case 23:
                    twentythreeLbl.ForeColor = Color.Yellow;
                    break;
                case 24:
                    twentyfourLbl.ForeColor = Color.Yellow;
                    break;
                case 25:
                    twentyFiveLbl.ForeColor = Color.Yellow;
                    break;
                case 26:
                    twentySixLbl.ForeColor = Color.Yellow;
                    break;
                case 27:
                    twentysevenLbl.ForeColor = Color.Yellow;
                    break;
                case 28:
                    twentyeightLbl.ForeColor = Color.Yellow;
                    break;
                case 29:
                    twentynineLbl.ForeColor = Color.Yellow;
                    break;
                case 30:
                    thirtyLbl.ForeColor = Color.Yellow;
                    break;
                case 31:
                    thirtyoneLbl.ForeColor = Color.Yellow;
                    break;
                case 32:
                    thirtytwoLbl.ForeColor = Color.Yellow;
                    break;
                case 33:
                    thirtythreeLbl.ForeColor = Color.Yellow;
                    break;
                case 34:
                    thirtyfourLbl.ForeColor = Color.Yellow;
                    break;
                case 35:
                    thirtyfiveLbl.ForeColor = Color.Yellow;
                    break;
                case 36:
                    thirtysixLbl.ForeColor = Color.Yellow;
                    break;
                case 37:
                    thirtysevenLbl.ForeColor = Color.Yellow;
                    break;
                case 38:
                    thirtyeightLbl.ForeColor = Color.Yellow;
                    break;
                case 39:
                    thirtynineLbl.ForeColor = Color.Yellow;
                    break;
                case 40:
                    fourtyLbl.ForeColor = Color.Yellow;
                    break;
                case 41:
                    fourtyoneLbl.ForeColor = Color.Yellow;
                    break;
                case 42:
                    fourtytwoLbl.ForeColor = Color.Yellow;
                    break;
                case 43:
                    fourtythreeLbl.ForeColor = Color.Yellow;
                    break;
                case 44:
                    fourtyfourLbl.ForeColor = Color.Yellow;
                    break;
                case 45:
                    fourtyfiveLbl.ForeColor = Color.Yellow;
                    break;
                case 46:
                    fourtysixLbl.ForeColor = Color.Yellow;
                    break;
                case 47:
                    fourtysevenLbl.ForeColor = Color.Yellow;
                    break;
                case 48:
                    fourtyeightLbl.ForeColor = Color.Yellow;
                    break;
                case 49:
                    fourtynineLbl.ForeColor = Color.Yellow;
                    break;
                case 50:
                    fiftyLbl.ForeColor = Color.Yellow;
                    break;
                case 51:
                    fiftyoneLbl.ForeColor = Color.Yellow;
                    break;
                case 52:
                    fiftytwoLbl.ForeColor = Color.Yellow;
                    break;
                case 53:
                    fiftythreeLbl.ForeColor = Color.Yellow;
                    break;
                case 54:
                    fiftyfourLbl.ForeColor = Color.Yellow;
                    break;
                case 55:
                    fiftyfiveLbl.ForeColor = Color.Yellow;
                    break;
                case 56:
                    fiftysixLbl.ForeColor = Color.Yellow;
                    break;
                case 57:
                    fiftysevenLbl.ForeColor = Color.Yellow;
                    break;
                case 58:
                    fiftyeightLbl.ForeColor = Color.Yellow;
                    break;
                case 59:
                    fiftynineLbl.ForeColor = Color.Yellow;
                    break;
                case 60:
                    sixtyLbl.ForeColor = Color.Yellow;
                    break;
                case 61:
                    sixtyoneLbl.ForeColor = Color.Yellow;
                    break;
                case 62:
                    sixtytwoLbl.ForeColor = Color.Yellow;
                    break;
                case 63:
                    sixtythreeLbl.ForeColor = Color.Yellow;
                    break;
                case 64:
                    sixtyfourLbl.ForeColor = Color.Yellow;
                    break;
                case 65:
                    sixtyfiveLbl.ForeColor = Color.Yellow;
                    break;
                case 66:
                    sixtysixLbl.ForeColor = Color.Yellow;
                    break;
                case 67:
                    sixtysevenLbl.ForeColor = Color.Yellow;
                    break;
                case 68:
                    sixtyeightLbl.ForeColor = Color.Yellow;
                    break;
                case 69:
                    sixtynineLbl.ForeColor = Color.Yellow;
                    break;
                case 70:
                    seventyLbl.ForeColor = Color.Yellow;
                    break;
                case 71:
                    seventyoneLbl.ForeColor = Color.Yellow;
                    break;
                case 72:
                    seventytwoLbl.ForeColor = Color.Yellow;
                    break;
                case 73:
                    seventythreeLbl.ForeColor = Color.Yellow;
                    break;
                case 74:
                    seventyfourLbl.ForeColor = Color.Yellow;
                    break;
                case 75:
                    seventyfiveLbl.ForeColor = Color.Yellow;
                    break;
            }
        }
        
        private void Call_Number()
        {
            number = bingoBalls[0];
            bingoBalls.RemoveAt(0);
            b.PlaySound(number);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            
            while (!worker.CancellationPending)
            {
                if (bingoBalls.Count() > 0)
                {
                    Call_Number();
                    MarkBoard(number);
                    numbersCalled.Add(number);
                    Thread.Sleep(delay);
                }
            }
        }

        private void MarkBoard_TakeTwo()
        {
            //switch (number)
            //{
            //case 1:
            //    oneLbl.ForeColor = Color.Yellow;
            //    break;
            //}
            foreach (GroupBox gb in groupBoxOne.Controls)
            {

            }



        }

        private void ClearBoard()
        {
            foreach (GroupBox gb in groupBoxOne.Controls)
            {
                foreach (Control ctrl in gb.Controls)
                {
                    ctrl.ForeColor = Color.Empty;
                }
            }
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScrambleBalls();
            backgroundWorker1.RunWorkerAsync();
        }

        private void stopGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                string message = "Is this a valid Bingo?";
                string completeMessage = message + "\nThe last number called was: \n" + numbersCalled.Last();
                string title = "Verify Bingo";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                backgroundWorker1.CancelAsync();
                
                DialogResult result = MessageBox.Show(completeMessage, title, buttons);
               
                if (result == DialogResult.Yes)
                {
                    ClearBoard();
                }
                else
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
        }

        private void speedBingoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //speed = fast
            delay = fast_delay;
            regularToolStripMenuItem.Checked = false;
            slowToolStripMenuItem.Checked = false;
            crazyToolStripMenuItem.Checked = false;
            speedBingoToolStripMenuItem.Checked = true;
        }

        private void slowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //speed = slow
            delay = slow_delay;
            regularToolStripMenuItem.Checked = false;
            speedBingoToolStripMenuItem.Checked = false;
            crazyToolStripMenuItem.Checked = false;
            slowToolStripMenuItem.Checked = true;
        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //speed = regular
            delay = reg_delay;
            regularToolStripMenuItem.Checked = true;
            speedBingoToolStripMenuItem.Checked = false;
            crazyToolStripMenuItem.Checked = false;
            slowToolStripMenuItem.Checked = false;
        }

        private void crazyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //speed = crazy
            delay = crazy_delay;
            regularToolStripMenuItem.Checked = false;
            speedBingoToolStripMenuItem.Checked = false;
            crazyToolStripMenuItem.Checked = true;
            slowToolStripMenuItem.Checked = false;
        }
    }
}