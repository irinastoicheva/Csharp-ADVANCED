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
                            exclude.Remove(filterTypeAndParameter);
                        }
                        break;
                }
            }

            exclude.Reverse();

            foreach (var filter in exclude)
            {
                string[] filterAndParameter = filter.Split(":");
                string filterType = filterAndParameter[0];
                int parameter = int.Parse(filterAndParameter[1]);

                sequence = Exclude(sequence, parameter, filterType);
            }

            Console.WriteLine(string.Join(" ", sequence));
        }

        private static List<int> Exclude(List<int> sequence, int parameter, string filterType)
        {
            Func<string, string, bool> funcContains = (x, y) => x.Contains(y);

            for (int i = 0; i < sequence.Count; i++)
            {
                int leftNumber = (i == 0) ? 0 : sequence[i - 1];
                int rightNumbes = (i == sequence.Count - 1) ? 0 : sequence[i + 1];
                int sum = sequence[i];

                if (funcContains(filterType, "Left"))
                {
                    sum += leftNumber;
                }

                if (funcContains(filterType,"Right"))
                {
                    sum += rightNumbes;
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
