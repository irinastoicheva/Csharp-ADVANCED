namespace _01.GenericBoxOfString
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine();
                Box<string> box = new Box<string>(input);
                Console.WriteLine(box.ToString());
            }
        }
    }
}
