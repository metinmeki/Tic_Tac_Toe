namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] gameBord = new string[9];
        int currenTurn = 0;

        public string returnSymbol(int turn)
        {
            return (turn % 2 == 0) ? "X" : "O";
        }

        public void checkForWinner()
        {
            for (int i = 0; i < 8; i++)
            {
                string combination = "";

                switch (i)
                {
                    case 0:
                        combination = gameBord[0] + gameBord[4] + gameBord[8];
                        break;
                    case 1:
                        combination = gameBord[2] + gameBord[4] + gameBord[6];
                        break;
                    case 2:
                        combination = gameBord[0] + gameBord[1] + gameBord[2];
                        break;
                    case 3:
                        combination = gameBord[3] + gameBord[4] + gameBord[5];
                        break;
                    case 4:
                        combination = gameBord[6] + gameBord[7] + gameBord[8];
                        break;
                    case 5:
                        combination = gameBord[0] + gameBord[3] + gameBord[6];
                        break;
                    case 6:
                        combination = gameBord[2] + gameBord[4] + gameBord[7];
                        break;
                    case 7:
                        combination = gameBord[1] + gameBord[4] + gameBord[7];
                        break;
                }

                if (combination.Equals("OOO"))
                {
                    resetGame();
                    MessageBox.Show("Player O wins!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (combination.Equals("XXX"))
                {
                    resetGame();
                    MessageBox.Show("Player X wins!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        public void resetGame()
        {
            currenTurn = 0;
            gameBord = new string[9];

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gameBord[0])) return;

            currenTurn++;
            gameBord[0] = returnSymbol(currenTurn);
            button1.Text = gameBord[0];
            checkForWinner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gameBord[1])) return;

            currenTurn++;
            gameBord[1] = returnSymbol(currenTurn);
            button2.Text = gameBord[1];
            checkForWinner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gameBord[2])) return;

            currenTurn++;
            gameBord[2] = returnSymbol(currenTurn);
            button3.Text = gameBord[2];
            checkForWinner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gameBord[3])) return;

            currenTurn++;
            gameBord[3] = returnSymbol(currenTurn); // ✅ FIXED
            button4.Text = gameBord[3];
            checkForWinner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gameBord[4])) return;

            currenTurn++;
            gameBord[4] = returnSymbol(currenTurn);
            button5.Text = gameBord[4];
            checkForWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gameBord[5])) return;

            currenTurn++;
            gameBord[5] = returnSymbol(currenTurn);
            button6.Text = gameBord[5];
            checkForWinner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gameBord[6])) return;

            currenTurn++;
            gameBord[6] = returnSymbol(currenTurn); // ✅ FIXED
            button7.Text = gameBord[6];
            checkForWinner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gameBord[7])) return;

            currenTurn++;
            gameBord[7] = returnSymbol(currenTurn);
            button8.Text = gameBord[7];
            checkForWinner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gameBord[8])) return;

            currenTurn++;
            gameBord[8] = returnSymbol(currenTurn);
            button9.Text = gameBord[8];
            checkForWinner();
        }
    }
}
