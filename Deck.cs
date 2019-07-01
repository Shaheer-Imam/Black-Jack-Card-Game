using System;
using System.Drawing;
using System.Drawing.Drawing2D;

//William Tran
//Oct 23, 2018
//Deck Class
//Holds all the cards in the deck and can be shuffled

namespace BlackJack
{
    public class Deck
    {
        //*************************************************************
        //Private Fields
        //*************************************************************

        private readonly Card[] mDeck; //will hold 52 cards
        private int mNextCard; //represents index of card to deal next

        //*************************************************************
        //Constructors
        //*************************************************************
        public Deck()
        {
            //create all 52 cards and assign them to the deck variable
            mDeck = new Card[52];
            mNextCard = 0;

            //create the 52 cards and assign to deck
            int ValueCounter = 2; //keeps track of the value of the numeric cards

            //loop through each card
            for (int i = 0; i < 52; i++)
            {
                if (i == 0 || i == 13 || i == 26 || i == 39) //for aces value is 1
                {
                    mDeck[i] = new Card(1, "Card" + (i+1));
                }
                else if (i == 10 || i == 23 || i == 36 || i == 49 || //each jack
                         i == 11 || i == 24 || i == 37 || i == 50 || //each queen
                         i == 12 || i == 25 || i == 38 || i == 51 )  //each king
                {
                    //value for all these is 10
                    mDeck[i] = new Card(10, "Card" + (i+1));
                }
                else
                {
                    //value for numberic cards is ValueCounter, which increments
                    mDeck[i] = new Card(ValueCounter, "Card" + (i + 1));
                    ValueCounter++;
                    if (ValueCounter == 11) ValueCounter = 2; //reset ValueCounter back to 2 if it is over 10
                }
            }
        }

        //*************************************************************
        //Properties
        //*************************************************************

        public Card[] GetDeck //gives access to the deck
        {
            get { return mDeck; }
        }

        //*************************************************************
        //Methods
        //*************************************************************
        public void Shuffle()
        {
            //shuffles the deck
            Random rand = new Random(); //use Random to find out what to shuffle to
            Card Temp; //temporarily stores cards while swapping around

            int SwapTo; //holds index of card to swap

            //shuffle 3 times
            for (int i = 0; i < 3; i++)
            {
                //for each index:
                for (int j = 0; j < 52; j++)
                {
                    //get random index
                    SwapTo = rand.Next(0, 51);
                    if (SwapTo == j) //if random index and j are the same:
                    {
                        j--; //decrement j so that it has to try again and find a different random index
                    }
                    else
                    {
                        //swap places of index j and random index by using temp
                        Temp = mDeck[SwapTo];
                        mDeck[SwapTo] = mDeck[j];
                        mDeck[j] = Temp;
                    }
                }
            }
        }

        public Card Deal()
        {
            Card card = mDeck[mNextCard]; //this is the card that is dealt to player's hand
            mNextCard++; //increment so that next time the next card will be dealt
            return card;
        }

        public Card DealFaceDown()
        {
            Card card = mDeck[mNextCard]; //this is the card that is dealt to player's hand
            mNextCard++; //increment so that next time the next card will be dealt
            card.FaceDown = true;
            return card;
        }
    }
}
