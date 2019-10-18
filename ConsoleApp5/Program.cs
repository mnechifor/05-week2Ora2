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
