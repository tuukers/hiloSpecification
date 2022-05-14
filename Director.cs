using System;

namespace hilo
{
    class Director
    {
        // Attributes
<<<<<<< HEAD
        private int score = 300;
        public bool isPlaying;
        public int currentCard;
        public string guess;
        public bool correct;
=======
        private int score;
        private bool isPlaying;
        public int currentCard;
        public string Guess;
>>>>>>> origin
        public int newCard;
        public string playAgain;
    
        // Constructor
        public Director()
        {

        }
        
        public void Play()
        {
<<<<<<< HEAD
            Deck deck = new Deck();
            currentCard = deck.cardValue;
            
            while (isPlaying) {
                DrawNewCard(deck);
                DisplayCurrentCard();
                GetGuess();
                CheckGuess();
                UpdateScore();
                DisplayNextCard();
                DisplayScore();
                UpdateCurrentCard();
                PlayAgain();
            }
        }

        public void DrawNewCard(Deck deck) {
            newCard = deck.DrawCard();
        }

        public void DisplayCurrentCard() {
            Console.WriteLine();
            Console.WriteLine($"The card is: {currentCard}");
        }

        public void GetGuess() {
            bool validGuess = false;

            while (validGuess == false) {
                Console.Write("Higher or lower? [h/l] ");
                string input = Console.ReadLine();

                if (input == "h" || input == "l") {
                    guess = input;
                    validGuess = true;
                } else {
                    Console.WriteLine("Invalid guess.");
=======
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
>>>>>>> origin
                }
            }
        }

        public void CheckGuess() {
            bool higher;
            if (newCard > currentCard) {
                higher = true;
            } else {
                higher = false;
            }

            bool guessToBool;
            if (guess == "h"){
                guessToBool = true;
            } else {
                guessToBool = false;
            }

            if (guessToBool == higher) {
                correct = true;
            } else {
                correct = false;
            }
        }

        public void UpdateScore() {
            if (correct) {
                score += 100;
            } else {
                score -= 75;
            }
        }

        public void DisplayNextCard() {
            Console.WriteLine($"Next card was: {newCard}");
        }

        public void DisplayScore() {
            Console.WriteLine($"Your score is: {score}");
        }

        public void UpdateCurrentCard() {
            currentCard = newCard;
        }

        public void PlayAgain() {
            if (score <= 0) {
                Console.WriteLine("You lose.");
                isPlaying = false;
                return;
            }

            Console.Write("Play again? [y/n] ");
            playAgain = Console.ReadLine();

            if (playAgain == "n") {
                isPlaying = false;
            } else {
                return;
            }
        }
    }
}