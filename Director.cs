using System;

namespace hilo
{
    class GameLoop
    {
        // Attributes
        private int score;
        private bool isPlaying;

        public int currentCard;

        private bool First;
        public string Guess;
        public int newCard;
        private string playAgain;

        // Constructor
        public GameLoop()
        {

        }
        
        public void Play()
        {

            First= true;
            isPlaying=true;

            while (isPlaying)
            {
                score = 300;
                if (First)
                {
                    //currentCard=;draw card
                    First=false;
                };
                Console.WriteLine($"Your card is {currentCard}.");
                Console.WriteLine("Do you think the next card will be higher or lower? (h/l)");
                Guess=(Console.ReadLine());
                //newCard=draw card
                Console.WriteLine($"Your new card is {newCard}.");
                if (Guess=="h")
                {
                    if(currentCard<newCard)
                    {
                        score+=100;
                    }
                    else
                    {
                        score+=-75;
                    }
                }
                else
                {
                    if(newCard<currentCard)
                    {
                        score+=100;
                    }
                    else
                    {
                        score+=-75;
                    }
                }
                Console.WriteLine($"Your score: {score}");
                Console.WriteLine("Do you want to play again? (y/n)");
                playAgain=Console.ReadLine();
                if (playAgain=="n")
                {
                    isPlaying=false;
                }
            }
        }

        //gameloop

        //drawCard

    }
}