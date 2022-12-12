namespace TicTacToe_original_
{
    public partial class Form1 : Form
    {
        int turn = 1;
       
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("WELCOME TO TICTACTOE *_*");
        }
        void Enable_False()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        void cleargame()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            label2.Text  = "1";
        }
                private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                if (turn == 1)
                {
                    button1.Text = "O";
                    turn = 2;
                    label2.Text = "2";
                }
                else
                {
                    button1.Text = "X";
                    turn = 1;
                    label2.Text = "1";
                }
            }
            CheckWinner();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                if (turn == 1)
                {
                    button2.Text = "O";
                    turn = 2;
                    label2.Text = "2";
                }
                else
                {
                    button2.Text = "X";
                    turn = 1;
                    label2.Text = "1";
                }
            }
            CheckWinner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                if (turn == 1)
                {
                    button3.Text = "O";
                    turn = 2;
                    label2.Text = "2";
                }
                else
                {
                    button3.Text = "X";
                    turn = 1;
                    label2.Text = "1";
                }
                
            }
            CheckWinner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                if (turn == 1)
                {
                    button4.Text = "O";
                    turn = 2;
                    label2.Text = "2";
                }
                else
                {
                    button4.Text = "X";
                    turn = 1;
                    label2.Text = "1";
                }
                
            }
            CheckWinner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                if (turn == 1)
                {
                    button5.Text = "O";
                    turn = 2;
                    label2.Text = "2";
                }
                else
                {
                    button5.Text = "X";
                    turn = 1;
                    label2.Text = "1";
                }
            }
            CheckWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                if (turn == 1)
                {
                    button6.Text = "O";
                    turn = 2;
                    label2.Text = "2";
                }
                else
                {
                    button6.Text = "X";
                    turn = 1;
                    label2.Text = "1";
                }
            }
            CheckWinner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                if (turn == 1)
                {
                    button7.Text = "O";
                    turn = 2;
                    label2.Text = "2";
                }
                else
                {
                    button7.Text = "X";
                    turn = 1;
                    label2.Text = "1";
                }
              
            }
            CheckWinner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                if (turn == 1)
                {
                    button8.Text = "O";
                    turn = 2;
                    label2.Text = "2";
                }
                else
                {
                    button8.Text = "X";
                    turn = 1;
                    label2.Text = "1";
                }
            }
            CheckWinner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                if (turn == 1)
                {
                    button9.Text = "O";
                    turn = 2;
                    label2.Text = "2";
                }
                else
                {
                    button9.Text = "X";
                    turn = 1;
                    label2.Text = "1";
                }
            }
            CheckWinner();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cleargame();
        }

        

        private void button11_Click(object sender, EventArgs e)
        {
            cleargame();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       public void CheckWinner()
        { 
            if((button1.Text==button2.Text) && (button1.Text == button3.Text) && (button1.Text != "") && (button2.Text != "") && (button3.Text != ""))
            {
                if (button1.Text == "O")
                {
                    MessageBox.Show("Player 1 Wins!");

                }
                else
                {
                    MessageBox.Show("Player 2 Wins!");

                }
            }
            else if (button4.Text == button5.Text && button4.Text == button6.Text && (button4.Text != "") && (button5.Text != "") && (button6.Text != ""))
            {
                if (button4.Text == "O")
                {
                    MessageBox.Show("Player 1 Wins!");

                }
                else
                {
                    MessageBox.Show("Player 2 Wins!");

                }
            }
            else if (button7.Text == button8.Text && button7.Text == button9.Text && (button7.Text != "") && (button8.Text != "") && (button9.Text != ""))
            {
                if (button7.Text == "O")
                {
                    MessageBox.Show("Player 1 Wins!");

                }
                else
                {
                    MessageBox.Show("Player 2 Wins!");

                }
            }
            else if (button1.Text == button4.Text && button1.Text == button7.Text && (button1.Text != "") && (button4.Text != "") && (button7.Text != ""))
            {
                if (button1.Text == "O")
                {
                    MessageBox.Show("Player 1 Wins!");

                }
                else
                {
                    MessageBox.Show("Player 2 Wins!");

                }
            }
            else if (button2.Text == button5.Text && button2.Text == button8.Text && (button2.Text != "") && (button5.Text != "") && (button8.Text != ""))
            {
                if (button2.Text == "O")
                {
                    MessageBox.Show("Player 1 Wins!");

                }
                else
                {
                    MessageBox.Show("Player 2 Wins!");

                }
            }
            else if (button3.Text == button6.Text && button3.Text == button9.Text && (button3.Text != "") && (button6.Text != "") && (button9.Text != ""))
            {
                if (button3.Text == "O")
                {
                    MessageBox.Show("Player 1 Wins!");

                }
                else
                {
                    MessageBox.Show("Player 2 Wins!");

                }
            }
            else if (button1.Text == button5.Text && button1.Text == button9.Text && (button1.Text != "") && (button5.Text != "") && (button9.Text != ""))
            {
                if (button1.Text == "O")
                {
                    MessageBox.Show("Player 1 Wins!");

                }
                else
                {
                    MessageBox.Show("Player 2 Wins!");

                }
            }
            else if (button3.Text == button5.Text && button3.Text == button7.Text && (button3.Text != "") && (button5.Text != "") && (button7.Text != ""))
            {
                if (button3.Text == "O")
                {
                    MessageBox.Show("Player 1 Wins!");

                }
                else
                {
                    MessageBox.Show("Player 2 Wins!");

                }
            }

        }
     
    }
}
 

        
    
