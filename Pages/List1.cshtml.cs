using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using ArtGallery3312.Models;

namespace ArtGallery3312.Pages.List1;
{
    public class List1Model : PageModel
    {
        private readonly PiecesContext _context;
        private readonly ILogger<List1Model> _logger;
        public List<ArtPiece> ArtPieces {get; set;} = default!;
        public ArtPiece ArtList1 {get; set;} = default!;

        public List1Model(PiecesContext context, ILogger<List1Model> logger)
        {
            _context = context;
            _logger = logger;
        }
        public void OnGet()
        {
            ArtPieces = _context.ArtPieces.ToList<>();
            ArtList1 = _context.ArtPieces.Take(10);
    }
}
}