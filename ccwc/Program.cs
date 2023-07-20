using System.Text.RegularExpressions;

namespace ccwc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            switch (args[0])
            {
                case "-":
                    DisplayTotalBytesForFile(args[1]);
                    DisplayNumberOfLinesInFile(args[1]);
                    DisplayNumberOfWordsInFile(args[1]);
                    break;
                case "-c":
                    DisplayTotalBytesForFile(args[1]);
                    break;
                case "-l":
                    DisplayNumberOfLinesInFile(args[1]);
                    break;
                case "-w":
                    DisplayNumberOfWordsInFile(args[1]);
                    break;
                case "-m":
                    DisplayNumberOfCharactersInFile(args[1]);
                    break;
            }

        }

        private static void DisplayNumberOfCharactersInFile(string v)
        {
            string content = File.ReadAllText(v);

            int charCount = content.Length;

            Console.WriteLine(charCount);
        }

        private static void DisplayNumberOfWordsInFile(string v)
        {
            // Step 1: Read the content of the file
            string content = File.ReadAllText(v);

            // Step 2: Split the content into words using whitespace as the delimiter
            char[] delimiters = new char[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?', ':', '*' };
            string[] words = content.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            // Step 3: Count the number of words
            int wordCount = words.Length;

            Console.WriteLine(wordCount);
        }

        private static void DisplayNumberOfLinesInFile(string v)
        {
            var numOfLinesInFile = File.ReadAllLines(v).Length;
            Console.WriteLine(numOfLinesInFile);
        }

        private static void DisplayTotalBytesForFile(string v)
        {
            var fileBytes = File.ReadAllBytes(v);
            Console.WriteLine(fileBytes.Length);
        }
    }
}