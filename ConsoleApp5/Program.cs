﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedListExample();
            // ListExample();

            //RandomGuess();

            //StringReverse();

            Fibonacci(50);

            for (int i = 0; i < 50; i++)
            {
                Console.Write("{0} ", Fibonacci(i));
            }

            // Fibonacci_Iterative(50);

            Console.ReadLine();
        }


        public static void Fibonacci_Iterative(int len)
        {
            System.Int64 a = 0, b = 1, suma = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                suma = a + b;
                Console.Write(" {0}", suma);
                a = b;
                b = suma;
            }
        }

        static int Fibonacci(int x)
        {
            if (x == 1)
                return 1;

            if (x == 0)
                return 0;

            return Fibonacci(x - 1) + Fibonacci(x - 2);
        }

        private static void StringReverse()
        {
            string text = "Mihai";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
        }

        private static void RandomGuess()
        {
            Random rand = new Random();
            int numarRandom = rand.Next(1, 10);

            while (true)
            {
                Console.WriteLine("Introduceti nr:");
                int nr = int.Parse(Console.ReadLine());

                if (numarRandom == nr)
                {
                    Console.WriteLine("Bravo");
                    break;
                }

                if (nr > numarRandom)
                {
                    Console.WriteLine("Prea mare");
                }
                else
                {
                    Console.WriteLine("Prea mic");
                }
            }
        }

        private static void ListExample()
        {
            List<int> list = new List<int>(10000);
            int initial = list.Capacity;

            for (int i = 0; i < 10000; i++)
            {
                list.Add(10);

                if (list.Capacity != initial)
                {
                    Console.WriteLine($"Elements:{list.Count}, Capacity:{list.Capacity}");
                    initial = list.Capacity;
                }
            }


            //int[] arr = new int[] { 30, 40, 50 };

            //list.AddRange(arr);

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            Console.WriteLine(list.Capacity);
        }

        private static void LinkedListExample()
        {
            LinkedList<int> list = new LinkedList<int>();

            LinkedListNode<int> node1 = list.AddFirst(10);

            LinkedListNode<int> node2 = new LinkedListNode<int>(20);

            list.AddAfter(node1, node2);

            list.AddLast(30);

            foreach (int node in list)
            {
                Console.WriteLine(node);
            }

            Console.ReadLine();
        }
    }
}
