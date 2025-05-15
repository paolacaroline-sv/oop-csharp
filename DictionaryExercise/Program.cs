using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = @"C:\temp\in.txt";
            Console.WriteLine("Ok!");

            Dictionary<string, int> election = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] vect = sr.ReadLine().Split(',');
                        string candidate = vect[0];
                        int votes = int.Parse(vect[1]);
                        
                        if (!election.ContainsKey(candidate))
                        {
                            election[candidate] = votes;
                        }
                        else
                        {
                            election[candidate] += votes;
                        }

                    }
                    Console.WriteLine("Votes: ");
                    foreach (var item in election)
                    {
                        Console.WriteLine(item.Key + ", " + item.Value);
                    }                
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}