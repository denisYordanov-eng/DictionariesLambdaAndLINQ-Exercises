using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _01_Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();
            string[] input = Console.ReadLine().Split().ToArray();
            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    string name = input[1];
                    string number = input[2];
                    dict.Add(name, number);
                }
                else if (input[0] == "S")
                {
                    string searchContact = input[1];
                    if (dict.ContainsKey(searchContact))
                    {
                        foreach (var item in dict)
                        {
                          if(item.Key == searchContact)
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
                input = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
