using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apatments.Models
{
    public class CustomRegi
    {
        public Guid CusId { get; set; }
        [Required]
        public string AcountType { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string AlternateAddress { get; set; }
        [Required]
        public string ContactNumber { get; set; }
        [Required]
        [Key]
        public string NICPassportNo { get; set; }
        [Required]
        public string Email { get; set; }
        public string Dependent1 { get; set; }
        public string Dependent2 { get; set; }
        public string Dependent3 { get; set; }
        public string Dependent4 { get; set; }
        public string OtherDependent { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string Status { get; set; }
        public string ApartmentType { get; set; }
        public string BuildingNo { get; set; }
        public string RoomNo { get; set; }
        public string RefundorNot { get; set; }
        public DateTime? RegisterAt { get; set; }
    }
}
