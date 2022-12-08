using System;
using System.ComponentModel.DataAnnotations;

namespace ArtGallery3312.Models
{
    public class Customer
    {
        public int CustomerID {get; set;}

        [StringLength (50, MinimumLength = 10)]
        [Required]
        public string CustomerAddress {get; set;} = string.Empty;

        [DataType(DataType.PhoneNumber)]
        public int CustomerCell {get; set;}

        public int PurchaseID {get; set;}
    }
}