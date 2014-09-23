/*
 Трябва да се намери най-дългата подредица отляво надясно като подредица 
 в случая не се възприема последователност от поредни числа, 
 а като последователност от по-малък към по-голям индекс : 
 (примерно a[0], a[2], a[4] се счита за подредица)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LongestNon_DecreasingSub
{
    class LongestNonDecreasingSub
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();

            //split the string by white-space
            string[] strArray = str.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

            // convert string[] array to List<int> of integer
            List<int> intArray = strArray.Select(Int32.Parse).ToList();

            // compare indexes
            int smallestMember = intArray.Min();

            int counter = 0;
            List<int> numSequence = new List<int>();
            Dictionary<string, int> allNonDecreasing = new Dictionary<string,int>();

            for (int i = 0; i < intArray.Count - 1; i++)
            {
                for (int j = i + 1; j < intArray.Count; j++)
                {
                    if (intArray[i] <= intArray[j])
                    {
                        if (counter == 0)
                        {
                            numSequence.Add(intArray[i]);
                        }
                        numSequence.Add(intArray[j]);
                        counter++;
                    }
                }
                // convert List to single string
                StringBuilder builder = new StringBuilder();
                foreach(int item in numSequence)
                {
                    builder.Append(item).Append(" ");
                }
                string result = builder.ToString();
                
                // add to dictonary
                allNonDecreasing.Add(result, numSequence.Count());

                // !!!!! check the dictionary if it's true  and exist !!!!!!

                counter = 0;
                numSequence.Clear();
            }

            // check for longest value in dictionary
            // print it
            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }
        }

    }
}
