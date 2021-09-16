using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testTrain.Model.ViewModels
{
    public class CreateDeliveryManVM
    {

        public string Id { get; set; }

        [Required(ErrorMessage = "Please enter your Name")]
        [Display(Name = "Full Name")]
        public string fullName { get; set; }

        [Required(ErrorMessage = "Please enter your National ID")]
        [Display(Name = "National ID")]
        [MaxLength(14, ErrorMessage = "Please enter a valid National ID"), MinLength(14, ErrorMessage = "Please enter a valid National ID")]
        public string nationalID { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [Display(Name = "Phone Number")]
        [MaxLength(11, ErrorMessage = "Please enter a valid phone number"), MinLength(11, ErrorMessage = "Please enter a valid phone number")]
        
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter your password")]
        [Display(Name = "Password")]
        [MinLength(6, ErrorMessage = "Password must be more than 6 characters")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Please enter your car type")]
        [Display(Name = "Car Type")]
        public string carType { get; set; }
        [Required(ErrorMessage = "Please enter your plate number")]
        [Display(Name = "Plate Number")]
        public string plateNumbers { get; set; }
        [Required(ErrorMessage = "Please enter your plate letter")]
        public string plateLetters { get; set; }
        [Required(ErrorMessage = "Please enter your pick up location")]
        [Display(Name = "Pick up location")]
        public string pickUpLocation { get; set; }
        [Required(ErrorMessage = "Please enter your capacity")]
        [Display(Name = "Capacity")]
        public float capacity { get; set; }
    }
    public enum TypeOfCar
    {
        Car=1, Van=2, Motorcycle=3,Truck=4,Bike=5
    }
}
