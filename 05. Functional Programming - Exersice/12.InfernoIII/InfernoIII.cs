namespace _12.InfernoIII
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class InfernoIII
    {
        public static void Main()
        {
            List<int> sequence = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<string> exclude = new List<string>();
            string filterTypeAndParameter = string.Empty;

            while (true)
            {
                string[] commandLine = Console.ReadLine().Split(";");
                string command = commandLine[0];

                if (command == "Forge")
                {
                    break;
                }

                filterTypeAndParameter = commandLine[1] + ":" + commandLine[2];

                switch (command)
                {
                    case "Exclude":
                        exclude.Add(filterTypeAndParameter);
                        break;
                    case "Reverse":
                        if (exclude.Contains(filterTypeAndParameter))
                        {
                            exclude.Reverse();
                            exclude.Remove(filterTypeAndParameter);
                            exclude.Reverse();
                        }
                        break;
                }
            }

            while (exclude.Count > 0)
            {
                string[] filterAndParameter = exclude[0].Split(":");
                string filterType = filterAndParameter[0];
                int parameter = int.Parse(filterAndParameter[1]);

                switch (filterType)
                {
                    case "Sum Left":
                        sequence = Sum(sequence, parameter, -1);
                        break;
                    case "Sum Right":
                        sequence = Sum(sequence, parameter, +1);
                        break;
                    case "Sum Left Right":
                        sequence = Sum(sequence, parameter);
                        break;
                }

                exclude.RemoveAt(0);
            }

            Console.WriteLine(string.Join(" ", sequence));
        }

        private static List<int> Sum(List<int> sequence, int parameter)
        {
            int sum = 0;
            for (int i = 0; i < sequence.Count; i++)
            {
                if (!sequence.Any())
                {
                    break;
                }
                else if (i == 0)
                {
                    sum = sequence[0];
                    if (i + 1 < sequence.Count)
                    {
                        sum += sequence[i + 1];
                    }
                }
                else if (i == sequence.Count - 1)
                {
                    sum = sequence[i] + sequence[i - 1];
                }
                else
                {
                    sum = sequence[i - 1] + sequence[i] + sequence[i + 1];
                }

                if (sum == parameter)
                {
                    sequence.RemoveAt(i);
                    i--;
                }
            }

            return sequence;
        }

        private static List<int> Sum(List<int> sequence, int parameter, int v)
        {
            int sum = 0;
            for (int i = 0; i < sequence.Count; i++)
            {
                if (i + v > sequence.Count - 1 || i + v <= 0)
                {
                    sum = sequence[i];
                }
                else
                {
                    sum = sequence[i] + sequence[i + v];
                }

                if (sum == parameter)
                {
                    sequence.RemoveAt(i);
                    i--;
                }
            }

            return sequence;
        }
    }
}
