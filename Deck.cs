using System;

namespace hiloSpecification
{
    class Deck
    {
        // Attributes
        public int cardValue;

        // Constructor
        public Deck()
        {
            cardValue = DrawCard();
        }

        public int DrawCard() {
            Random random = Random();
        
            bool validCard = false; 
            while (validCard == false) {
                card = random.Next(1,14); 
                
                if (card != cardValue) {
                    return card;
                    validCard = true;
                }
            }
        }
    }   
}