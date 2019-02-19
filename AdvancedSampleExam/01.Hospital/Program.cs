using System;
using System.Collections.Generic;

namespace _01.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string[][]> departments = new Dictionary<string, string[][]>();
            Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "Output")
            {
                string[] token = input.Split();
                string department = token[0];
                string doctor = token[1] + " " + token[2];
                string patient = token[3];

                if (!departments.ContainsKey(department))
                {
                    departments[department] = new string[20][];
                    departments[department][0] = new string[3];
                }

                for (int room = 0; room < 20; room++)
                {

                }
            }
        }
    }
}
