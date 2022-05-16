using System;

namespace IT_LF05_Array_ISBN_Aufg_1_0
{
    class Calculation
    {
        Display myDisplay;

        public Calculation(Display display)
        {
            myDisplay = display;
        }

        public void CalculateDigit(string input)
        {
            int[] arr = SeparateString(input);
            int temp = 0;

            for (int i = 0; i < 9; i++)
            {
                arr[i] = arr[i] * (i + 1);
                temp += arr[i];
            }

            temp %= 11;

            myDisplay.ShowDigit(temp, input);
        }

        public void CheckInput(string input)
        {
            if (input.Length != 9)
            {
                myDisplay.RepeatInput();
            } else {
                CalculateDigit(input);
            }
        }

        public int[] SeparateString(string s)
        {
            int temp = Convert.ToInt32(s);
            int[] arr = new int[9];

            for (int i = 8; i > -1; i--)
            {
                arr[i] = temp % 10;
                temp /= 10;
            }

            return arr;
        }
    }
}