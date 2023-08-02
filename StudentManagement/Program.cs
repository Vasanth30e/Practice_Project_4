using System;
namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolDataManager schoolDataManager = new SchoolDataManager();

            // Fill up the lists with dummy data
            schoolDataManager.FillDummyData();

            //Adding new student to the list
            Student student1 = new Student()
            {
                Name = "Arun",
                ClassSection = "8A",
            };
            schoolDataManager.Students.Add(student1);

            // Display students in a class 8A
            Console.WriteLine("Students in Class 8A:");
            foreach (var student in schoolDataManager.Students)
            {
                if (student.ClassSection == "8A")
                {
                    Console.WriteLine(student.Name);
                }
            }

            // Display subjects taught by a teacher
            Console.WriteLine("\nSubjects taught by Mr.Algebra:");
            foreach (var subject in schoolDataManager.Subjects)
            {
                if (subject.Teacher.Name == "Mr.Algebra")
                {
                    Console.WriteLine($"{subject.Name} (Code: {subject.SubjectCode})");
                    Console.WriteLine("------------------------------");
                }
            }

            // Display students in a class 8B
            Console.WriteLine("Students in Class 8B:");
            foreach (var student in schoolDataManager.Students)
            {
                if (student.ClassSection == "8B")
                {
                    Console.WriteLine(student.Name);
                }
            }

            // Display subjects taught by a teacher
            Console.WriteLine("\nSubjects taught by Mr.Physics:");
            foreach (var subject in schoolDataManager.Subjects)
            {
                if (subject.Teacher.Name == "Mr.Physics")
                {
                    Console.WriteLine($"{subject.Name} (Code: {subject.SubjectCode})");
                    Console.WriteLine("------------------------------");
                }
            }

            // Display students in a class 8C
            Console.WriteLine("Students in Class 8C:");
            foreach (var student in schoolDataManager.Students)
            {
                if (student.ClassSection == "8C")
                {
                    Console.WriteLine(student.Name);
                }
            }

            // Display subjects taught by a teacher
            Console.WriteLine("\nSubjects taught by Mrs.Biology:");
            foreach (var subject in schoolDataManager.Subjects)
            {
                if (subject.Teacher.Name == "Mrs.Biology")
                {
                    Console.WriteLine($"{subject.Name} (Code: {subject.SubjectCode})");
                    Console.WriteLine("------------------------------");
                }
            }

            Console.ReadKey();
        }
    }

}
