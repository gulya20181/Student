// See https://aka.ms/new-console-template for more information
//треугольник паскаля
int n =7;
     int[,] a = new int[n, n];
     for (int i = 0; i < n; i++)
     for (int j = 0; j < n; j++)
         a[i, j] = 1+j+i;
         for(int i=0;i<n;i++)
        {
         for (int j = 0; j <=i; j++)
         Console.Write("{0}{1}", a[i, j], "\t");
          Console.WriteLine();
        }
            Console.ReadLine();
