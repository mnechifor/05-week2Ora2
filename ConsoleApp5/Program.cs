using System;
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

            RandomGuess();

            Console.ReadLine();
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
