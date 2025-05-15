using LambdaExercise.Entities;
using System.Globalization;
using System;

namespace LambdaExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter full file path: ");
            string path = @"C:\temp\in.txt";
            Console.WriteLine("ok!");

            Console.Write("Enter salary for filter: ");
            double salaryFilter = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine($"Email of people whose salary is more than {salaryFilter.ToString("F2", CultureInfo.InvariantCulture)}: ");

            List<Employee> employees = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        string email = line[1];
                        double salary = double.Parse(line[2], CultureInfo.InvariantCulture);

                        employees.Add(new Employee(name, email, salary));
                    }
                }

                var emailFilter = employees.Where(e => e.Salary > salaryFilter).OrderBy(e => e.Name).Select(e => e.Email);
                foreach (var mail in emailFilter)
                {
                    Console.WriteLine(mail);
                }
                Console.WriteLine();

                var sum = employees.Where(e => e.Name.StartsWith('M') || e.Name.StartsWith('m')).Sum(e => e.Salary);
                Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sum.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            catch (IOException e)
            {
                Console.WriteLine("Ops!");
                Console.WriteLine(e.Message);
            }
        }
    }
}