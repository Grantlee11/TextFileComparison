using System;
using System.IO;

namespace Comparison
{
    class TextFileComparison
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string path1 = @"C:\Users\Grant\Desktop\TestFolder\Old.txt";
            string path2 = @"C:\Users\Grant\Desktop\TestFolder\New.txt";
            string path3 = @"C:\Users\Grant\Desktop\TestFolder\Difference.txt";

            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] oldLines = System.IO.File.ReadAllLines(path1);
            string[] newLines = System.IO.File.ReadAllLines(path2);

            using (StreamWriter file = File.CreateText(path3))
            {
                System.Console.WriteLine("Comparing Files...");
                for (int i = 0; i <= oldLines.Length; i++)
                {
                    for (int j = i + counter; j < newLines.Length; j++)
                    {
                        if (i >= oldLines.Length)
                        {
                            if (j < newLines.Length)
                            {
                                file.WriteLine(newLines[j]);
                                continue;
                            }
                            break;
                        }
                        if (oldLines[i] == newLines[j])
                        {
                            break;
                        }
                        else
                        {
                            file.WriteLine(newLines[j]);
                            counter++;
                        }
                    }
                }
            }
            // Keep the console window open in debug mode.
            Console.WriteLine("File Comparison Complete. Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
