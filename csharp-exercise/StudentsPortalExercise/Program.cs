using System;
using System.Collections.Generic;
using StudentsPortalExercise.Entities;

namespace StudentsPortalExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> studentsA = new HashSet<Student>();
            HashSet<Student> studentsB = new HashSet<Student>();
            HashSet<Student> studentsC = new HashSet<Student>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("Student ID: ");
                studentsA.Add(new Student() { ID = int.Parse(Console.ReadLine()) });
            }

            Console.Write("How many students for course B? ");
             n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Student ID: ");
                studentsB.Add(new Student() { ID = int.Parse(Console.ReadLine()) });
            }

            Console.Write("How many students for course C? ");
             n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Student ID: ");
                studentsC.Add(new Student() { ID = int.Parse(Console.ReadLine()) });
            }

            HashSet<Student> allStudent = new HashSet<Student>(studentsA);
            allStudent.UnionWith(studentsB);
            allStudent.UnionWith(studentsC);
            Console.WriteLine("Total students: " + allStudent.Count);
        }
    }
}