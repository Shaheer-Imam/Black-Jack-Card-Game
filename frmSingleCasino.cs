using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//William Tran
//Nov 6, 2018
//Singleplayer Casino Blackjack
//The player play a game of blackjack against the dealer in casino style

//todo:
//add stats: starting cash, round number, gross winnings, highest held cash amount
//clean up win conditions

namespace BlackJack
{
    public partial class frmSingleCasino : Form
    {
        enum BetState //controls if bet is increased or decreased
        {
            Increase,
            Decrease,
            None
        }

        private Deck mDeck; //whole deck of cards
        private Hand mPlayer; //cards in player's hand
        private Hand mDealer; //cards in dealer's hand
        private int mCash; //keeps track of player's money
        private int mStartingCash; //how much player starts with in each game
        private int mBet; //how much the player has bet
        private BetState PlayerBetState = BetState.None;


        public frmSingleCasino(int StartingCash)
        {
            InitializeComponent();
            mStartingCash = StartingCash;
            NewGame();
        }

        private void mnuGameNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void mnuGameHelp_Click(object sender, EventArgs e)
        {
            //show message box with all the rules
            MessageBox.Show("Rules:\n" +
                "\n" +
                "The minimum bet is $5\n" +
                "\n" +
                "Taken from https://wizardofodds.com/games/blackjack/basics/ \n" +
                "The object of the game is to beat the dealer.\n" +
                "Aces may be counted as 1 or 11 points, 2 to 9 according to pip value, and tens and face cards count as ten points.\n" +
                "The value of a hand is the sum of the point values of the individual cards. Except, a \"blackjack\" is the highest hand, consisting of an ace and any 10-point card, and it outranks all other 21-point hands.\n" +
                "After the player has bet, the dealer will give two cards to each player and two cards to himself. One of the dealer cards is dealt face up.\n" +
                "If the dealer does have a blackjack, then the player loses, unless the player also has a blackjack, which will result in a tie.\n" +
                "\n" +
                "Possible player choices:\n" +
                "Stand: Player stands pat with his cards.\n" +
                "Hit: Player draws another card (and more if he wishes). If this card causes the player's total points to exceed 21 (known as \"busting\") then he loses.\n" +
                "Double: Player doubles his bet and gets one, and only one, more card.\n" +
                "\n" +
                "After the player turn, the dealer will add card to his own hand until he gets at least 17 points.\n" +
                "If the dealer busts, the player wins.\n" +
                "If the dealer does not bust, then the higher point total between the player and dealer will win.\n" +
                "Winning wagers pay even money, except a winning player blackjack usually pays 3 to 2\n" +
                "\n" +
                "Shortcuts:\n" +
                "'A' = Deal\n" +
                "'D' = Hold\n" +
                "'Q' = Double\n" +
                "'Space' = Confirm Bet");
        }

        private void mnuGameExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //end application  
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            //add a card to the players hand and redraw
            mPlayer.AddCard(mDeck.Deal());
            Invalidate(); //redraw

            //if player is bust, calculate money won or lost
            if (mPlayer.getScore() > 21) EndRound();
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            mDealer.getCard(1).FaceDown = false; //flip up dealers second card and redraw
            while (mDealer.getScore() < 17) mDealer.AddCard(mDeck.Deal()); //keep giving dealer cards until he is at least at 17 points
            this.Invalidate();
            EndRound(); //calculate money won or lost
        }

        private void btnConfirmBet_Click(object sender, EventArgs e)
        {
            //enable game features
            btnDeal.Enabled = true;
            btnHold.Enabled = true;
            if (mBet * 2 <= mCash) btnDouble.Enabled = true;
            //disable bet features
            btnConfirmBet.Enabled = false;
            tmrBetting.Enabled = false;

            StartNewRound();
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            mBet *= 2;
            lblBetAmount.Text = "Bet: $" + mBet;

            //add a card to the players hand and redraw
            mPlayer.AddCard(mDeck.Deal());
            Invalidate(); //redraw

            //if player is bust, calculate money won or lost
            if (mPlayer.getScore() > 21) EndRound();
            else btnHold.PerformClick();
        }

        protected override void OnPaint(PaintEventArgs e) //override OnPaint event
        {
            base.OnPaint(e);
            //draw hand
            if (mPlayer != null) mPlayer.DrawHand(e.Graphics, 24, 207);
            if (mDealer != null) mDealer.DrawHand(e.Graphics, 208, 60);
        }

        private void StartNewRound() //resets deck and hand, shuffles, adds 2 cards to hand
        {
            //shuffle deck and give player 2 cards to start
            mDeck.Shuffle();
            mPlayer.AddCard(mDeck.Deal());
            mPlayer.AddCard(mDeck.Deal());

            //give dealer 2 cards, one up and one down
            mDealer.AddCard(mDeck.Deal());
            mDealer.AddCard(mDeck.DealFaceDown());

            //repaint form
            this.Invalidate();

            //if player or dealer has blackjack, calculate money won
            if (mPlayer.getScore() == 21 || mDealer.getScore() == 21)
            {
                mDealer.getCard(1).FaceDown = false; //flip up dealers second card and redraw
                this.Invalidate();
                EndRound();
            }
        }

        private void EndRound()
        {
            int PlayerScore = mPlayer.getScore(); //value of all cards in player's hand
            int DealerScore = mDealer.getScore(); //value of all cards in dealer's hand

            //if statement for each round end condition
            //each condition changes the players money and shows what the player got
            if (PlayerScore > 21)
            {
                MessageBox.Show("Bust.\nLose $" + mBet + ".");
                mCash -= mBet;
            }
            else if (DealerScore > 21)
            {
                MessageBox.Show("Dealer bust.\nWin $" + mBet + ".");
                mCash += mBet;
            }
            else if (PlayerScore == 21 && DealerScore == 21)
            {
                if (mPlayer.GetNumOfCards == 2 && mDealer.GetNumOfCards == 2)
                {
                    MessageBox.Show("Both player and dealer have Blackjack.\nBet of $" + mBet + " returned.");
                }
                else if (mPlayer.GetNumOfCards == 2)
                {
                    int NewBet = (int)(mBet * 1.5); //3:2 returns for player Blackjack
                    MessageBox.Show("Player's Blackjack beats dealer's 21.\nWin $" + NewBet + ".");
                    mCash += NewBet;
                }
                else if (mDealer.GetNumOfCards == 2)
                {
                    MessageBox.Show("Dealer's Blackjack beats players's 21.\nLose $" + mBet + ".");
                    mCash -= mBet;
                }
                else
                {
                    MessageBox.Show("Both player and dealer have 21 points.\nBet of $" + mBet + " returned.");
                }
            }
            else if (PlayerScore > DealerScore)
            {
                if (mPlayer.GetNumOfCards == 2 && PlayerScore == 21)
                {
                    int NewBet = (int)(mBet * 1.5); //3:2 returns for player Blackjack
                    MessageBox.Show("Player's has Blackjack.\nWin $" + NewBet + ".");
                    mCash += NewBet;
                }
                else
                {
                    MessageBox.Show("Player has higher score than dealer.\nWin bet of $" + mBet + ".");
                    mCash += mBet;
                }
            }
            else if (PlayerScore == DealerScore)
            {
                MessageBox.Show("Player and dealer have same score.\nBet of $" + mBet + " returned.");
            }
            else //only other possibility is if PlayerScore < DealerScore
            {
                if (mDealer.GetNumOfCards == 2 && DealerScore == 21)
                {
                    MessageBox.Show("Dealer has Blackjack.\nLose bet of $" + mBet + ".");
                }
                else
                {
                    MessageBox.Show("Player has lower score than dealer.\nLose bet of $" + mBet + ".");
                }
                mCash -= mBet;
            }

            //change text of bank
            lblCashAmount.Text = "Player Bank: $" + mCash;

            //check for if money is left
            if (mCash <= 0)
            {
                //player loses and turn off buttons
                MessageBox.Show("You lose.\nYou don't have enough money to meet the $5 minimum bet amount.");
                btnDeal.Enabled = false;
                btnHold.Enabled = false;
            }
            else
            {
                //start next round
                if (mBet > mCash) //change bet if it is higher than cash
                {
                    mBet = mCash - (mCash % 5); //round bet down to multiple of 5
                    lblBetAmount.Text = "Bet: $" + mBet;
                }
                StartBettingStage();
            }
        }

        private void StartBettingStage()
        {
            //initialize deck and hand
            mDeck = new Deck();
            mPlayer = new Hand();
            mDealer = new Hand();
            //redraw
            this.Invalidate();

            btnDeal.Enabled = false;
            btnHold.Enabled = false;
            btnDouble.Enabled = false;
            btnConfirmBet.Enabled = true;
            tmrBetting.Enabled = true;

        }

        private void NewGame()
        {
            //reset and show dollars left
            mCash = mStartingCash;
            lblCashAmount.Text = "Player Bank: $" + mCash;
            mBet = 5;
            lblBetAmount.Text = "Bet: $" + mBet;

            //reset buttons
            btnDeal.Enabled = false;
            btnHold.Enabled = false;

            StartBettingStage(); //resets deck and hand, shuffles, adds 2 cards to hand
        }

        private void tmrBetting_Tick(object sender, EventArgs e) //ticks during betting to see if player want to increase/decrease bet
        {
            //bets must be able to be increased/decreased to be changed
            if((PlayerBetState == BetState.Increase && mBet + 5 <= mCash ) || (PlayerBetState == BetState.Decrease && mBet - 5 >= 5))
            {
                if (PlayerBetState == BetState.Increase) mBet += 5;
                else mBet-= 5;
                lblBetAmount.Text = "Bet: $" + mBet;
            }
            
        }

        private void frmSingleCasino_KeyDown(object sender, KeyEventArgs e)
        {
            //hotkeys
            if (e.KeyCode == Keys.A) btnDeal.PerformClick();
            else if (e.KeyCode == Keys.D) btnHold.PerformClick();
            else if (e.KeyCode == Keys.Q) btnDouble.PerformClick();
            else if (e.KeyCode == Keys.Space) btnConfirmBet.PerformClick();
            else if (tmrBetting.Enabled == true)
            {
                if (e.KeyCode == Keys.W) PlayerBetState = BetState.Increase;
                else if (e.KeyCode == Keys.S) PlayerBetState = BetState.Decrease;
            }
        }

        private void frmSingleCasino_KeyUp(object sender, KeyEventArgs e)
        {
            if (tmrBetting.Enabled == true)
            {
                if (e.KeyCode == Keys.W) PlayerBetState = BetState.None;
                else if (e.KeyCode == Keys.S) PlayerBetState = BetState.None;
            }
        }

        private void frmSingleCasino_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to return to the main menu?", "Blackjack", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
