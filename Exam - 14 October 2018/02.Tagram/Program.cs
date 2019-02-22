namespace _02.Tagram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, int>> list = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputLine = input.Split(" -> ");
                if (inputLine.Length > 1)
                {
                    string user = inputLine[0];
                    string tag = inputLine[1];
                    int likes = int.Parse(inputLine[2]);

                    if (!list.ContainsKey(user))
                    {
                        list[user] = new Dictionary<string, int>();
                    }

                    if (!list[user].ContainsKey(tag))
                    {
                        list[user][tag] = 0;
                    }

                    list[user][tag] += likes;
                }

                else
                {
                    string[] banInput = input.Split();
                    string userName = banInput[1];

                    if (list.ContainsKey(userName))
                    {
                        list.Remove(userName);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var user in list.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x=> x.Value.Count))
            {
                Console.WriteLine(user.Key);
                foreach (var tag in user.Value)
                {
                    Console.WriteLine($"- {tag.Key}: {tag.Value}");
                }
            }
        }
    }
}
