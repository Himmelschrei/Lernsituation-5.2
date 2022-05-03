using System;

namespace _01_IT_LF05_Array_Zimmervermietung_Aufg_1_0
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] saisonpreise = new double[4] {59.50, 69.50, 79.50, 64.50};
            double aufenthaltsdauer = 7;
            double mwstSatz = 7;
            double mwst;
            double anzahlPersonen = 2;
            double gesamtpreis;
            double nettopreis;
            int saison;
            int i;

            Console.WriteLine("Berechnen eines Angebots abhängig vom Saisonpreis");

            //Ausgabe der Saisonpreise
            for (i = 0; i < 4; i++)
            {
                Console.Write("Saisonpreis {0}: {1:F2} Euro", (i + 1), saisonpreise[i]);
            }

            //Eingabe der betrachteten Saison
            Console.Write("Eingabe der Saison(1-4) : ");
            saison = Convert.ToInt32(Console.ReadLine());

            //Berechnen
            nettopreis = saisonpreise[saison - 1] * aufenthaltsdauer * anzahlPersonen;
            mwst = nettopreis * mwstSatz / 100;
            gesamtpreis = nettopreis + mwst;

            //Aufgabe
            Console.WriteLine("Der Gesamtpreis beträgt : {0:F2} Euro", gesamtpreis);
            Console.ReadKey();
        }
    }
}