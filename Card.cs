using System;
using System.Drawing;
using System.Drawing.Drawing2D;

//William Tran
//Oct 23, 2018
//Card Class
//Holds each card's name and value

namespace BlackJack
{
    public class Card
    {
        //*************************************************************
        //Private Fields
        //*************************************************************

        private readonly int mValue;  //face value of the card 2-11
        private readonly string mCardName;  //card name (in resource file) for the card to draw it
        private bool mFaceDown = false; //says is card is facedown

        //*************************************************************
        //Constructors
        //*************************************************************

        public Card(int Value, string CardName)
        {
            //use value and name given
            mValue = Value;
            mCardName = CardName;
        }

        //*************************************************************
        //Properties (accessor and mutators)
        //*************************************************************
        
        public int CardValue //property to get access to the card value
        {
            get { return mValue; }
        }

        public bool FaceDown //property to get access to the card value
        {
            set { mFaceDown = value; }
        }
        //*************************************************************
        //Methods
        //*************************************************************

        public void DrawCard(Graphics g, int x, int y)
        {
            //draw this card or hidden card at the location x and y 
            Bitmap CardToDraw = null;
            if (mFaceDown) CardToDraw = (Bitmap)CardImages.ResourceManager.GetObject("CardFaceDown");
            else CardToDraw = (Bitmap)CardImages.ResourceManager.GetObject(mCardName);
            g.DrawImage(CardToDraw, x, y);
        }
    }
}
