using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericListMain
    {
        public static void Main()
        {
            GenericList<int> numbers = new GenericList<int>();
            for (int i = 0; i < 20; i++)
            {
                numbers.Add(i + 1);
            }
            Console.WriteLine(numbers);
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Max());
            Console.WriteLine("Contains 100 -> {0}", numbers.Contains(100));
            Console.WriteLine("Contains 3 -> {0}", numbers.Contains(3));
            Console.WriteLine("Index of 1 is {0}", numbers.FindIndexOf(1));
            numbers.RemoveAt(4);
            Console.WriteLine("Remove value at index 4 -> {0}", numbers);
            numbers.InsertAt(4, 12);
            Console.WriteLine("Insert 4 at index 12 -> {0}", numbers);
            numbers.Clear();
            Console.WriteLine("Empty {0}", numbers);
            numbers.Add(5);
            Console.WriteLine(numbers);
        }
    }
}