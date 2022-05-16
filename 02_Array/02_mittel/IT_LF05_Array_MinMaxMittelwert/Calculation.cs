using System;

namespace IT_LF05_Array_MinMaxMittelwert
{
    class Calculation
    {
        Display myDisplay;

        public Calculation(Display display)
        {
            myDisplay = display;
        }
        
        public int myAdd { get; private set; }
        public int myAve { get; private set; }
        public int myMax { get; private set; }
        public int myMin { get; private set; }

        public void RandomGen()
        {
            myMin = 300;
            myMax = 0;

            Random randomNumber = new Random();
            int[] number = new int[30];

            for (int i = 0; i < 30; i++)
            {
                number[i] = randomNumber.Next(0,300);
                Console.WriteLine("Die {0}. Zahl lautet: {1}", i+1, number[i]);
                
                if (number[i] > myMax)
                {
                    myMax = number[i];
                } else if (number[i] < myMin) {
                    myMin = number[i];
                }

                myAdd += number[i];
            }

            myAve = myAdd / 30;

            myDisplay.Result();
        }
    }
}