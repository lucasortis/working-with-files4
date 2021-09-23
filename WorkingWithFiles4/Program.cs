using System;
using System.IO;

namespace WorkingWithFiles4
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Lucas Ortis\Downloads\file1.txt";
            string targetPath = @"C:\Users\Lucas Ortis\Downloads\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
                
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred: " + e.Message);
            }
        }
    }
}
