namespace CSHTML09._07._23.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {

        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Navigation properties to represent the relationships with Student and Course
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
