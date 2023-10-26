using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Nekhala.Models
{
    public class AgricultureDisbursement
    {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public string? AgriDisbursementID { get; set; }
            [Required]
            public string? BusinessOwnerName { get; set; }
            [Required]
            public int? BusinessOwnerID { get; set; }
            [Required]
            public string? BusinessAddress { get; set; }
            [Required]
            public int? LicenseNo { get; set; }
            [Required]
            public DateOnly? LicenseExpDate { get; set; }
            [Required]
            public int CommercialRegNo { get; set; }
            [Required]
            public int CommercialCardNo { get; set; }
            [Required]
            public float PercentageInProduct { get; set; }
            [Required]
            public string? InspectionStatus { get; set; }
            [Required]
            public DateOnly? InspectionDate { get; set; }
            public bool isApproved { get; set; }
        }
    }