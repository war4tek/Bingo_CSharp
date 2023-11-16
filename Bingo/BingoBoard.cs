using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace Bingo
{
    public partial class BingoBoard : Form
    {
        private int number;
        private List<int> bingoBalls;
        private List<int> numbersCalled;
        private const int slow_delay = 9000;
        private const int reg_delay = 7000;
        private const int fast_delay = 6000;
        private const int crazy_delay = 3800;
        
        private int delay = slow_delay;
        
        public BingoBoard()
        {
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

        private void Call_Number()
        {
            number = bingoBalls[0];
            bingoBalls.RemoveAt(0);
            PlaySound(number);
        }

        private void MarkBoard(int number)
        {
            string numberCalled = number.ToString();

            if (number >= 1 && number <= 15)
            {
                //iterate through the first group of controls to find the correct label to mark
                foreach (Control ctrl in groupBox1.Controls)
                {
                    if (ctrl.Text == numberCalled)
                    {
                        ctrl.ForeColor = Color.Yellow;
                    }
                }
            }
            else if (number >= 16 && number <=30)
            {
                //iterate through the second group of controls to find the correct label to mark
                foreach (Control ctrl in groupBox2.Controls)
                {
                    if (ctrl.Text == numberCalled)
                    {
                        ctrl.ForeColor = Color.Yellow;
                    }
                }
            }
            else if (number >= 31 && number <=45)
            {
                //iterate through the third group of controls to find the correct label to mark
                foreach (Control ctrl in groupBox3.Controls)
                {
                    if (ctrl.Text == numberCalled)
                    {
                        ctrl.ForeColor = Color.Yellow;
                    }
                }
            }
            else if (number >= 46 && number <=60)
            {
                //iterate through the fourth group of controls to find the correct label to mark
                foreach (Control ctrl in groupBox4.Controls)
                {
                    if (ctrl.Text == numberCalled)
                    {
                        ctrl.ForeColor = Color.Yellow;
                    }
                }
            }
            else if (number >=61 && number <= 75)
            {
                //iterate through the fifth group of controls to find the correct label to mark
                foreach (Control ctrl in groupBox5.Controls)
                {
                    if (ctrl.Text == numberCalled)
                    {
                        ctrl.ForeColor = Color.Yellow;
                    }
                }
            }
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
                MessageBox.Show($"Could not locate audio file for {number}");
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
                    if (!backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }   
                }
            }
        }

        private void updateMenuStrip(int timeDelay, bool isReg, bool isSlow, bool isCrazy, bool isSpeed)
        {
            delay = timeDelay;
            regularToolStripMenuItem.Checked = isReg;
            speedBingoToolStripMenuItem.Checked = isSpeed;   
            crazyToolStripMenuItem.Checked = isCrazy;
            slowToolStripMenuItem.Checked = isSlow;
        }

        private void speedBingoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateMenuStrip(fast_delay,false,false,false,true);
        }

        private void slowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateMenuStrip(slow_delay,false,false,false,true);
        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateMenuStrip(reg_delay, true, false, false, false);    
        }

        private void crazyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateMenuStrip(crazy_delay, false, false, true, false);
        }
    }
}