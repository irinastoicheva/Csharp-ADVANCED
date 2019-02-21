namespace _02.RobotCommunication
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "Report")
            {
                string pattern = @"[,_][a-zA-Z]+[0-9]";

                MatchCollection matches = Regex.Matches(input, pattern);
                string[] result = new string [matches.Count];
                StringBuilder sb = new StringBuilder();
                int counter = 0;
                foreach (Match item in matches)
                {
                    string message = item.ToString();
                    if (message[0] == ',')
                    {
                        int num = int.Parse(message[message.Length - 1].ToString());
                        for (int i = 1; i < message.Length - 1; i++)
                        {
                            int current = (int)(message[i]);
                            char letter = (char)(current + num);
                            sb.Append(letter);
                        }
                    }
                    else
                    {
                        int num = int.Parse(message[message.Length - 1].ToString());
                        for (int i = 1; i < message.Length - 1; i++)
                        {
                            int current = (int)(message[i]);
                            char letter = (char)(current - num);
                            sb.Append(letter);
                        }
                    }
                    result[counter] = sb.ToString();
                    sb.Clear();
                    counter++;
                }

                Console.WriteLine(string.Join(" ", result));
                input = Console.ReadLine();
            }
        }
    }
}
