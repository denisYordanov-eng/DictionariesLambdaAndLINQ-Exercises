using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dict = new Dictionary<string, string>();
            string name = string.Empty;
            
            int counter = 1;
            while(input != "stop")
            {
                if(counter % 2 != 0)
                {
                    name = input;
                }
                else
                {
                   string email = input;
                    if(!email.EndsWith("us") && !email.EndsWith(("uk")))
                    {
                        dict.Add(name, email);
                    }
                }
                counter++;
                input = Console.ReadLine();
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
