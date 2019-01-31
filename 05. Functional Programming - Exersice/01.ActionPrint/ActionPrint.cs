namespace _01.ActionPrint
{
    using System;

    class ActionPrint
    {
       public static void Main()
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string> print = n => Console.WriteLine(n);

            foreach (var item in names)
            {
                print(item);
            }
        }
    }
}
