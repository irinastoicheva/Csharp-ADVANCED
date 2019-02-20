namespace _08.PetClinic
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class StartUp
    {
        public static void Main()
        {
            List<Pet> pets = new List<Pet>();
            Dictionary<string, Dictionary<int, string>> clinicRoomPet = new Dictionary<string, Dictionary<int, string>>();

            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] commandLine = Console.ReadLine().Split();
                string command = commandLine[0];

                switch (command)
                {
                    case "Create":
                        string createType = commandLine[1];
                        string name = commandLine[2];
                        if (createType == "Pet")
                        {
                            int age = int.Parse(commandLine[3]);
                            string kind = commandLine[4];
                            Pet pet = new Pet(name, age, kind);
                            pets.Add(pet);
                        }
                        else if (createType == "Clinic")
                        {
                            int rooms = int.Parse(commandLine[3]);
                            if (rooms % 2 == 0)
                            {
                                Console.WriteLine("Invalid Operation!");
                            }
                            else
                            {
                                Clinic clinic = new Clinic(name, rooms);
                                if (!clinicRoomPet.ContainsKey(name))
                                {
                                    clinicRoomPet[name] = new Dictionary<int, string>();
                                    for (int j = 1; j <= rooms; j++)
                                    {
                                        clinicRoomPet[name][j] = null;
                                    }
                                }
                            }
                        }
                        break;

                    case "HasEmptyRooms":
                        string clinicName = commandLine[1];
                        if (clinicRoomPet[clinicName].Any(x => x.Value == null))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;

                    case "Release":
                        string nameClinic = commandLine[1];
                        int numberOfRooms = clinicRoomPet[nameClinic].Count;
                        int middle = numberOfRooms / 2 + 1;
                        bool isFound = false;

                        for (int j = middle; j <= numberOfRooms; j++)
                        {
                            if (clinicRoomPet[nameClinic][j] != null)
                            {
                                clinicRoomPet[nameClinic][j] = null;
                                isFound = true;
                                break;
                            }
                        }

                        if (!isFound)
                        {
                            for (int j = 1; j < middle; j++)
                            {
                                if (clinicRoomPet[nameClinic][j] != null)
                                {
                                    clinicRoomPet[nameClinic][j] = null;
                                    isFound = true;
                                    break;
                                }
                            }
                        }

                        Console.WriteLine(isFound);
                        break;

                    case "Add":
                        string petName = commandLine[1];
                        string clinicNames = commandLine[2];
                        bool isAdd = false;

                        if (clinicRoomPet.ContainsKey(clinicNames) && pets.Any(x => x.Name.CompareTo(petName) == 0))
                        {
                            int numerOfRooms = clinicRoomPet[clinicNames].Count;
                            middle = numerOfRooms / 2 + 1;

                            if (clinicRoomPet[clinicNames][middle] == null)
                            {
                                clinicRoomPet[clinicNames][middle] = petName;
                                isAdd = true;
                            }

                            if (!isAdd)
                            {
                                for (int j = 1; j < middle; j++)
                                {
                                    if (clinicRoomPet[clinicNames][middle - j] == null)
                                    {
                                        clinicRoomPet[clinicNames][middle - j] = petName;
                                        isAdd = true;
                                        break;
                                    }

                                    if (clinicRoomPet[clinicNames][middle + 1] == null)
                                    {
                                        clinicRoomPet[clinicNames][middle + 1] = petName;
                                        isAdd = true;
                                        break;
                                    }
                                }
                            }
                        }

                        Console.WriteLine(isAdd);
                        break;

                    case "Print":
                        clinicName = commandLine[1];

                        if (commandLine.Length == 3)
                        {
                            int numberRoom = int.Parse(commandLine[2]);
                            petName = clinicRoomPet[clinicName][numberRoom];
                            Pet pet = pets.FirstOrDefault(x => x.Name.CompareTo(petName) == 0);
                            Console.WriteLine($"{pet.Name} {pet.Age} {pet.Kind}");
                        }
                        else
                        {
                            foreach (var kvp in clinicRoomPet)
                            {
                                foreach (var item in kvp.Value.OrderBy(x => x.Key))
                                {
                                    if (item.Value == null)
                                    {
                                        Console.WriteLine("Room empty");
                                    }
                                    else
                                    {
                                        petName = item.Value;
                                        Pet pet = pets.FirstOrDefault(x => x.Name.CompareTo(petName) == 0);
                                        Console.WriteLine($"{pet.Name} {pet.Age} {pet.Kind}");
                                    }
                                }
                            }
                        }
                        break;
                }
            }
        }
    }
}
