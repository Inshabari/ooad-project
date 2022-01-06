using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace DigitalLibrary.Models
{
    public class signUpModel
    {
        public int ID { get; set; }

        [Required]

        public string name { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        [EmailAddress]
        public string username { get; set; }

        [Required]
        [MinLength(6,ErrorMessage ="Too Short, Minimum Length should be 6 Characters")]
        public string password { get; set; }

        [Required]
        public string confirm_pass { get; set; }

        
        public int isAdmin { get; set; }
    }
}