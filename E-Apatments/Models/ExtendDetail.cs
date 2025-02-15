using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apatments.Models
{
    public class ExtendDetail
    {
        [Key]
        public string NICorPassport { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int NumberofDaysExtend { get; set; }
        [Required]
        public int FreshLeasePrice { get; set; }
        public string ApproveorNot { get; set; }
    }
}
