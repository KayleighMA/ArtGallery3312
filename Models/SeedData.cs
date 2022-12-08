using Microsoft.EntityFrameworkCore;

namespace ArtGallery3312.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PiecesContext(serviceProvider.GetRequiredService<DbContextOptions<PiecesContext>>()))
            {
                if (context == null || context.ArtPieces == null)
                {
                    throw new ArgumentNullException("Null RazorPagesPiecesContext");
                }

                if(context.ArtPieces.Any())
                {
                    return;
                }
                context.ArtPieces.AddRange(
                    new ArtPieces//1
                    {
                        ArtTitle = "Mona Lisa",
                        Year = DateTime.Parse("1503"),
                        ArtStyle = "Renaissance",
                        ArtistName = "Leonardo DaVinci",
                        ArtistBirth = DateOnly.Parse("1452-4-15"),
                        Price = 350
                    },
                    new ArtPieces//2
                    {
                        ArtTitle = "Girl with a Pearl Earring",
                        Year = DateTime.Parse("1665"),
                        ArtStyle = "Tonie",
                        ArtistName = "Johannes Vermeer",
                        ArtistBirth = DateOnly.Parse("1632"),
                        Price = 150
                    },
                    new ArtPieces //3
                    {
                        ArtTitle = "A Sunday Afternoon on the Island of La Grande Jatte",
                        Year = DateTime.Parse("1884"),
                        ArtStyle = "Neo-Impressionsism",
                        ArtistName = "Georges Seurat",
                        ArtistBirth = DateOnly.Parse("1891-12-2"),
                        Price = 200
                    },
                    new ArtPieces //4
                    {
                        ArtTitle = "The Starry Night",
                        Year = DateTime.Parse("1889"),
                        ArtStyle = "Landscape",
                        ArtistName = "Vincent van Gogh",
                        ArtistBirth = DateOnly.Parse("1853-30-3"),
                        Price = 200
                    },
                    new ArtPieces //5
                    {
                        ArtTitle = "The Birth of Venus",
                        Year = DateTime.Parse("1480"),
                        ArtStyle = "Renaissance",
                        ArtistName = "Sandro Botticelli",
                        ArtistBirth = DateOnly.Parse("1445"),
                        Price = 300
                    },
                    new ArtPieces //6
                    {

                    },
                    new ArtPieces //7
                    {
                        
                    },
                    new ArtPieces //8
                    {

                    },
                    new ArtPieces //9
                    {

                    },
                    new ArtPieces //10
                    {

                    },
                    new ArtPieces //11
                    {

                    },
                    new ArtPieces //12
                    {

                    },
                    new ArtPieces //13
                    {

                    },
                    new ArtPieces //14
                    {

                    },
                    new ArtPieces //15
                    {

                    },
                    new ArtPieces //16
                    {

                    },
                    new ArtPieces //17
                    {

                    },
                    new ArtPieces //18
                    {

                    },
                    new ArtPieces //19
                    {

                    },
                    new ArtPieces //20
                    {

                    },
                    new ArtPieces //21
                    {

                    },
                    new ArtPieces //22
                    {

                    },
                    new ArtPieces //23
                    {

                    },
                    new ArtPieces //24
                    {

                    },
                    new ArtPieces //25
                    {

                    }

                );
                context.SaveChanges();

            }

            }
        }
    }