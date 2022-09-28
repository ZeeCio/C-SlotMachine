using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment1Exercise2SlotMachineWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int a, b, c, move,wins,balance = 100,loss, bid;

        private void btn_bid_Click(object sender, EventArgs e)
        {
            balance += 100;
            lbl_balance.Text = "Balance:£" + (Convert.ToString(balance));
        }

        void Game_Result()
        {
            balance -= bid;
            if (a == b && b == c && a == 9)
            {
                wins++;
                lbl_win.Text = "Wins:" + wins;
                balance += 2000 * bid;
                
                lbl_casino.Text = "Jackpot ";
            }
            else if ((a == b && a == 9) || (b == c && b == 9) || (a == c && a == 9))
            {
                wins++;
                lbl_win.Text = "Wins:" + wins;
                balance += 200 * bid;
                lbl_casino.Text = "You Won";
            }
           else if (a == b && b == c)
           {
                wins++;
                lbl_win.Text = "Wins:" + wins;
                balance += 15 * bid;
                lbl_casino.Text = "You won ";
           }
            else if (a == b || b == c || a == c)
            {
                wins++;
                lbl_win.Text = "Wins:" + wins;
                balance += 5 * bid;
                lbl_casino.Text = "You won";
            }
            else
            {
                loss++;
                lbl_loss.Text = "Loss:" + loss;
                lbl_casino.Text = "Try again";
            }
            if (balance <= 0)
            {
                btn_spin.Text = "No Balance.";
            }
            else
            {
                btn_spin.Text = "Continue playing...";
            }
            lbl_balance.Text = "Balance:£" + (Convert.ToString(balance));
            textBox1.Text = Convert.ToString(bid);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_spin_Click(object sender, EventArgs e)
        {
            try
            {
                bid = int.Parse(textBox1.Text);
                btn_spin.Enabled = true;
            }
            catch (Exception)
            {
                bid = 0;
            }
            if (balance >= bid)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please press the Spin Button key and enter the bid amount inside the textbox to play..");
                }
                else
                {
                    timer1.Enabled = true;
                    lbl_casino.Text = "Casino";
                    textBox1.BackColor = Color.White;
                }
            }
            else
            {
                MessageBox.Show("Not enough balance");
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            move++;
            if (move < 30)
            {
                a = rnd.Next(10);
                b = rnd.Next(10);
                c = rnd.Next(10);
                switch(a)
                {
                    case 0:
                        pictureBox1.Image = Properties.Resources.zero;
                        break;
                    case 1:
                        pictureBox1.Image = Properties.Resources.one;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.two;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.three;
                        break;
                    case 4:
                        pictureBox1.Image = Properties.Resources.four;
                        break;
                    case 5:
                        pictureBox1.Image = Properties.Resources.five;
                        break;
                    case 6:
                        pictureBox1.Image = Properties.Resources.six;
                        break;
                    case 7:
                        pictureBox1.Image = Properties.Resources.seven;
                        break;
                    case 8:
                        pictureBox1.Image = Properties.Resources.eight;
                        break;
                    case 9:
                        pictureBox1.Image = Properties.Resources.nine;
                        break;
                }
                switch (b)
                {
                    case 0:
                        pictureBox2.Image = Properties.Resources.zero;
                        break;
                    case 1:
                        pictureBox2.Image = Properties.Resources.one;
                        break;
                    case 2:
                        pictureBox2.Image = Properties.Resources.two;
                        break;
                    case 3:
                        pictureBox2.Image = Properties.Resources.three;
                        break;
                    case 4:
                        pictureBox2.Image = Properties.Resources.four;
                        break;
                    case 5:
                        pictureBox2.Image = Properties.Resources.five;
                        break;
                    case 6:
                        pictureBox2.Image = Properties.Resources.six;
                        break;
                    case 7:
                        pictureBox2.Image = Properties.Resources.seven;
                        break;
                    case 8:
                        pictureBox2.Image = Properties.Resources.eight;
                        break;
                    case 9:
                        pictureBox2.Image = Properties.Resources.nine;
                        break;
                }
                switch (c)
                {
                    case 0:
                        pictureBox3.Image = Properties.Resources.zero;
                        break;
                    case 1:
                        pictureBox3.Image = Properties.Resources.one;
                        break;
                    case 2:
                        pictureBox3.Image = Properties.Resources.two;
                        break;
                    case 3:
                        pictureBox3.Image = Properties.Resources.three;
                        break;
                    case 4:
                        pictureBox3.Image = Properties.Resources.four;
                        break;
                    case 5:
                        pictureBox3.Image = Properties.Resources.five;
                        break;
                    case 6:
                        pictureBox3.Image = Properties.Resources.six;
                        break;
                    case 7:
                        pictureBox3.Image = Properties.Resources.seven;
                        break;
                    case 8:
                        pictureBox3.Image = Properties.Resources.eight;
                        break;
                    case 9:
                        pictureBox3.Image = Properties.Resources.nine;
                        break;
                }
            }
            else
            {
                timer1.Enabled = false;
                move = 0;
                Game_Result();
            }
        }
    }
}
