namespace _11._Key_Revolver
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int priceBullet = int.Parse(Console.ReadLine());
            int sizeBarrel = int.Parse(Console.ReadLine());
            int[] bulletsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> buliets = new Stack<int>(bulletsInput);
            int[] locksInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> locks = new Queue<int>(locksInput);
            int valueIntelligence = int.Parse(Console.ReadLine());

            int counterBullets = 0;
            int counter = 0;
            while (buliets.Count > 0 && locks.Count > 0)
            {
                int currentBullet = buliets.Peek();
                int currentLock = locks.Peek();

                if (currentBullet <= currentLock)
                {
                    buliets.Pop();
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    buliets.Pop();
                    Console.WriteLine("Ping!");
                }

                counterBullets++;
                counter++;
                if (counter == sizeBarrel && buliets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    counter = 0;
                }
            }

            if (buliets.Count == 0 && locks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                int totalPriceBullets = counterBullets * priceBullet;
                Console.WriteLine($"{buliets.Count} bullets left. Earned ${valueIntelligence - totalPriceBullets}");
            }
        }
    }
}
