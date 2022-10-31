using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool checker;
        int plusOne;
        int x = 255, y = 1;

        void Enable_False()
        {
            btnTic1.Enabled = false;
            btnTic2.Enabled = false;
            btnTic3.Enabled = false;
            btnTic4.Enabled = false;
            btnTic5.Enabled = false;
            btnTic6.Enabled = false;
            btnTic7.Enabled = false;
            btnTic8.Enabled = false;
            btnTic9.Enabled = false;
        }

        void Score()
        {
            if (btnTic1.Text == "X" && btnTic2.Text == "X" && btnTic3.Text == "X")

            {
                btnTic1.BackColor = Color.AliceBlue;
                btnTic2.BackColor = Color.AliceBlue;
                btnTic3.BackColor = Color.AliceBlue;

                MessageBox.Show("Congrats! X is the Winner!", "W-Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic1.Text == "X" && btnTic4.Text == "X" && btnTic7.Text == "X")

            {
                btnTic1.BackColor = Color.RosyBrown;
                btnTic4.BackColor = Color.RosyBrown;
                btnTic7.BackColor = Color.RosyBrown;

                MessageBox.Show("Congrats! X is the Winner!", "W-Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }


            if (btnTic3.Text == "X" && btnTic5.Text == "X" && btnTic7.Text == "X")

            {
                btnTic3.BackColor = Color.Crimson;
                btnTic5.BackColor = Color.Crimson;
                btnTic7.BackColor = Color.Crimson;

                MessageBox.Show("Congrats! X is the Winner!", "W-Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic2.Text == "X" && btnTic5.Text == "X" && btnTic8.Text == "X")

            {
                btnTic2.BackColor = Color.Chocolate;
                btnTic5.BackColor = Color.Chocolate;
                btnTic8.BackColor = Color.Chocolate;

                MessageBox.Show("Congrats! X is the Winner!", "W-Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic3.Text == "X" && btnTic6.Text == "X" && btnTic9.Text == "X")

            {
                btnTic3.BackColor = Color.DarkKhaki;
                btnTic6.BackColor = Color.DarkKhaki;
                btnTic9.BackColor = Color.DarkKhaki;

                MessageBox.Show("Congrats! X is the Winner!", "W-Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic4.Text == "X" && btnTic5.Text == "X" && btnTic6.Text == "X")
            {
                btnTic4.BackColor = Color.BlanchedAlmond;
                btnTic5.BackColor = Color.BlanchedAlmond;
                btnTic6.BackColor = Color.BlanchedAlmond;

                MessageBox.Show("Congrats! X is the Winner!", "W-Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic7.Text == "X" && btnTic8.Text == "X" && btnTic9.Text == "X")
            {
                btnTic7.BackColor = Color.RoyalBlue;
                btnTic8.BackColor = Color.RoyalBlue;
                btnTic9.BackColor = Color.RoyalBlue;

                MessageBox.Show("Congrats! X is the Winner!", "W-Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if(btnTic1.Text == "X" && btnTic5.Text == "X" && btnTic9.Text == "X")
            {
                btnTic1.BackColor = Color.Salmon;
                btnTic5.BackColor = Color.Salmon;
                btnTic9.BackColor = Color.Salmon;

                MessageBox.Show("Congrats! X is the Winner!", "W-Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            //--------------------------------------------------------------------------------------------------------------------------------------------


            if (btnTic1.Text == "O" && btnTic2.Text == "O" && btnTic3.Text == "O")

            {
                btnTic1.BackColor = Color.AliceBlue;
                btnTic2.BackColor = Color.AliceBlue;
                btnTic3.BackColor = Color.AliceBlue;

                MessageBox.Show("Congrats! O is the Winner!", "W-Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic1.Text == "O" && btnTic4.Text == "O" && btnTic7.Text == "O")

            {
                btnTic1.BackColor = Color.LemonChiffon;
                btnTic4.BackColor = Color.LemonChiffon;
                btnTic7.BackColor = Color.LemonChiffon;

                MessageBox.Show("Congrats! O is the Winner!", "W-Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic3.Text == "O" && btnTic5.Text == "O" && btnTic7.Text == "O")

            {
                btnTic3.BackColor = Color.LightBlue;
                btnTic5.BackColor = Color.LightBlue;
                btnTic7.BackColor = Color.LightBlue;

                MessageBox.Show("Congrats! O is the Winner!", "W-Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic2.Text == "O" && btnTic5.Text == "O" && btnTic8.Text == "O")

            {
                btnTic2.BackColor = Color.LightCoral;
                btnTic5.BackColor = Color.LightCoral;
                btnTic8.BackColor = Color.LightCoral;

                MessageBox.Show("Congrats! O is the Winner!", "W-Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic3.Text == "O" && btnTic6.Text == "O" && btnTic9.Text == "O")

            {
                btnTic3.BackColor = Color.LightGreen;
                btnTic6.BackColor = Color.LightGreen;
                btnTic9.BackColor = Color.LightGreen;

                MessageBox.Show("Congrats! O is the Winner!", "W-Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic4.Text == "O" && btnTic5.Text == "O" && btnTic6.Text == "O")
            {
                btnTic4.BackColor = Color.BurlyWood;
                btnTic5.BackColor = Color.BurlyWood;
                btnTic6.BackColor = Color.BurlyWood;

                MessageBox.Show("Congrats! O is the Winner!", "W-Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic7.Text == "O" && btnTic8.Text == "O" && btnTic9.Text == "O")
            {
                btnTic7.BackColor = Color.CornflowerBlue;
                btnTic8.BackColor = Color.CornflowerBlue;
                btnTic9.BackColor = Color.CornflowerBlue;

                MessageBox.Show("Congrats! O is the Winner!", "W-Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerX.Text);
                lblPlayerO.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic1.Text == "O" && btnTic5.Text == "O" && btnTic9.Text == "O")
            {
                btnTic1.BackColor = Color.LightSteelBlue;
                btnTic5.BackColor = Color.LightSteelBlue;
                btnTic9.BackColor = Color.LightSteelBlue;

                MessageBox.Show("Congrats! O is the Winner!", "W-Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerX.Text);
                lblPlayerO.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.SetBounds(x, y, 1, 1);
            x++;
            if (x >800)
            {
                x = 1;
            }

        }

        private void btnTic1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic1.Text = "X";
                checker = true;
            }

            else
            {
                btnTic1.Text = "O";
                checker = false;
            }
            Score();
            btnTic1.Enabled = false;
        }

        private void btnTic2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic2.Text = "X";
                checker = true;
            }

            else
            {
                btnTic2.Text = "O";
                checker = false;
            }
            Score();
            btnTic2.Enabled = false;
        }

        private void btnTic3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic3.Text = "X";
                checker = true;
            }

            else
            {
                btnTic3.Text = "O";
                checker = false;
            }
            Score();
            btnTic3.Enabled = false;
        }

        private void btnTic4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic4.Text = "X";
                checker = true;
            }

            else
            {
                btnTic4.Text = "O";
                checker = false;
            }
            Score();
            btnTic4.Enabled = false;
        }

        private void btnTic5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic5.Text = "X";
                checker = true;
            }

            else
            {
                btnTic5.Text = "O";
                checker = false;
            }
            Score();
            btnTic5.Enabled = false;
        }

        private void btnTic6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic6.Text = "X";
                checker = true;
            }

            else
            {
                btnTic6.Text = "O";
                checker = false;
            }
            Score();
            btnTic6.Enabled = false;
        }

        private void btnTic7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic7.Text = "X";
                checker = true;
            }

            else
            {
                btnTic7.Text = "O";
                checker = false;
            }
            Score();
            btnTic7.Enabled = false;
        }

        private void btnTic8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic8.Text = "X";
                checker = true;
            }

            else
            {
                btnTic8.Text = "O";
                checker = false;
            }
            Score();
            btnTic8.Enabled = false;
        }

        private void btnTic9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic9.Text = "X";
                checker = true;
            }

            else
            {
                btnTic9.Text = "O";
                checker = false;
            }
            Score();
            btnTic9.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                btnTic1.Enabled = true;
                btnTic2.Enabled = true;
                btnTic3.Enabled = true;
                btnTic4.Enabled = true;
                btnTic5.Enabled = true;
                btnTic6.Enabled = true;
                btnTic7.Enabled = true;
                btnTic8.Enabled = true;
                btnTic9.Enabled = true;

                btnTic1.Text = "";
                btnTic2.Text = "";
                btnTic3.Text = "";
                btnTic4.Text = "";
                btnTic5.Text = "";
                btnTic6.Text = "";
                btnTic7.Text = "";
                btnTic8.Text = "";
                btnTic9.Text = "";

                lblPlayerX.Text = "0";
                lblPlayerO.Text = "0";

                btnTic1.BackColor = Color.WhiteSmoke;
                btnTic2.BackColor = Color.WhiteSmoke;
                btnTic3.BackColor = Color.WhiteSmoke;
                btnTic4.BackColor = Color.WhiteSmoke;
                btnTic5.BackColor = Color.WhiteSmoke;
                btnTic6.BackColor = Color.WhiteSmoke;
                btnTic7.BackColor = Color.WhiteSmoke;
                btnTic8.BackColor = Color.WhiteSmoke;
                btnTic9.BackColor = Color.WhiteSmoke;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "W-Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                btnTic1.Enabled = true;
                btnTic2.Enabled = true;
                btnTic3.Enabled = true;
                btnTic4.Enabled = true;
                btnTic5.Enabled = true;
                btnTic6.Enabled = true;
                btnTic7.Enabled = true;
                btnTic8.Enabled = true;
                btnTic9.Enabled = true;

                btnTic1.Text = "";
                btnTic2.Text = "";
                btnTic3.Text = "";
                btnTic4.Text = "";
                btnTic5.Text = "";
                btnTic6.Text = "";
                btnTic7.Text = "";
                btnTic8.Text = "";
                btnTic9.Text = "";

                btnNewGame.Enabled = true;

                btnTic1.BackColor = Color.WhiteSmoke;
                btnTic2.BackColor = Color.WhiteSmoke;
                btnTic3.BackColor = Color.WhiteSmoke;
                btnTic4.BackColor = Color.WhiteSmoke;
                btnTic5.BackColor = Color.WhiteSmoke;
                btnTic6.BackColor = Color.WhiteSmoke;
                btnTic7.BackColor = Color.WhiteSmoke;
                btnTic8.BackColor = Color.WhiteSmoke;
                btnTic9.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Are You Sure You Want to Exit!", "W-Tic Tac Toe",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome To W-Tic Tac Toe Game!";
            label1.Font = new Font(" ", 40, FontStyle.Bold);
            timer1.Interval = 1;
            timer1.Start();
        }
    }
}
