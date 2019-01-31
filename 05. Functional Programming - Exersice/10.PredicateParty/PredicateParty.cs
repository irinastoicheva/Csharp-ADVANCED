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

                if (command == "Remove")
                {
                    if (direction == "StartsWith")
                    {
                        names.RemoveAll(x => x.StartsWith(criteria));
                    }
                    else if (direction == "EndsWith")
                    {
                        names.RemoveAll(x => x.EndsWith(criteria));
                    }
                    else if (direction == "Length")
                    {
                        int lenght = int.Parse(criteria);
                        names.RemoveAll(x => x.Length == lenght);
                    }
                }
                else if (command == "Double")
                {
                    List<string> namesForDuplication = new List<string>();

                    if (direction == "StartsWith")
                    {
                        namesForDuplication = names.Where(x => x.StartsWith(criteria)).ToList();
                    }
                    else if (direction == "EndsWith")
                    {
                        namesForDuplication = names.Where(x => x.EndsWith(criteria)).ToList();
                    }
                    else if (direction == "Length")
                    {
                        int lenght = int.Parse(criteria);
                        namesForDuplication = names.Where(x => x.Length == lenght).ToList();
                    }

                    foreach (var item in namesForDuplication)
                    {
                        int index = names.IndexOf(item);
                        names.Insert(index + 1, item);
                    }
                }
            }

            Console.WriteLine(names.Any()? $"{string.Join(", ", names)} are going to the party!" : "Nobody is going to the party!");
        }
    }
}
