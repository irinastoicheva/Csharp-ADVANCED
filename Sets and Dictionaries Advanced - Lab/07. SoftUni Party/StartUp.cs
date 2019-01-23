namespace _07._SoftUni_Party
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        public static void Main()
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();

            while (true)
            {
                string numberOfGuest = Console.ReadLine();

                if (numberOfGuest == "PARTY")
                {
                    break;
                }

                if (numberOfGuest.Length == 8)
                {
                    if (numberOfGuest[0] == '0' || numberOfGuest[0] == '1' || numberOfGuest[0] == '2'
                        || numberOfGuest[0] == '3' || numberOfGuest[0] == '4' || numberOfGuest[0] == '5'
                        || numberOfGuest[0] == '6' || numberOfGuest[0] == '7' || numberOfGuest[0] == '8' || numberOfGuest[0] == '9')
                    {
                        vipGuests.Add(numberOfGuest);
                    }
                    else
                    {
                        regularGuests.Add(numberOfGuest);
                    }
                }
            }

            while (true)
            {
                string guest = Console.ReadLine();

                if (guest == "END")
                {
                    break;
                }

                vipGuests.Remove(guest);
                regularGuests.Remove(guest);
            }

            Console.WriteLine(vipGuests.Count + regularGuests.Count);
            foreach (var guest in vipGuests)
            {
                Console.WriteLine(guest);
            }

            foreach (var guest in regularGuests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
