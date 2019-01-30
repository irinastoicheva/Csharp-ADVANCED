namespace _03.WordCount
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;

    class WordCount
    {
        public static void Main()
        {
            using (StreamReader readerWords = new StreamReader(@"Resources/words.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"actualResults.txt"))
                {
                    List<string> words = new List<string>();

                    while (true)
                    {
                        string word = readerWords.ReadLine();

                        if (word == null)
                        {
                            break;
                        }

                        words.Add(word);
                    }
                    Dictionary<string, int> listOfWords = new Dictionary<string, int>();

                    using (StreamReader readerText = new StreamReader(@"Resources/text.txt"))
                    {
                        while (true)
                        {
                            string line = readerText.ReadLine();

                            if (line == null)
                            {
                                break;
                            }

                            string[] currentWords = line.ToLower().Split(new[] { '.', ',', ':', '-', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                            for (int i = 0; i < currentWords.Length; i++)
                            {
                                if (words.Contains(currentWords[i]))
                                {
                                    if (!listOfWords.ContainsKey(currentWords[i]))
                                    {
                                        listOfWords[currentWords[i]] = 0;
                                    }

                                    listOfWords[currentWords[i]]++;
                                }
                            }
                        }
                    }

                    foreach (var item in listOfWords.OrderByDescending(x => x.Value))
                    {
                        writer.WriteLine($"{item.Key} - {item.Value}");
                    }
                }
            }

            using (StreamReader readerResult = new StreamReader(@"actualResults.txt"))
            {
                using (StreamReader readerExpected = new StreamReader(@"expectedResult.txt"))
                {
                    string textResult = readerResult.ReadToEnd();
                    string textExpected = readerExpected.ReadToEnd();

                    if (textResult == textExpected)
                    {
                        Console.WriteLine("correct");
                    }
                    else
                    {
                        Console.WriteLine("incorrect");
                    }
                }
            }
        }
    }
}
