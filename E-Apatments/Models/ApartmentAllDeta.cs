using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace E_Apatments.Models
{
    public class ApartmentAllDeta
    {
        [Key]
        public string Location { get; set; }
        [Required]
        public int MultiStoriedBuildingQuantity { get; set; }
        [Required]
        public string BuildingNameStarted { get; set; }
        [Required]
        public int Class1ApartmentsQuantity { get; set; }
        [Required]
        public int Class2ApartmentsQuantity { get; set; }
        [Required]
        public int Class3ApartmentsQuantity { get; set; }
        [Required]
        public int StateApartmentsQuantity { get; set; }
        [Required]
        public int ParkingSpaceQuantity { get; set; }
        [Required]
        public string ParkingSpaceNameStarted { get; set; }
        [Required]
        public DateTime? AddedAt { get; set; }
    }
}
