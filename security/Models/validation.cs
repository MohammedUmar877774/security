using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace security.Models
{
    public class validation //https://localhost:44344/valid/Index
    {
          
        [Required]
        public string name { get; set; }
        [Required]
        [Range(18, 50, ErrorMessage = "age must be from 18 to 50 years")]
        public int age { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]

        [ValidEmailDomain(ErrorMessage = "Email domain must be cognizant.com")]
        
        public string email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Compare("password")]
        [DataType(DataType.Password)]
        public string retypepassword { get; set; }
    }
}