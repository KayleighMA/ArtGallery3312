using ArtGallery3312.Models;

namespace ArtGallery3312.Pages.List2;
{
    public class List2Model : PageModel
    {
        private readonly PiecesContext _context;
        private readonly ILogger<List2Model> _logger;
        public List<ArtPiece> ArtPieces {get; set;} = default!;
        public ArtPiece ArtList2 {get; set;} = default!;

        public List2Model(PiecesContext context, ILogger<List2Model> logger)
        {
            _context = context;
            _logger = logger;
        }
        public void OnGet()
        {
            ArtPieces = _context.ArtPieces.ToList<>();
            ArtList2 = _context.ArtPieces.Skip(10).Take(15);
    }
}
}