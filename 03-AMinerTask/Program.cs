using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            var dict = new Dictionary<string, long>();
            int counter = 1;
            string resource = string.Empty;
            long quantity = 0L;
            while (input[0] != "stop")
            {

                if (counter % 2 == 0)
                {
                    quantity = long.Parse(input[0]);
                    if (dict.ContainsKey(resource))
                    {
                        dict[resource] += quantity;
                    }
                    else
                    {
                    dict[resource] = quantity;
                    }
                    
                }
                else if(counter % 2 != 0)
                { 
                     resource = input[0];
                }
                counter++;
                input = Console.ReadLine().Split(' ').ToArray();
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
