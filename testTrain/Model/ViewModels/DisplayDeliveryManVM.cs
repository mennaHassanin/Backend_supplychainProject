using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testTrain.Model.ViewModels
{
    public class DisplayDeliveryManVM
    {
        public String Id { get; set; }
        public string PhoneNumber { get; set; }
        public string nationalID { get; set; }
        public string fullName { get; set; }
        public string carType { get; set; }
        public string plateNumbers { get; set; }
        public string plateLetters { get; set; }
        public string pickUpLocation { get; set; }
        public float capacity { get; set; }

    }
}
