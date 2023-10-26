using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Nekhala.Models
{
    public class SupplyDisbursement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? SupplyDisbursementID { get; set; }
        [Required]
        public string? BusinessOwnerName { get; set; }
        [Required]
        public int? BusinessOwnerID { get; set; }
        [Required]
        public string? BusinessAddress { get; set; }
        [Required]
        public int? LicenseNo { get; set; }
        [Required]
        public DateOnly? LicenseExpDate { get; set;}
        [Required]
        public int CommercialRegNo { get; set; }
        [Required]
        public int CommercialCardNo { get; set; }
        [Required]
        public string? InspectionStatus { get; set; }
        [Required]
        public DateOnly? InspectionDate { get;set; }
        public bool isApproved { get; set; }
    }
}
