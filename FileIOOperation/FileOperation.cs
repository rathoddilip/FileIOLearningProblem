using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIOOperation
{
   public class FileOperation
    {
        public static void FileExists()
        {
            string path =@"C:\Users\Dilip Rathod\Desktop\Bridgelab\BatchDotNetFellowship-015\FileIOOperation\FileIOOperation\Files\Demo.txt";
            if(File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
        }
        /// <summary>
        /// ReadAllLines method read lines one by one
        /// </summary>
        public static void ReadAllLineFromFile()
        {
            string path = @"C:\Users\Dilip Rathod\Desktop\Bridgelab\BatchDotNetFellowship-015\FileIOOperation\FileIOOperation\Files\Demo.txt";
            string[] lines = File.ReadAllLines(path);
            foreach (string readLines in lines)
            {
                Console.WriteLine(readLines);
            }
        }
        /// <summary>
        /// Read all line in file at once
        /// </summary>
       public static void ReadAllTextFromFile()
        {
            string path = @"C:\Users\Dilip Rathod\Desktop\Bridgelab\BatchDotNetFellowship-015\FileIOOperation\FileIOOperation\Files\Demo.txt";
            string line = File.ReadAllText(path);
            Console.WriteLine(line);
        }
        public static void CopyExistingFile()
        {
            string sourcePath = @"C:\Users\Dilip Rathod\Desktop\Bridgelab\BatchDotNetFellowship-015\FileIOOperation\FileIOOperation\Files\Demo.txt";
            string destinationPath= @"C:\Users\Dilip Rathod\Desktop\Bridgelab\BatchDotNetFellowship-015\FileIOOperation\FileIOOperation\Files\DemoCopied.txt";
            File.Copy(sourcePath, destinationPath);
            Console.WriteLine("Copied succuessfully");
        }
        public static void DeleteFile()
        {
            string destinationPath = @"C:\Users\Dilip Rathod\Desktop\Bridgelab\BatchDotNetFellowship-015\FileIOOperation\FileIOOperation\Files\DemoCopied.txt";
            File.Delete(destinationPath);
            Console.WriteLine("File deleted successfully");

        }
        public static void ReadFromStreamReader()
        {
            string path = @"C:\Users\Dilip Rathod\Desktop\Bridgelab\BatchDotNetFellowship-015\FileIOOperation\FileIOOperation\Files\Demo.txt";
           
            using (StreamReader streamReader = File.OpenText(path)) 
            {
                string lines = "";
                while ((lines = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(lines);
                }
            }
        }
        public static void WriteToFileUsingStreamWriter()
        {
            string path = @"C:\Users\Dilip Rathod\Desktop\Bridgelab\BatchDotNetFellowship-015\FileIOOperation\FileIOOperation\Files\Demo.txt";
            using (StreamWriter streamWriter=File.AppendText(path))
            {
                streamWriter.Write("\nHello -.net is awesome");
                streamWriter.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }
    }
}
