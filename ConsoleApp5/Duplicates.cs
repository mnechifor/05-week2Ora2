using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Duplicates
    {
       
            private static void CountUniqueElements(int[] array)
            {
            //1, 6, 2, 7, 1
                int n = 1;
                int[] arraynew = new int[array.Length];

                for (int i = 0, ia = 0; i < array.Length; i++, ia++)
                {
                    int x = array[i];
                    bool found = IfElementExists(arraynew, x);

                    if (found == true)
                    {
                        continue;
                    }

                    arraynew[ia] = array[i];
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (x == array[j] && i != j)
                        {
                            n++;
                        }

                    }

                    Console.WriteLine($"Element {x}: {n}");
                    n = 1;
                }
            }

            private static bool IfElementExists(int[] arraynew, int i)
            {
                bool found = false;
                for (int k = 0; k < arraynew.Length; k++)
                {
                    if (arraynew[k] == i)
                    {
                        found = true;
                        break;
                    }
                }

                return found;
            }

        private static void Var1()
        {
            int[] numbers = { 3, 1, 1, 1, 5, 6, 3, 3, 3 };

            List<int> noDuplicates = numbers.Distinct().ToList();

            foreach (int element in noDuplicates)
            {
                int c = 0;
                for (int i = 0; i<numbers.Length; i++)
                {
                    if (element == numbers[i])
                    {
                        c++;
                    }

                }

                Console.WriteLine($"{element}={c}");
            }

        }
        private static void ex2()
        {
            int[] arr = new int[5] { 8, 3, 3, 10, 8 };

            int[] frecventa = new int[arr.Length];

            for (int x = 0; x < arr.Length; x++)
            {
                frecventa[x] = arr[x];
            }

            int i, j, ctr;


            for (i = 0; i < arr.Length; i++)
            {
                ctr = 1;
                for (j = i + 1; j < frecventa.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        ctr++;
                        frecventa[j] = 0;
                    }
                }

                if (frecventa[i] != 0)
                {
                    frecventa[i] = ctr;
                }
            }

            for (i = 0; i < arr.Length; i++)
            {
                if (frecventa[i] != 0)
                {
                    Console.Write("Frecventa lui {0} este {1} \n", arr[i], frecventa[i]);
                }
            }
        }

        public static void DuplicatesWithDict()
        {
            int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };

            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (var num in array)
            {
                if (!dict.ContainsKey(num))
                {
                    dict.Add(num, 0);
                }
                dict[num]++;
            }

            foreach (KeyValuePair<int, int> kvp in dict)
            {
                Console.WriteLine("{0} repeats {1} times", kvp.Key, kvp.Value);
            }
        }
    }
}
