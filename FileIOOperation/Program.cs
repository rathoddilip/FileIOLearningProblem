using System;

namespace FileIOOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to file operation");
            Console.WriteLine("Check file exists or not:");
            FileOperation.FileExists();
            Console.WriteLine("Read All line from file one by one:");
            FileOperation.ReadAllLineFromFile();
            Console.WriteLine("Read all the in file at once:");
            FileOperation.ReadAllTextFromFile();
           // FileOperation.CopyExistingFile();
            //FileOperation.DeleteFile();
            FileOperation.ReadFromStreamReader();
            FileOperation.WriteToFileUsingStreamWriter();
            Console.ReadKey();
        }
    }
}
