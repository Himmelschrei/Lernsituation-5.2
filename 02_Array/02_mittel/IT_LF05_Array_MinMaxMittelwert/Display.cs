using System;

namespace IT_LF05_Array_MinMaxMittelwert
{
    class Display
    {
        Calculation myCalculation;

        public Display()
        {
            myCalculation = new Calculation(this);
        }

        public void Show()
        {
            Console.Clear();

            Console.WriteLine("Minimum, Maximum, Mittelwert");
            Console.WriteLine();

            myCalculation.RandomGen();
        }

        public void Result()
        {
            Console.WriteLine();
            Console.WriteLine("Das Minimum der Zahlen lautet\t: " + myCalculation.myMin);
            Console.WriteLine("Das Maximum der Zahlen lautet\t: " + myCalculation.myMax);
            Console.WriteLine("Die Summe der Zahlen lautet\t: " + myCalculation.myAdd);
            Console.WriteLine("Der Mittelwert der Zahlen lautet: " + myCalculation.myAve);
        }
    }
}