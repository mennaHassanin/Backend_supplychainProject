using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testTrain.Model
{
    [Index(nameof(delieveryMan.nationalID), IsUnique = true)]
    public class delieveryMan : IdentityUser
    {
        [Required(ErrorMessage = "Please enter your National ID")]
        [Display(Name = "National ID")]
        [MaxLength(14, ErrorMessage = "Please enter a valid National ID"), MinLength(14, ErrorMessage = "Please enter a valid National ID")]
        public string nationalID { get; set; }
        [Required(ErrorMessage = "Please enter your Name")]
        [Display(Name = "Full Name")]
        public string fullName { get; set; }
        [Required(ErrorMessage = "Please enter your car type")]
        [Display(Name = "Car Type")]
        public string carType { get; set; }
        [Required(ErrorMessage = "Please enter your plate number")]
        [Display(Name = "Plate Number")]
        public string plateNumbers { get; set; }
        [Required(ErrorMessage = "Please enter your plate letter")]
        [Display(Name = "Plate letters")]
        public string plateLetters { get; set; }
        [Required(ErrorMessage = "Please enter your pick up location")]
        [Display(Name = "Pick up location")]
        public string pickUpLocation { get; set; }
        [Required(ErrorMessage = "Please enter your capacity")]
        [Display(Name = "Capacity")]
        public float capacity { get; set; }


    }
}
