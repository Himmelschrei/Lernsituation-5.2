using System;

namespace IT_LF05_LS_5_2_Array_schwer_Aufg_1_0
{
    class Display
    {
        Calculation myCalculation;

        public Display()
        {
            myCalculation = new Calculation(this);
        }

        public void Game()
        {
            Console.Clear();

            myCalculation.WriteColor(ConsoleColor.Red, "==== Schiffe versenken ====");
            Console.WriteLine();

            myCalculation.DrawField();
        }
    }
}