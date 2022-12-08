using Microsoft.EntityFrameworkCore;

namespace ArtGallery3312.Models
{
    public class PiecesContext : DbContext
    {
        public PiecesContext (DbContextOptions<DbContext> options) : base(options)
        {
        }

        public DbSet<ArtPiece> ArtPieces {get; set;} = default!;
    }
}