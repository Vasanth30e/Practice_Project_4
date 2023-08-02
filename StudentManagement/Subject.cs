namespace StudentManagement
{
    //Subject Class
    public class Subject: Student
    {        
        public string SubjectCode { get; set; }
        public Teacher Teacher { get; set; }
    }
}
