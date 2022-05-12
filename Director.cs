using System;

namespace hilo
{
    class Director
    {
        // Attributes
        private int score = 300;
        public bool isPlaying;
        public int currentCard;
        public string guess;
        public bool correct;
        public int newCard;
        public string playAgain;
    
        // Constructor
        public Director()
        {
            this.isPlaying=true;
        }
        
        public void Play()
        {
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