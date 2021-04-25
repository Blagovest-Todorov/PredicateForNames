using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameLength = int.Parse(Console.ReadLine());

            string[] peopleNames = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string[], int, string[]> getNames = (peopleNames, nameLength) => 
            {
                List<string> selected = new List<string>();

                for (int i = 0; i < peopleNames.Length; i++)
                {
                    if (peopleNames[i].Length <= nameLength)
                    {
                        selected.Add(peopleNames[i]);
                    }
                }

                return selected.ToArray();
            };

            string[] selectedPeople = getNames(peopleNames, nameLength);

            Action<string[]> printNames = PrintNames;
            printNames(selectedPeople);
        }

        private static void PrintNames(string[] names)
        {
            Console.WriteLine(string.Join(Environment.NewLine, names));
        }        
    }
}
