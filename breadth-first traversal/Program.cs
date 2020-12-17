using System;
using System.Collections;
using System.Collections.Generic;

namespace breadth_first_traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int l = 0; l < 1000000; l++)
            {
                
                Random rnd = new Random();
                int k = 0, t = 0, flag = 0;
                //int n = int.Parse(Console.ReadLine());
                int n = 20;
                Dictionary<int, int> numbersChek = new Dictionary<int, int>(n);
                int[,] a = new int[n, n];
                int[,] b = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                        a[i, j] = rnd.Next(0, 2);
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                        b[i, j] = a[i, j];
                }
                for (int i = 0; i < n * n; i++)
                    numbersChek.Add(i, -1);
                numbersChek[0] = 0;
                for (int i = 0; i < n * n; i++)
                {
                    for (int q = 0; q < n * n; q++)
                    {
                        if (numbersChek[q] == k)

                        {
                            t = q;
                            if (t / n - 1 > -1 && a[t / n - 1, t - t / n * n] == 1)
                            {
                                a[t / n - 1, t - t / n * n] = 0;
                                numbersChek[t - n] = k + 1;
                            }
                            if (t / n + 1 < n && a[t / n + 1, t - t / n * n] == 1)
                            {
                                a[t / n + 1, t - t / n * n] = 0;
                                numbersChek[t + n] = k + 1;
                            }
                            if ((t - t / n * n + 1) < n && a[t / n, t - t / n * n + 1] == 1)
                            {
                                a[t / n, t - t / n * n + 1] = 0;
                                numbersChek[t + 1] = k + 1;
                            }
                            if ((t - t / n * n - 1) > -1 && a[t / n, t - t / n * n - 1] == 1)
                            {
                                a[t / n, t - t / n * n - 1] = 0;
                                numbersChek[t - 1] = k + 1;
                            }
                        }

                    }
                    k += 1;

                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                        a[i, j] = 0;
                }
                t = numbersChek[n * n - 1] - 1;
                if (t > 0)
                {
                    l = 1000000;
                    k = n * n - 1;
                    while (t > 0)
                    {
                        for (int i = 0; i < n * n - 1; i++)
                        {
                            if (numbersChek[i] == t && (i == k - 1 || i == k + 1 || i == k + n || i == k - n) && flag == 0)
                            {
                                a[i / n, i - i / n * n] = 1;
                                k = i;
                                flag = 1;
                            }
                        }
                        flag = 0;
                        t--;
                    }
                    a[n - 1, n - 1] = 1;
                    a[0, 0] = 1;
                    b[0, 0] = 1;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (a[i, j] == 1 && a[i, j] == b[i, j])
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(a[i, j] + " ");
                                Console.ResetColor();
                            }
                            else
                               Console.Write(b[i, j] + " ");

                        }
                        Console.WriteLine();
                    }
                }
                  
                
            }
            
        }
            
    }
}
