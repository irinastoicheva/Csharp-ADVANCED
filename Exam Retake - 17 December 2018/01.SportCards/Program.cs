namespace _01.SportCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, decimal>> cardSportPrice = new Dictionary<string, Dictionary<string, decimal>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "end")
                {
                    break;
                }

                if (input.Length > 1)
                {
                    string card = input[0];
                    string sport = input[1];
                    decimal price = decimal.Parse(input[2]);

                    if (!cardSportPrice.ContainsKey(card))
                    {
                        cardSportPrice[card] = new Dictionary<string, decimal>();
                    }

                    if (!cardSportPrice[card].ContainsKey(sport))
                    {
                        cardSportPrice[card][sport] = 0;
                    }

                    cardSportPrice[card][sport] = price;
                }
                else
                {
                    string[] check = input[0].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string card = check[1];

                    if (cardSportPrice.ContainsKey(card))
                    {
                        Console.WriteLine($"{card} is available!");
                    }
                    else
                    {
                        Console.WriteLine($"{card} is not available!");
                    }
                }
            }

            foreach (var card in cardSportPrice.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{card.Key}:");
                foreach (var sport in card.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"  -{sport.Key} - {sport.Value:F2}");
                }
            }
        }
    }
}
