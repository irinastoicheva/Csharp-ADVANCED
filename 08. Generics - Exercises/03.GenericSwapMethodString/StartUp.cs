namespace _03.GenericSwapMethodString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            List<Box<string>> boxes = new List<Box<string>>();

            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine();
                Box<string> box = new Box<string>(input);
                boxes.Add(box);
            }

            int[] inputIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstIndex = inputIndexes[0];
            int secondIndex = inputIndexes[1];
            Box<string>.Swap(boxes, firstIndex, secondIndex);

            foreach (var box in boxes)
            {
                Console.WriteLine(box.ToString());
            }
        }
    }
}
