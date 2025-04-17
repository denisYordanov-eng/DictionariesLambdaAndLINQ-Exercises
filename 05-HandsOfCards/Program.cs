using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {

            var namesCards = new Dictionary<string, List<int>>();
            var line = Console.ReadLine();

            while (line != "JOKER")
            {
                var tokens = line.Split(':');

                var name = tokens[0];

                var cards = tokens[1]
                    .Split(new char[] { ',', ' ' }
                    , StringSplitOptions.RemoveEmptyEntries)
                    .Select(CalculateCardValue).ToArray();

                if (!namesCards.ContainsKey(name))
                {
                    namesCards[name] = new List<int>();
                }
                namesCards[name].AddRange(cards);

                line = Console.ReadLine();
            }

            foreach (var nameCard in namesCards)
            {
                var name = nameCard.Key;
                var card = nameCard.Value;

                var totalCardSum = card.Distinct().Sum();

                Console.WriteLine($"{name}: {totalCardSum}");
            }
        }

         static int CalculateCardValue(string card)
        {
            var cardPowers = new Dictionary<string, int>();
            cardPowers["J"] = 11;
            cardPowers["Q"] = 12;
            cardPowers["K"] = 13;
            cardPowers["A"] = 14;

            for (int i = 2; i <= 10; i++)
            {
                cardPowers[i.ToString()] = i;
            }

            var cardTypes = new Dictionary<string, int>();
            cardTypes["S"] = 4;
            cardTypes["H"] = 3;
            cardTypes["D"] = 2;
            cardTypes["C"] = 1;

            var power = card.Substring(0, card.Length - 1);
            var type = card.Substring(card.Length - 1);

            int value = cardPowers[power] * cardTypes[type];

            return value;
        }
    }
}
