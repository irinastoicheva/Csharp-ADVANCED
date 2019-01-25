namespace _07._The_V_Logger
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class StartUp
    {
        public static void Main()
        {
            Dictionary<string, HashSet<string>> listOfVloggers = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Statistics")
                {
                    break;
                }

                string[] line = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = line[1];

                switch (command)
                {
                    case "joined":
                        string vloggerName = line[0];
                        if (!listOfVloggers.ContainsKey(vloggerName))
                        {
                            listOfVloggers[vloggerName] = new HashSet<string>();
                        }
                        break;

                    case "followed":
                        string firstVlogger = line[0];
                        string secondVlogger = line[2];
                        if (listOfVloggers.ContainsKey(firstVlogger) && listOfVloggers.ContainsKey(secondVlogger) && firstVlogger != secondVlogger)
                        {
                            listOfVloggers[secondVlogger].Add(firstVlogger);
                        }
                        break;
                }
            }

            Console.WriteLine($"The V-Logger has a total of {listOfVloggers.Keys.Count} vloggers in its logs.");
            Dictionary<string, List<int>> nameNumberOfFollowersAndNumberThatFollows = new Dictionary<string, List<int>>();
            foreach (var kvp in listOfVloggers)
            {
                foreach (var vlogger in kvp.Value)
                {
                    if (!nameNumberOfFollowersAndNumberThatFollows.ContainsKey(kvp.Key))
                    {
                        nameNumberOfFollowersAndNumberThatFollows[kvp.Key] = new List<int>();
                        nameNumberOfFollowersAndNumberThatFollows[kvp.Key].Add(0);
                        nameNumberOfFollowersAndNumberThatFollows[kvp.Key].Add(0);
                    }

                    nameNumberOfFollowersAndNumberThatFollows[kvp.Key][0]++;

                    foreach (var item in listOfVloggers)
                    {
                        if (!nameNumberOfFollowersAndNumberThatFollows.ContainsKey(item.Key))
                        {
                            nameNumberOfFollowersAndNumberThatFollows[item.Key] = new List<int>();
                            nameNumberOfFollowersAndNumberThatFollows[item.Key].Add(0);
                            nameNumberOfFollowersAndNumberThatFollows[item.Key].Add(0);
                        }

                        if (vlogger == item.Key)
                        {
                            nameNumberOfFollowersAndNumberThatFollows[item.Key][1]++;
                        }
                    }
                }
            }

            int counter = 1;
            foreach (var kvp in nameNumberOfFollowersAndNumberThatFollows.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Value[1]))
            {
                Console.WriteLine($"{counter}. {kvp.Key} : {kvp.Value[0]} followers, {kvp.Value[1]} following");
                if (counter == 1)
                {
                    foreach (var vlogger in listOfVloggers)
                    {
                        if (kvp.Key == vlogger.Key)
                        {
                            foreach (var item in vlogger.Value.OrderBy(x => x))
                            {
                                Console.WriteLine($"*  {item}");
                            }
                        }
                    }
                }

                counter++;
            }
        }
    }
}
