using System;

namespace hilo
{
    class GameLoop
    {
        // Attributes
        private int score;
        private bool isPlaying;
        public int currentCard;
        public string Guess;
        public int newCard;
        private string playAgain;

        // Constructor
        public GameLoop()
        {

        }
        
        public void Play()
        {
            isPlaying=true;

            Deck Deck= new Deck();

            while (isPlaying)
            {
                currentCard= Deck.DrawCard();
                
                Console.WriteLine($"Your card is {currentCard}.");
                Console.WriteLine("Do you think the next card will be higher or lower? (h/l)");
                Guess=(Console.ReadLine());
                newCard= Deck.DrawCard();
                Console.WriteLine($"Your new card is {newCard}.");

                score=Deck.Score(Guess,currentCard,newCard);
                
                Console.WriteLine($"Your score: {score}");

                if (score<=0)
                {
                    Console.WriteLine("Game Over");
                    isPlaying=false;
                }
                else
                {
                    Console.WriteLine("Do you want to play again? (y/n)");
                    playAgain=Console.ReadLine();
                    if (playAgain=="n")
                    {
                        isPlaying=false;
                    }
                    Console.WriteLine("");
                }
            }
        }

        //gameloop

        //drawCard

    }
}