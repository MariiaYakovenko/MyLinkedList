using System;

namespace Homework14
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>(new int[] { 1, 2, 3 });
            Console.WriteLine("Number of elements in the list = "+list.Count);
            Console.WriteLine("Is the list empty?"+list.isEmpty);
            list.AddFirst(0);
            list.AddLast(4);
            Console.WriteLine();
            Console.WriteLine("Is 5 in the list?"+list.Contains(5));
            Console.WriteLine("All the elements of the list from head:");
            foreach (var el in list)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();
            list.Remove(2);
            Console.WriteLine("All the elements of the list from head after removing:");
            foreach (var el in list)
            {
                Console.WriteLine(el); 
            }
            Console.WriteLine();
            Console.WriteLine("All the elements of the list from tail after removing:");
            foreach (var el in list.BackEnumerator())
            {
                Console.WriteLine(el);
            }
            list.Clear();
            Console.WriteLine();
            Console.WriteLine("Number of elements in the list after clearing = "+list.Count);
            
            

        }
    }
}
