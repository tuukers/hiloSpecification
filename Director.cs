using System;

namespace hilo
{
    class GameLoop
    {
        // Attributes
        private int score;
        public bool isPlaying;

        public int currentCard;

        private bool First;
        public int Guess;

        // Constructor
        public GameLoop()
        {
            this.score=300;
            this.isPlaying=true;
        }
        
        public void Play()
        {
            First= true;            
            while this.isPlaying
            {
                if First
                {
                    //draw card
                    First=false;
                }
                Guess=
            }
        }

        //gameloop

        //drawCard

    }
}