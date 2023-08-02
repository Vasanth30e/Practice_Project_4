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

            // Display students in a class
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
                }
            }

            Console.ReadKey();
        }
    }

}
