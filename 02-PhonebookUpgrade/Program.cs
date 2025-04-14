using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {

            var dict = new SortedDictionary<string, string>();
            string[] input = Console.ReadLine().Split().ToArray();
            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    string name = input[1];
                    string number = input[2];
                    dict[name] = number;
                }
                else if (input[0] == "S")
                {
                    string searchContact = input[1];
                    if (dict.ContainsKey(searchContact))
                    {
                        foreach (var item in dict)
                        {
                            if (item.Key == searchContact)
                            {
                                Console.WriteLine($"{item.Key} -> {item.Value}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Contact {searchContact} does not exist.");
                    }
                }
                if (input[0] == "ListAll")
                {
                    foreach (var item in dict)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
                input = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
