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
            array = CheckShip(array, 4);
            array = CheckShip(array, 4);
            array = CheckShip(array, 3);
            array = CheckShip(array, 3);
            array = CheckShip(array, 3);
            array = CheckShip(array, 2);
            array = CheckShip(array, 2);
            array = CheckShip(array, 2);
            array = CheckShip(array, 2);

            return array;
        }

        public string[,] CheckShip(string[,] array, int length)
        {
            Random random = new Random();
            int x = random.Next(1, 21);
            int y = random.Next(1, 21);

            if (array[y,x] == "X")
            {
                CheckShip(array, length);
            }

            array[y, x] = "X";
            Console.WriteLine("Start position is x = {0}, y = {1}", x, y);

            // 0 = Nord, 1 = Ost, 2 = Süd, 3 = West
            int[] orientations = new int[] {0, 1, 2, 3};
            int o = random.Next(0, 4);
            Console.WriteLine("{0}", o);

            orientations = Move(orientations, o);
            for (int i = 0; i < orientations.Length; i++)
            {
                Console.Write("{0} ", orientations[i]);
            }
            Console.WriteLine();

            bool b = false;
            for (int i = 0; i < orientations.Length - 1; i++)
            {
                Console.WriteLine("Iteration number: {0}", i+1);
                if (Placement(array, orientations[i], length, x, y))
                {
                    b = true;
                    break;
                }
            }

            if (b == false)
            {
                CheckShip(array, length);
            } 

            return array;
        }

        public void DrawField()
        {
            string[,] array = FillField();

            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    Console.Write("|" + array[x, y]);
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
                array[i, 0] = "#";
                array[i, array.GetLength(1) - 1] = "#";
            }

            for (int i = 0; i < array.GetLength(1); i++)
            {
                array[0, i] = "#";
                array[array.GetLength(0) - 1, i] = "#";
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
            for (int x = 1; x < array.GetLength(0) - 1; x++)
            {
                for (int y = 1; y < array.GetLength(1) - 1; y++)
                {
                    array[y,x] = " ";
                }
            }

            return array;
        }

        public int[] Move(int[] arr, int x)
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
            Console.WriteLine("Orientation Value: {0}", orientation);
            string[,] backup = (string[,]) array.Clone();

            bool b = false; 

            switch(orientation)
            {
                case 0: 
                    /**for (int i = 1; i < length; i++)
                    {
                        if(array[x,y-i] == " " & y-i >= 0)
                        {
                            array[x,y-i] = "X";
                            b = true;
                        } else {
                            b = false;
                            array = backup;
                            break;
                        }
                    }*/
                    Console.WriteLine("North");
                    for (int i = 1; i < length; i++)
                    {
                        if (array[y-i,x] != " ")
                        {
                            b = false;
                            Array.Copy(backup, 0, array, 0, array.Length);
                            break;
                        } else {
                            array[y-i,x] = "X";
                            b = true;
                        }
                    }
                    break;
                case 1:
                    Console.WriteLine("East");
                    for (int i = 1; i < length; i++)
                    {
                        if (array[y,x+i] != " ")
                        {
                            b = false;
                            Array.Copy(backup, 0, array, 0, array.Length);
                            break;
                        } else {
                            array[y,x+i] = "X";
                            b = true;
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("South");
                    for (int i = 1; i < length; i++)
                    {
                        if (array[y+i,x] != " ")
                        {
                            b = false;
                            Array.Copy(backup, 0, array, 0, array.Length);
                            break;
                        } else {
                            array[y+i,x] = "X";
                            b = true;
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("West");
                    for (int i = 1; i < length; i++)
                    {
                        if (array[y,x-i] != " ")
                        {
                            b =false;
                            Array.Copy(backup, 0, array, 0, array.Length);
                            break;
                        } else {
                            array[y,x-i] = "X";
                            b = true;
                        }
                    }
                    break;
                /**case 1:
                    for (int i = 1; i < length; i++)
                    {
                        if (array[x+i,y] == " " & x+i <= 21)
                        {
                            array[x+i,y] = "X";
                            b = true;
                        } else {
                            b = false;
                            array = backup;
                            break;
                        }
                    }
                    break;
                case 2:
                    for (int i = 1; i < length; i++)
                    {
                        if (array[x,y+i] == " " & y+i <= 21)
                        {
                            array[x,y+i] = "X";
                            b = true;
                        } else {
                            b = false;
                            array = backup;
                            break;
                        }
                    }
                    break;
                case 3:
                    for (int i = 1; i < length; i++)
                    {
                        if (array[x-i,y] == " " & x-i >= 0)
                        {
                            array[x-i,y] = "X";
                            b = true;
                        } else {
                            b = false;
                            array = backup;
                            break;
                        }
                    }
                    break; */
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
