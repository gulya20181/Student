// See https://aka.ms/new-console-template for more information
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Write("Введите количество строк ");
            int n = int.Parse(Console.ReadLine());
           
            
                int[][] triangle = new int[n][];
                // первая строка
                triangle[0] = new int[] { 1 };
 
                for (int i = 1; i < triangle.Length; i++)
                {
                    triangle[i] = new int[i + 1];  
                    for (int j = 0; j <= i; j++)
                    {
                        if (j == 0 || j == i)
                            triangle[i][j] = 1;
                        else
                        {
                            triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                        }
                    }
                }
 
                for (int i = 0; i < triangle.Length; i++)
                {
                    for (int j = 0; j < triangle[i].Length; j++)
                    {
                        Console.Write("{0,-3} ", triangle[i][j]);
                    }
                    Console.WriteLine();
                }