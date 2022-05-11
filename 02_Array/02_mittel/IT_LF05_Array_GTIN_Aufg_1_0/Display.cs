using System;

namespace IT_LF05_Array_GTIN_Aufg_1_0
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

            Console.WriteLine("Global Trade Item Number (GTIN)");
            Console.WriteLine("bis 2009: European Article Number (EAN)");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Berechnung der Prüfziffer");
            Console.WriteLine();
            Console.Write("Geben Sie die 12-stellige Artikelnummer ein : ");
            string input = Console.ReadLine();
            Console.Write("Die Prüfziffer lautet\t\t: {0}", myCalculation.TestDigit(input));
        }
    }
}