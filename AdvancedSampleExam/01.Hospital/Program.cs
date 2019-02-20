
namespace _01.Hospital
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<int, List<string>>> departmentRoomPatient = new Dictionary<string, Dictionary<int, List<string>>>();
            Dictionary<string, List<string>> doctorPatient = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] commandLine = Console.ReadLine().Split();
                if (commandLine[0] == "Output")
                {
                    break;
                }

                string department = commandLine[0];
                string doctor = commandLine[1] + " " + commandLine[2];
                string patient = commandLine[3];

                if (!departmentRoomPatient.ContainsKey(department))
                {
                    departmentRoomPatient[department] = new Dictionary<int, List<string>>();
                    for (int i = 1; i <= 20; i++)
                    {
                        departmentRoomPatient[department].Add(i, new List<string>());
                    }
                }

                for (int i = 1; i <= 20; i++)
                {
                    if (departmentRoomPatient[department][i].Count < 3)
                    {
                        departmentRoomPatient[department][i].Add(patient);

                        if (!doctorPatient.ContainsKey(doctor))
                        {
                            doctorPatient[doctor] = new List<string>();
                        }

                        doctorPatient[doctor].Add(patient);
                        break;
                    }
                }
            }

            while (true)
            {
                string[] commandLine = Console.ReadLine().Split();
                if (commandLine[0] == "End")
                {
                    break;
                }

                if (commandLine.Length == 1)
                {
                    string department = commandLine[0];
                    foreach (var room in departmentRoomPatient[department])
                    {
                        foreach (var patient in room.Value)
                        {
                            Console.WriteLine(patient);
                        }
                    }
                }

                else
                {
                    string doctorName = commandLine[0] + " " + commandLine[1];
                    if (doctorPatient.ContainsKey(doctorName))
                    {
                        foreach (var patient in doctorPatient[doctorName].OrderBy(x => x))
                        {
                            Console.WriteLine(patient);
                        }
                    }
                    else
                    {
                        string department = commandLine[0];
                        int room = int.Parse(commandLine[1]);
                        foreach (var patient in departmentRoomPatient[department][room].OrderBy(x => x))
                        {
                            Console.WriteLine(patient);
                        }
                    }
                }
            }
        }
    }
}
