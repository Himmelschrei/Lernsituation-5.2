using System;

namespace IT_LF05_Array_Zahlen
{
    class Calculation
    {
        Display myDisplay;

        public Calculation(Display display)
        {
            myDisplay = display;
        }

        double[] myNumbers = new double[10];
        double myAdd = 0;

        public void Array()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Wert {0}\t: ", i + 1);
                myNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Addition();
        }

        public void Addition()
        {
            for (int i = 0; i < 10; i++)
            {
                myAdd += myNumbers[i];
            }

            myDisplay.Result(myAdd, myNumbers);
        }

        public double Calc(int i)
        {
            double d = myNumbers[i] * 100 / myAdd;
            return d;
        }
    }
}