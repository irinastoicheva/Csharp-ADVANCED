namespace _11.ThePartyReservationFilterModule
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ThePartyReservationFilterModule
    {
        private static int strin;

        public static void Main()
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            HashSet<string> addFilter = new HashSet<string>();
            HashSet<string> removeFilter = new HashSet<string>();

            while (true)
            {
                string[] commandLine = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

                string command = commandLine[0];

                if (command == "Print")
                {
                    break;
                }

                string filterTypeAndParameter = commandLine[1] + " " + commandLine[2];

                switch (command)
                {
                    case "Add filter":
                        addFilter.Add(filterTypeAndParameter);
                        break;
                    case "Remove filter":
                        removeFilter.Add(filterTypeAndParameter);
                        break;
                }

                foreach (var item in removeFilter)
                {
                    addFilter.Remove(item);
                }
            }

            Func<string, string, bool> predicate;

            foreach (var filter in addFilter)
            {
                string[] filterTypeAndParameter = filter.Split(" ");

                string typeFilter;
                string parameter = filterTypeAndParameter[1];


                if (filterTypeAndParameter.Length == 3)
                {
                    typeFilter = filterTypeAndParameter[0] + " " + filterTypeAndParameter[1];
                    parameter = filterTypeAndParameter[2];
                }
                else
                {
                    typeFilter = filterTypeAndParameter[0];
                    parameter = filterTypeAndParameter[1];
                }

                predicate = GetFunc(typeFilter);
                names.RemoveAll(x => predicate(x, parameter));
            }

            Console.WriteLine(string.Join(" ", names));
        }

        public static Func<string, string, bool> GetFunc(string typeFilter)
        {
            switch (typeFilter)
            {
                case "Starts with":
                    return (x, y) => x.StartsWith(y);
                case "Ends with":
                    return (x, y) => x.EndsWith(y);
                case "Contains":
                    return (x, y) => x.Contains(y);
                case "Length":
                    return (x, y) => x.Length == int.Parse(y);
            }
            return null;
        }
    }
}
