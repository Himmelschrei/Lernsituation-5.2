using System;

namespace IT_LF05_Array_ISBN_Aufg_1_0
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

            Console.WriteLine("ISBN: Internationale Standard Buch Nummer");
            Console.WriteLine();
            Console.Write("Eingabe der 9-stelligen ISBN: ");
            string input = Console.ReadLine();

            myCalculation.CheckInput(input);
        }

        public void RepeatInput()
        {
            Console.WriteLine("Du kannst nicht richtig zählen! Versuche es noch einaml.");
            Console.WriteLine();
            Console.Write("Eingabe der 9-stelligen ISBN: ");
            string input = Console.ReadLine();

            myCalculation.CheckInput(input);
        }

        public void ShowDigit(int i, string input)
        {
            Console.WriteLine();
            Console.WriteLine("Die Prüfziffer lautet:\t\t" + i);
            Console.Write("Die vollständige ISBN lautet:\t" + input);
            if (i == 10)
            {
                Console.Write("X");
            } else {
                Console.Write(i);
            }
        }
    }
}