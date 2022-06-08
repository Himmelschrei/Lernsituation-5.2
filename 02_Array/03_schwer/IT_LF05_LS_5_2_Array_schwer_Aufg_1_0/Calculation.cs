using System;

namespace IT_LF05_LS_5_2_Array_schwer_Aufg_1_0
{
    class Calculation
    {
        Display myDisplay;

        public Calculation(Display display)
        {
            myDisplay = display;
        }

        public string[,] BuildShips(string[,] array)
        {
            array = CheckShip(array, 5);
            array[x, y] = "x";

            return array;
        }

        public string[,] CheckShip(string[,] array, int length)
        {
            Random random = new Random();
            int x = random.Next(1, 21);
            int y = random.Next(1, 21);

            array[x, y] = "x";

            // 0 = Nord, 1 = Ost, 2 = Süd, 3 = West
            string[] orientations = new string[] {0, 1, 2, 3};
            int o = random.Next(0, 4);

            orientations = Move(orientations, o);

            bool b = false;
            for (int i = 0; i < orientations.Length - 1; i++)
            {
                if (Placement(array, i, length, x, y))
                {
                    b = true;
                    break;
                }
            }

            if (b == false)
            {
                CheckShip(array, length);
            } else {
                return array;
            }
        }

        public void DrawField()
        {
            string[,] array = FillField();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("|" + array[i, j]);
                }
                Console.WriteLine("|");
            }
        }

        public string[,] CreateSquare()
        {
            string[,] array = new string[22, 22];

            //0 Zeilen
            //1 Columns

            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[0, i] = "#";
                array[array.GetLength(0) - 1, i] = "#";
            }

            for (int i = 0; i < array.GetLength(1); i++)
            {                
                array[i, 0] = "#";
                array[i, array.GetLength(1) - 1] = "#";
            }

            return array;
        }

        public string[,] FillField()
        {
            string[,] array = CreateSquare();
            array = FillWater(array);
            array = BuildShips(array);
            return array;
        }

        public string[,] FillWater(string[,] array)
        {
            for (int i = 1; i < array.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < array.GetLength(1) - 1; j++)
                {
                    array[i,j] = " ";
                }
            }

            return array;
        }

        public void Move(int[] arr, int x)
        {
            int temp;

            for(int i = 0; i < x; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }

            return arr;
        }

        public bool Placement(string[,] array, int orientation, int length, int x, int y)
        {
            string[,] backup = array;
            bool b = false; 

            switch(orientation)
            {
                case 0: 
                    for (int i = 1; i < length - 1; i++)
                    {
                        if(array[x,y-i] == " " & y-i >= 0)
                        {
                            array[x,y-i] = "X";
                            b = true;
                        } else {
                            b = false;
                            break;
                        }
                    }
                    break;
                case 1:
                    for (int i = 0; i < length - 1; i++)
                    {

                    }
            }

            return b;
        }

        public void WriteColor(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }
    }
}
