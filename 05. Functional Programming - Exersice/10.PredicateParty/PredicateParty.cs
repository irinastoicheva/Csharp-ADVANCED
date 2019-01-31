namespace _10.PredicateParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PredicateParty
    {
        public static void Main()
        {
            List<string> names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            Func<string, string, bool> predicete;

            while (true)
            {
                string commandLine = Console.ReadLine();

                if (commandLine == "Party!")
                {
                    break;
                }

                string[] line = commandLine.Split();
                string command = line[0];
                string direction = line[1];
                string criteria = line[2];

                predicete = GetFunc(direction);

                if (command == "Remove")
                {
                    names.RemoveAll(x => predicete(x, criteria));
                }
                else if (command == "Double")
                {
                    List<string> namesForDuplication = new List<string>();

                    namesForDuplication = names.Where(x => predicete(x, criteria)).ToList();

                    foreach (var item in namesForDuplication)
                    {
                        int index = names.IndexOf(item);
                        names.Insert(index + 1, item);
                    }
                }
            }

            Console.WriteLine(names.Any()? $"{string.Join(", ", names)} are going to the party!" : "Nobody is going to the party!");
        }

        public static Func<string, string, bool> GetFunc(string direction)
        {
            if (direction == "StartsWith")
            {
                return(x,y) => x.StartsWith(y);
            }
            else if (direction == "EndsWith")
            {
                return (x,y) => x.EndsWith(y);
            }
            else if (direction == "Length")
            {
                return (x,y) => x.Length == int.Parse(y);
            }
            else
            {
                return null;
            }
        }
    }
}
