namespace _07._Truck_Tour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int numberOfPetrolPumps = int.Parse(Console.ReadLine());
            Queue<int> circle = new Queue<int>();

            for (int i = 0; i < numberOfPetrolPumps; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                circle.Enqueue(input[0] - input[1]);
            }

            Queue<int> saveCircle = new Queue<int>(circle);
            int currentPetrol = -1;
            int counter = 0;
            while (circle.Any())
            {
                if (currentPetrol == -1 && circle.Peek() >= 0)
                {
                    currentPetrol = circle.Dequeue();
                    saveCircle.Enqueue(saveCircle.Dequeue());
                }
                else if (currentPetrol == -1 && circle.Peek() < 0)
                {
                    circle.Enqueue(circle.Dequeue());
                    saveCircle.Enqueue(saveCircle.Dequeue());
                }
                else
                {
                    if (currentPetrol + circle.Peek() >= 0)
                    {
                        currentPetrol += circle.Dequeue();
                        saveCircle.Enqueue(saveCircle.Dequeue());
                    }
                    else
                    {
                        saveCircle.Enqueue(saveCircle.Dequeue());
                        currentPetrol = -1;
                        circle.Clear();
                        circle = new Queue<int>(saveCircle);
                    }
                }
                counter++;
            }

            Console.WriteLine(counter - numberOfPetrolPumps);
        }
    }
}
