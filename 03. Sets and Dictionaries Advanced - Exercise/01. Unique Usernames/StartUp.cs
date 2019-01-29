namespace _01._Unique_Usernames
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            HashSet<string> listOfNames = new HashSet<string>();

            for (int i = 0; i < number; i++)
            {
                listOfNames.Add(Console.ReadLine());
            }

            foreach (var name in listOfNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
