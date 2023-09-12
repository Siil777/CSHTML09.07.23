using System;
using System.ComponentModel.DataAnnotations;

namespace CSHTML09._07._23.Models
{
    public class Student
    {
        [Key]
        public int  ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Navigation property to represent the relationship with Enrollments
        public ICollection<Enrollment> Enrollments { get; }
    }
}
