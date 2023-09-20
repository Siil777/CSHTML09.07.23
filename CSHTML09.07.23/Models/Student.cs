using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace CSHTML09._07._23.Models
{
    public class Student
    {
        [Key]
        public int  ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        //The Required attribute makes the name properties required fields
        [Required]
        [StringLength(50)]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        //The DisplayFormat attribute is used to explicitly specify the date format
        //The ApplyFormatInEditMode setting specifies that the formatting should also be
        //applied when the value is displayed in a text box for editing
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        // Navigation property to represent the relationship with Enrollments
        public ICollection<Enrollment> Enrollments { get; }
    }
}


////the following code requires the first character to be upper case and the remaining characters to be alphabetical
///[RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]