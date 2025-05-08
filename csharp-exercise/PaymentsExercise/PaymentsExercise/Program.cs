using System.Collections.Generic;
using System.Globalization;
using PaymentsExercise.Entities;

namespace PaymentsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> listEmployees = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Emplyee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char yesOrNo = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (yesOrNo == 'y' || yesOrNo == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double addCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                    
                    listEmployees.Add(new OutsourcedEmployee(name, hours, valuePerHour, addCharge));
                }
                else
                {
                    listEmployees.Add(new Employee(name, hours, valuePerHour));
                }

            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee emp in listEmployees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}