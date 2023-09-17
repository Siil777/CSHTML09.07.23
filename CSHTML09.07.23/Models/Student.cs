using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace CSHTML09._07._23.Models
{
    public class Student
    {
        [Key]
        public int  ID { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        //The DisplayFormat attribute is used to explicitly specify the date format
        //The ApplyFormatInEditMode setting specifies that the formatting should also be
        //applied when the value is displayed in a text box for editing
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime EnrollmentDate { get; set; }

        // Navigation property to represent the relationship with Enrollments
        public ICollection<Enrollment> Enrollments { get; }
    }
}


////the following code requires the first character to be upper case and the remaining characters to be alphabetical
///[RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]