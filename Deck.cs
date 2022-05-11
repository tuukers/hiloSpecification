using System;

namespace hilo
{
    class Deck
    {
        // Attributes
        public int cardValue;
        public int card;
        public int score;



        // Constructor
        public Deck()
        {
            cardValue = DrawCard();
            this.score =300;
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

        public int Score(string Guess, int currentCard, int newCard)
        {
            if (Guess=="h")
                {
                    if(currentCard<newCard)
                    {
                        this.score+=100;
                    }
                    else
                    {
                        this.score+=-75;
                    }
                }
                else
                {
                    if(newCard<currentCard)
                    {
                        this.score+=100;
                    }
                    else
                    {
                        this.score+=-75;
                    }
                }
                return (this.score);
        }
    }   
}