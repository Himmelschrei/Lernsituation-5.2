using System;

namespace IT_LF05_Array_Zahlen
{
    class Display
    {
        Calculation myCalculation;

        public Display()
        {
            myCalculation = new Calculation(this);
        }

        public void Input()
        {
            Console.Clear();

            Console.WriteLine("Eingabe von Zahlen");
            Console.WriteLine();

            myCalculation.Array();
        }

        public void Result(double add, double[] myNumbers)
        {
            Console.WriteLine();
            Console.WriteLine("Summe\t: " + add);
            Console.WriteLine();
            Console.WriteLine("Eingegeben wurden: ");
            Console.WriteLine();
            for (int i = 9; i > -1; i--)
            {
                Console.WriteLine("{0}\t(Anteil: {1:F2})", myNumbers[i], myCalculation.Calc(i));
            }
        }
    }
}