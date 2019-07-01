using System;
using System.Windows.Forms;

//William Tran
//Oct 23, 2018
//Singleplayer 17 Blackjack
//This program lets the player play a game of blackjack against the dealer who is always at 17 points

namespace BlackJack
{
    public partial class frmSingle17 : Form
    {
        private Deck mDeck; //whole deck of cards
        private Hand mPlayer1; //cards in player's hand
        private int mDollars; //keeps track of player's money
        private int mStartingCash; //how much players start with in each game

        public frmSingle17(int StartingCash)
        {
            InitializeComponent();
            mStartingCash = StartingCash;
            NewGame();
        }

        private void fileExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //end application          
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            Deal();
        }

        private void Deal()
        {
            //add a card to the players hand and redraw
            mPlayer1.AddCard(mDeck.Deal());
            Invalidate(); //redraw

            //if player is bust, calculate money won or lost
            if (mPlayer1.getScore() > 21)
            {
                EndRound();
            }
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            Hold();
        }

        private void Hold()
        {
            EndRound(); //calculate money won or lost
        }

        protected override void OnPaint(PaintEventArgs e) //override OnPaint event
        {
            base.OnPaint(e);
            //draw hand
            if (mPlayer1 != null) mPlayer1.DrawHand(e.Graphics, 20, 100);
        }

        private void StartNewRound() //resets deck and hand, shuffles, adds 2 cards to hand
        {
            //initialize deck and hand
            mDeck = new Deck();
            mPlayer1 = new Hand();

            //shuffle deck and give player 2 cards to start
            mDeck.Shuffle();
            mPlayer1.AddCard(mDeck.Deal());
            mPlayer1.AddCard(mDeck.Deal());

            //repaint form
            this.Invalidate();
        }

        private void EndRound()
        {
            int Score = mPlayer1.getScore(); //value of all cards in hand

            //if statement for each round end condition
            //each condition changes the players money and shows what the player got
            if (Score > 21)
            {
                mDollars -= 10;
                MessageBox.Show("Bust.\nLose $10.");
            }
            else if (Score == 21)
            {
                mDollars += 20;
                MessageBox.Show("Black Jack.\nWin $20.");
            }
            else if (Score >= 18)
            {
                mDollars += 10;
                MessageBox.Show("Beat the dealer.\nWin $10.");
            }
            else
            {
                mDollars -= 5;
                MessageBox.Show("Lower than dealer.\nLose $5.");
            }

            //change text of bank
            lblDollarValue.Text = "Player Bank: $" + mDollars;

            //check for if money is left
            if (mDollars <= 0)
            {
                //player loses and turn off buttons
                MessageBox.Show("You lose.\nNo money is left.");
                btnDeal.Enabled = false;
                btnHold.Enabled = false;
            }
            else
            {
                //start next round
                StartNewRound();
            }
        }

        private void mnuGameNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void NewGame()
        {
            //reset and show dollars left
            mDollars = mStartingCash;
            lblDollarValue.Text = "Player Bank: $" + mDollars;

            //reset buttons
            btnDeal.Enabled = true;
            btnHold.Enabled = true;

            StartNewRound(); //resets deck and hand, shuffles, adds 2 cards to hand
        }

        private void mnuGameHelp_Click(object sender, EventArgs e)
        {
            //show message box with all the rules
            MessageBox.Show("Special Rules:\nThe dealer always has 17 points.\n\nIf you score higher than the dealer, you win $10.\nIf you score lower than the dealer, you lose $5.\nIf you get exactly 21 points, you win $20.\nIf your hand is a bust (over 21 points), you lose $10.\n\nShortcuts:\n'A' = Deal\n'D' = Hold");
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && btnDeal.Enabled == true)
            {
                Deal();
            }
            else if (e.KeyCode == Keys.D && btnHold.Enabled == true)
            {
                Hold();
            }
        }
    }
}
