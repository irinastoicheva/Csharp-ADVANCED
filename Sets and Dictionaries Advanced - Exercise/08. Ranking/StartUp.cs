namespace _08._Ranking
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class StartUp
    {
        public static void Main()
        {
            Dictionary<string, string> contestPassword = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> userContestPoints = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of contests")
                {
                    break;
                }

                string[] line = input.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string contest = line[0];
                string password = line[1];

                if (!contestPassword.ContainsKey(contest))
                {
                    contestPassword[contest] = password;
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of submissions")
                {
                    break;
                }

                string[] line = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = line[0];
                string password = line[1];
                string user = line[2];
                int points = int.Parse(line[3]);

                if (contestPassword.ContainsKey(contest) && contestPassword[contest] == password)
                {
                    if (!userContestPoints.ContainsKey(user))
                    {
                        userContestPoints[user] = new Dictionary<string, int>();
                    }

                    if (!userContestPoints[user].ContainsKey(contest))
                    {
                        userContestPoints[user][contest] = points;
                    }

                    if (userContestPoints[user][contest] < points)
                    {
                        userContestPoints[user][contest] = points;
                    }
                }
            }

            Dictionary<string, int> userPoints = new Dictionary<string, int>();

            foreach (var kvp in userContestPoints)
            {
                foreach (var item in kvp.Value)
                {
                    if (!userPoints.ContainsKey(kvp.Key))
                    {
                        userPoints[kvp.Key] = 0;
                    }

                    userPoints[kvp.Key] += item.Value;
                }
            }


            foreach (var item in userPoints.OrderByDescending(x => x.Value).Take(1))
            {
                Console.WriteLine($"Best candidate is {item.Key} with total {item.Value} points.");
            }

            Console.WriteLine("Ranking:");
            foreach (var kvp in userContestPoints.OrderBy(x => x.Key))
            {
                Console.WriteLine(kvp.Key);

                foreach (var contest in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
