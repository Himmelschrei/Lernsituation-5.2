using System;

namespace IT_LF05_Array_Wuerfel
{
    class Calculation
    {
        Display myDisplay;

        public Calculation(Display display)
        {
            myDisplay = display;
        }

        public void Die(int rolls)
        {
            Random die = new Random();

            int index;
            int[] add = new int[6];

            for (int i = 0; i < rolls; i++)
            {
                index = die.Next(0, 6);
                add[index] += 1;
            }

            int tempStars = 0, tempRoll = 0;
            for (int i = 0; i < 6; i++)
            {
                if (add[i] > tempStars)
                {
                    tempStars = add[i];
                    tempRoll = i+1;
                }
            }

            for (int i = 0; i < 6; i++)
            {
                Console.Write("{0}: ", i+1);
                while (add[i] > 0)
                {
                    Console.Write("*");
                    add[i]--;
                }
                Console.WriteLine();
            }

            myDisplay.Result(tempStars, tempRoll);
        }
    }
}