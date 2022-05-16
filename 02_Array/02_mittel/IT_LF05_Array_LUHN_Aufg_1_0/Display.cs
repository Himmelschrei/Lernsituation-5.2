using System;

namespace IT_LF05_Array_LUHN_Aufg_1_0
{
    class Display
    {
        Calculation myCalculation;

        public Display()
        {
            myCalculation = new Calculation(this);
        }

        string myInput;

        public void Input()
        {
            Console.Clear();

            Console.WriteLine("Ermittlung der Prüfziffer einer 16-stelligen Kreditkartennummer");
            Console.WriteLine("===============================================================");
            Console.WriteLine();
            Console.Write("Geben Sie Ihre Kreditkartennummer ein: ");
            myInput = Console.ReadLine();

            myCalculation.CheckInput(myInput);
        }

        public void RepeatInput()
        {
            Console.WriteLine("Bitte geben Sie eine gültige 16-stellige Nummer.");
            Console.WriteLine();
            Console.Write("Geben Sie Ihre Kreditkartennummer ein: ");
            myInput = Console.ReadLine();

            myCalculation.CheckInput(myInput);
        }

        public void ShowDigitFalse(int digit)
        {
            Console.WriteLine();
            Console.WriteLine("Die Prüfziffer lautet {0}.", digit);
            Console.Write("Die Kreditkartennummer {0} ist ungültig", myInput);
        }

        public void ShowDigitTrue(int digit)
        {
            Console.WriteLine();
            Console.WriteLine("Die Prüfziffer lautet {0}.", digit);
            Console.Write("Die Kreditkartennummer {0} ist gültig", myInput);
        }
    }
}