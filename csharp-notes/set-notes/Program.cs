using System;
using System.IO;
using set_notes.Entities;

namespace set_notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine(); 

            HashSet<LogRecord> set = new HashSet<LogRecord>();
            
            try
            {
                using (StreamReader sr = File.OpenText(path)) //exemple format: 'amanda 2020-08-26T20:45:08'
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split();                       
                        set.Add(new LogRecord() { Username = line[0], Instant = DateTime.Parse(line[1]) });
                    }
                    Console.WriteLine("Total acess: " + set.Count);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}