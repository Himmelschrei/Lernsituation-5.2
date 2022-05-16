using System;

namespace IT_LF05_Array_LUHN_Aufg_1_0
{
    class Calculation
    {
        Display myDisplay;

        public Calculation(Display display)
        {
            myDisplay = display;
        }

        public void CheckInput(string str)
        {
            if (str.Length != 16)
            {
                myDisplay.RepeatInput();
            } else {
                InputToArray(str);
            }
        }

        public void DigitCalc(int[] arr)
        {
            // Step 1
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0 | i % 2 == 0)
                {
                    arr[i] *= 2;
                }
            }

            // Step 2
            int temp;
            int step2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0 | i % 2 == 0)
                {
                    if (arr[i] >= 10)
                    {
                        temp = arr[i] % 10;
                        arr[i] /= 10;
                        arr[i] += temp;
                    }
                    step2 += arr[i];
                }
            }

            // Step 3
            int step3 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0 & i != 15)
                {
                    step3 += arr[i];
                }
            }

            // Step 4
            int step4 = step2 + step3;

            // Step 5
            int step5 = step4 + (10 - step4 % 10);

            // Step 6
            int step6 = step5 - step4;

            if (step6 == arr[arr.Length-1])
            {
                myDisplay.ShowDigitTrue(step6);
            } else {
                myDisplay.ShowDigitFalse(step6);
            }
        }

        public void InputToArray(string str)
        {
            char[] chars = str.ToCharArray();

            int[] arr = new int[chars.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                arr[i] = Convert.ToInt32(str[i].ToString());
            }

            DigitCalc(arr);
        }
    }
}