using System;

namespace IT_LF05_Array_Wuerfel
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

            Console.WriteLine("Absolute Häufigkeit der Zahlen 1 bis 6 eines Würfels");
            Console.WriteLine();
            Console.Write("Wie häufig soll gewürfelt werden? ");
            int rolls = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Die folgende Grafik zeigt, wie häufig eine Zahl gewürfelt wurde.");
            Console.WriteLine();
            myCalculation.Die(rolls);
        }

        public void Result(int stars, int roll)
        {
            Console.WriteLine();
            Console.WriteLine("Die am meisten gewürfelte Zahl ist die {0} mit {1} Würfen.", roll, stars);
        }
    }
}