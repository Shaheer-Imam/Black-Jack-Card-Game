using System;
using System.Drawing;
using System.Drawing.Drawing2D;

//William Tran
//Oct 23, 2018
//Hand Class
//Holds the cards that are currently in the player's hand

namespace BlackJack
{
    public class Hand
    {
        //*************************************************************
        //Private Fields
        //*************************************************************

        private readonly Card[] mHand; //players hand
        private int mNumOfCards; //number of cards in hand
        private bool mHasAce; //keeps track is ace is in hand

        //*************************************************************
        //Constructor
        //*************************************************************

        public Hand() //make empty hand with 0 cards
        {
            mHand = new Card[12]; //max 12 cards per hand 
            mNumOfCards = 0;
        }

        //*************************************************************
        //Properties
        //*************************************************************

        public int GetNumOfCards //property to get access to the # of cards
        {
            get { return mNumOfCards; }
        }

        //*************************************************************
        //Methods
        //*************************************************************

        public void AddCard(Card Card)
        {
            //assign this card to hand and increment card counter and ace counter if applicable
            mHand[mNumOfCards] = Card;
            mNumOfCards++;

            if (Card.CardValue == 1) mHasAce = true;
        }

        public void DrawHand(Graphics g, int StartX, int Y)
        {
            int X = StartX;

            //loop through each card in the hand 
            for (int i = 0; i < mNumOfCards; i++)
            {
                //draw card then add 80 to x so that the next card will be drawn beside it
                mHand[i].DrawCard(g, X, Y);
                X += 80;
            }
        }

        public Card getCard(int NumOfCard) //property to get card
        {
            return mHand[NumOfCard];
        }

        public int getScore()
        {
            //adds up and returns total value of the cards
            int Score = 0;
            for (int i = 0; i < mNumOfCards; i++) //loop through each card 
            {
                Score += mHand[i].CardValue;
            }
            if (mHasAce)
            {
                int NewScore = Score + 10; //NewScore is score if the ace is counted as an 11
                if (NewScore <= 21) Score = NewScore; //if NewScore is valid, then it is the score returned
            }
            return Score;
        }

    }
}
