using System.Collections.Generic;
namespace StudentManagement
{   
    public class SchoolDataManager
    {
        public static SchoolDataManager instance;
        public List<Student> Students { get; private set; }
        public List<Teacher> Teachers { get; private set; }
        public List<Subject> Subjects { get; private set; }

        public SchoolDataManager()
        {
            Students = new List<Student>();
            Teachers = new List<Teacher>();
            Subjects = new List<Subject>();
        }

        // Method to add a student to the list
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        // Method to add a teacher to the list
        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        // Method to add a subject to the list
        public void AddSubject(Subject subject)
        {
            Subjects.Add(subject);
        }
        
        //Adding dummy details
        public void FillDummyData()
        {
            // Adding dummy students
            Students.Add(new Student { Name = "Rahul Gandhi", ClassSection = "8A" });
            Students.Add(new Student { Name = "Vijay Mallya", ClassSection = "8B" });
            Students.Add(new Student { Name = "Lady Gaga", ClassSection = "8A" });
            Students.Add(new Student { Name = "Arun Jaitley", ClassSection = "8C" });
            Students.Add(new Student { Name = "MS Dhoni", ClassSection = "8B" });
            Students.Add(new Student { Name = "Kim Kardashian", ClassSection = "8A" });

            // Adding dummy teachers
            Teachers.Add(new Teacher { Name = "Mr.Algebra", ClassSection = "8A" });
            Teachers.Add(new Teacher { Name = "Mr.Physics", ClassSection = "8B" });
            Teachers.Add(new Teacher { Name = "Mrs.Biology", ClassSection = "8C" });

            // Adding dummy subjects
            Subjects.Add(new Subject { Name = "Algebra", SubjectCode = "ALG01", Teacher = Teachers[0] });
            Subjects.Add(new Subject { Name = "Physics", SubjectCode = "PHY01", Teacher = Teachers[1] });
            Subjects.Add(new Subject { Name = "Biology", SubjectCode = "BIO01", Teacher = Teachers[2] });
        }
    }
}
