using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apatments.Models
{
    public class ApartmentDetai
    {
        [Key]
        public string ApartmentType { get; set; }
        [Required]
        public int RefundableDeposit { get; set; }
        [Required]
        public int FirstMonthRent { get; set; }
        [Required]
        public int ParkingSpaceQuantity { get; set; }
        [Required]
        public DateTime? Updated { get; set; }
    }
}
