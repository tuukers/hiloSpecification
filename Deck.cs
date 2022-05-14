using System;

namespace hilo
{
    class Deck
    {
        // Attributes
        public int cardValue;
        public int card;



        // Constructor
        public Deck()
        {
            cardValue = DrawCard();
        }

        public int DrawCard() 
        {
            Random random = new Random();
        
            bool validCard = false; 
            while (validCard == false) {
                card = random.Next(1,14); 
                
                if (card != cardValue) {
                    validCard = true;
                } 
            }
            return card;
        }
    }   
}