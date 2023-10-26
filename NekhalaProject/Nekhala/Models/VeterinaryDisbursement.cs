using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Nekhala.Models
{
    public class VeterinaryDisbursement
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? VeterinaryDisbursementID { get; set; }
        [Required]
        public string? FarmOwnerName { get; set; }
        [Required]
        public int? FarmOwnerID { get; set; }
        [Required]
        public string? FarmAddress { get; set; }
        [Required]
        public int HeadsNo { get; set; }
        public int? LicenseNo { get; set; }
        public DateOnly? LicenseExpDate { get; set; }
        public int CommercialRegNo { get; set; }
        public int CommercialCardNo { get; set; }
        [Required]
        public string? InsuranceStatus { get; set; }
        [Required]
        public DateOnly? InsuranceDate { get; set; }

        [Required]
        public string? InspectionStatus { get; set; }
        [Required]
        public DateOnly? InspectionDate { get; set; }
        public bool isApproved { get; set; }

    }
}
