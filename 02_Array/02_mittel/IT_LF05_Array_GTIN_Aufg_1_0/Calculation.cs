using System;

namespace IT_LF05_Array_GTIN_Aufg_1_0
{
    class Calculation
    {
        Display myDisplay;

        public Calculation(Display display)
        {
            myDisplay = display;
        }

        public long TestDigit(string input)
        {
            long inputLong = Convert.ToInt64(input);
            long[] arr = new long[12];

            for (long i = 11; i > -1; i--)
            {
                arr[i] = inputLong % 10;
                inputLong /= 10;
            }

            for (long i = 0; i < 12; i++)
            {
                arr[i] *= 3;
                i++;
            }

            long temp = 0;
            for (long i = 0; i < 12; i++)
            {
                temp += arr[i];
            }

            temp %= 10;
            temp = 10 - temp;

            return temp;
        }
    }
}