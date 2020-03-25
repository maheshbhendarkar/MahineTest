using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Machine_Test.Models
{
    [MetadataType(typeof(StudentMetaData))]
    public partial class Student
    {
        
    }
    public class StudentMetaData
    {
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Maximul Mength 50 minimum 2")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Maximul Mength 50 minimum 2")]
        public string LastName { get; set; }

         [Required]
         [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required]
        [StringLength(10,MinimumLength=10)]
        public string PhoneNumber { get; set; }

    }
}