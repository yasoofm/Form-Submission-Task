using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Form_Submission_Task.Models
{
    public class Customer
    {
        
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        [Display(Name = "Date of Birth")]
        [Required]
        public DateTime DateOfBirth { get; set; }
        //[BindProperty(BinderType = typeof(Color))]
        [Display(Name = "Favorite Color")]
        [Required]
        public Color FavoriteColor { get; set; }
    }
}
