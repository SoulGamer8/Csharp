using System;

namespace Game
{
    class GameController
    {
        private int _triesCount;
        private int _originalNumber;
        

        public GameController(int triesCount)
        {
            _triesCount = triesCount;
            Random rnd = new Random();
            _originalNumber = rnd.Next(0,10);
            Console.WriteLine(_originalNumber);
        }

        public string Controller(int Number)
        {
            int temp = 0;
            while (temp<_originalNumber)
            {
                if (Number == _originalNumber)
                {
                    return "Tou win"; 

                }
                else
                {
                    temp++;
    
                    if (_triesCount == 0)
                    {
                        return "You lose.";

                    }
                }


            }
            return "Guessed wrong \n" + GreaterOrLess(Number);
        }

        public string GreaterOrLess(int number)
        {
            if (number < _originalNumber)
                return "Original number is greater.";

            else
                return "Original number is less smaler";

        }
    

        public string Attempts()
        {
            _triesCount--;
            return Convert.ToString(_triesCount);
        }
    }


}