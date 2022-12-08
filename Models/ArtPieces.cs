using System;
using System.ComponentModel.DataAnnotations;

namespace ArtGallery3312.Models
{
    public class ArtPiece
    {
        public int ArtPieceID {get; set;}

        [StringLength(50, MinimumLength = 2)]
        [Required]
        public string ArtTitle {get; set;} = string.Empty;

        [Display(Name ="Year Created")]
        [DataType(DataType.Date)]
        public DateTime Year {get; set;}

        [StringLength(10, MinimumLength = 3)]
        [Required]
        public string ArtStyle {get; set;} = string.Empty;

        [StringLength(50, MinimumLength = 4)]
        [Required]
        public string ArtistName {get; set;} = string.Empty;

        [Display(Name = "Artist Birthday")]
        [DataType(DataType.Date)]
        public DateTime ArtistBirth {get; set;}

        [Range(1,500)]
        [DataType(DataType.Currency)]
        [Required]
        public int Price {get; set;}

        public int PurchaseID {get; set;}

    }
    public class PurchaseArt
    {
        public int ArtPieceID {get; set;}
        public int CustomerID {get; set;}
        public int PurchaseID {get; set;}
        public Customer Customer {get; set;} = default!;
        public Purchase Purchase {get; set;} = default!;
        public List<ArtPiece>? ArtPieces {get; set;} = default!;

    }
}