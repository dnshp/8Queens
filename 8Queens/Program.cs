using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Queens
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            var numbers1 = new List<int>();
            var numbers2 = new List<int>();
            var numbers3 = new List<int>();
            var numbers4 = new List<int>();
            var numbers5 = new List<int>();
            var numbers6 = new List<int>();
            var numbers7 = new List<int>();
            var coordinates = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int a = 0; a <= 7; a++)
            {
                numbers1.Clear();
                foreach (int item in numbers)
                {
                    numbers1.Add(item);
                }
                int aint = numbers1[a];
                numbers1.RemoveAt(a);
                for (int b = 0; b <= 6; b++)
                {
                    numbers2.Clear();
                    foreach (int item in numbers1)
                    {
                        numbers2.Add(item);
                    }
                    int bint = numbers2[b];
                    numbers2.RemoveAt(b);
                    for (int c = 0; c <= 5; c++)
                    {
                        numbers3.Clear();
                        foreach (int item in numbers2)
                        {
                            numbers3.Add(item);
                        }
                        int cint = numbers3[c];
                        numbers3.RemoveAt(c);
                        for (int d = 0; d <= 4; d++)
                        {
                            numbers4.Clear();
                            foreach (int item in numbers3)
                            {
                                numbers4.Add(item);
                            }
                            int dint = numbers4[d];
                            numbers4.RemoveAt(d);
                            for (int e = 0; e <= 3; e++)
                            {
                                numbers5.Clear();
                                foreach (int item in numbers4)
                                {
                                    numbers5.Add(item);
                                }
                                int eint = numbers5[e];
                                numbers5.RemoveAt(e);
                                for (int f = 0; f <= 2; f++)
                                {
                                    numbers6.Clear();
                                    foreach (int item in numbers5)
                                    {
                                        numbers6.Add(item);
                                    }
                                    int fint = numbers6[f];
                                    numbers6.RemoveAt(f);
                                    for (int g = 0; g <= 1; g++)
                                    {
                                        numbers7.Clear();
                                        foreach (int item in numbers6)
                                        {
                                            numbers7.Add(item);
                                        }
                                        int gint = numbers7[g];
                                        numbers7.RemoveAt(g);
                                        int hint = numbers7[0];
                                        coordinates.Clear();
                                        coordinates.Add(aint);
                                        coordinates.Add(bint);
                                        coordinates.Add(cint);
                                        coordinates.Add(dint);
                                        coordinates.Add(eint);
                                        coordinates.Add(fint);
                                        coordinates.Add(gint);
                                        coordinates.Add(hint);
                                        int[] coordinatesArray = coordinates.ToArray();
                                        bool solution = true;
                                        for (int pos1 = 0; pos1 < 8; pos1++)
                                        {
                                            for (int pos2 = pos1 + 1; pos2 < 8; pos2++)
                                            {
                                                if (CheckDiagonal(coordinatesArray, pos1, pos2) == false)
                                                {
                                                    solution = false;
                                                }
                                            }
                                        }
                                        if (solution == true)
                                        {
                                            count++;
                                            foreach (int number in coordinates)
                                            {
                                                Console.Write(number);
                                            }
                                            Console.WriteLine();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }

        static bool CheckDiagonal(int[] array, int piece1, int piece2)
        {
            if ((piece1 - array[piece1]) == (piece2 - array[piece2]))
            {
                return false;
            }
            else if ((piece1 + array[piece1]) == (piece2 + array[piece2]))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
