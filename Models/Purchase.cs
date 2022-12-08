using System;
using System.ComponentModel.DataAnnotations;

namespace ArtGallery3312.Models
{
    public class Purchase
    {
        public int PurchaseID {get; set;}

        public int CustomerID {get; set;}

        [Range(1,5000)]
        [DataType(DataType.Currency)]
        [Required]
        public decimal TotalAmount {get; set;}

        [StringLength(5)]
        [Required]
        public string PaymentMethod {get; set;} = string.Empty;
    }
}