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
                    new ArtPiece//1
                    {
                        ArtTitle = "Mona Lisa",
                        Year = DateTime.Parse("1503"),
                        ArtStyle = "Renaissance",
                        ArtistName = "Leonardo DaVinci",
                        ArtistBirth = DateTime.Parse("1452-4-15"),
                        Price = 350
                    },
                    new ArtPiece//2
                    {
                        ArtTitle = "Girl with a Pearl Earring",
                        Year = DateTime.Parse("1665"),
                        ArtStyle = "Tonie",
                        ArtistName = "Johannes Vermeer",
                        ArtistBirth = DateTime.Parse("1632"),
                        Price = 150
                    },
                    new ArtPiece //3
                    {
                        ArtTitle = "A Sunday Afternoon on the Island of La Grande Jatte",
                        Year = DateTime.Parse("1884"),
                        ArtStyle = "Neo-Impressionsism",
                        ArtistName = "Georges Seurat",
                        ArtistBirth = DateTime.Parse("1891-12-2"),
                        Price = 200
                    },
                    new ArtPiece //4
                    {
                        ArtTitle = "The Starry Night",
                        Year = DateTime.Parse("1889"),
                        ArtStyle = "Landscape",
                        ArtistName = "Vincent van Gogh",
                        ArtistBirth = DateTime.Parse("1853-30-3"),
                        Price = 200
                    },
                    new ArtPiece //5
                    {
                        ArtTitle = "The Birth of Venus",
                        Year = DateTime.Parse("1480"),
                        ArtStyle = "Renaissance",
                        ArtistName = "Sandro Botticelli",
                        ArtistBirth = DateTime.Parse("1445"),
                        Price = 300
                    },
                    new ArtPiece //6
                    {
                        ArtTitle = "American Gothic",
                        Year = DateTime.Parse("1930"),
                        ArtStyle = "Modernism",
                        ArtistName =  "Grant Wood",
                        ArtistBirth = DateTime.Parse("1891-2-13"),
                        Price = 200
                    },
                    new ArtPiece //7
                    {
                        ArtTitle = "The Kiss",
                        Year = DateTime.Parse("1908"),
                        ArtStyle = "Abstract",
                        ArtistName = "Gustav Klimt",
                        ArtistBirth = DateTime.Parse("1862-7-14"),
                        Price = 150
                    },
                    new ArtPiece //8
                    {
                        ArtTitle = "Guernica",
                        Year = DateTime.Parse("1937"),
                        ArtStyle = "Historical",
                        ArtistName = "Pablo Picasso",
                        ArtistBirth = DateTime.Parse("1881-10-25"),
                        Price = 200
                    },
                    new ArtPiece //9
                    {
                        ArtTitle = "Bal du moulin de la Galette",
                        Year = DateTime.Parse("1876"),
                        ArtStyle = "Historical",
                        ArtistName = "Pierre-Auguste Renoir",
                        ArtistBirth = DateTime.Parse("1841-7-11"),
                        Price = 200
                    },
                    new ArtPiece //10
                    {
                        ArtTitle= "Whistler's Mother",
                        Year = DateTime.Parse("1871"),
                        ArtStyle = "Portrait",
                        ArtistName = "James Abbott McNeill Whistler",
                        ArtistBirth = DateTime.Parse("1834-7-11"),
                        Price = 200
                    },
                    new ArtPiece //11
                    {
                        ArtTitle = "Impression, Sunrise",
                        Year = DateTime.Parse("1872"),
                        ArtStyle = "Landscape",
                        ArtistName = "Claude Monet",
                        ArtistBirth = DateTime.Parse("1840-11-14"),
                        Price = 150
                    },
                    new ArtPiece //12
                    {
                        ArtTitle = "Arnolfini Portrait",
                        Year = DateTime.Parse ("1434"),
                        ArtStyle = "Renaissance",
                        ArtistName = "Jan van Eyck",
                        ArtistBirth = DateTime.Parse("1390"),
                        Price = 400
                    },
                    new ArtPiece //13
                    {
                        ArtTitle = "Wanderer above the Sea of Fog",
                        Year = DateTime.Parse("1818"),
                        ArtStyle = "Romanticism",
                        ArtistName = "Caspar David Friendrich",
                        ArtistBirth = DateTime.Parse("1774-9-5"),
                        Price = 200
                    },
                    new ArtPiece //14
                    {
                        ArtTitle = "Cafe Terrace at Night",
                        Year = DateTime.Parse("1888"),
                        ArtStyle = "Post-Impressionism",
                        ArtistName = "Vincent van Gogh",
                        ArtistBirth = DateTime.Parse("1853-3-30"),
                        Price = 250
                    },
                    new ArtPiece //15
                    {
                        ArtTitle = "The Last Supper",
                        Year = DateTime.Parse("1495"),
                        ArtStyle = "Renaissance",
                        ArtistName = "Leonardo da Vinci",
                        ArtistBirth = DateTime.Parse("1452-4-15"),
                        Price = 500
                    },
                    new ArtPiece //16
                    {
                        ArtTitle = "Las Meninas",
                        Year = DateTime.Parse("1656"),
                        ArtStyle = "Historical Portrait",
                        ArtistName = "Diego Velazquez",
                        ArtistBirth = DateTime.Parse("1599-6-6"),
                        Price = 350
                    },
                    new ArtPiece //17
                    {
                        ArtTitle = "The Persistence of Memory",
                        Year = DateTime.Parse("1931"),
                        ArtStyle = "Allegorical",
                        ArtistName = "Salvador Dali",
                        ArtistBirth = DateTime.Parse("1904/5/11"),
                        Price = 200
                    },
                    new ArtPiece //18
                    {
                        ArtTitle = "The Garden of Earhly Desires",
                        Year = DateTime.Parse("1490"),
                        ArtStyle = "Renaissance",
                        ArtistName = "Hieroenymus Bosch",
                        ArtistBirth = DateTime.Parse("1450"),
                        Price = 500
                    },
                    new ArtPiece //19
                    {
                        ArtTitle = "Nighthawks",
                        Year = DateTime.Parse("1942"),
                        ArtStyle = "Post-Impressionism",
                        ArtistName = "Edward Hopper",
                        ArtistBirth = DateTime.Parse("1882-7-22"),
                        Price = 350

                    },
                    new ArtPiece //20
                    {
                        ArtTitle = "The Night Watch",
                        Year = DateTime.Parse("1642"),
                        ArtStyle = "Historical Portrait",
                        ArtistName = "Rembrandt",
                        ArtistBirth = DateTime.Parse("1606-7-15"),
                        Price = 550
                    },
                    new ArtPiece //21
                    {
                        ArtTitle = "Liberty Leading the People",
                        Year = DateTime.Parse("1830"),
                        ArtStyle = "Historical",
                        ArtistName = "Eugene Delacroix",
                        ArtistBirth = DateTime.Parse("1798-4-26"),
                        Price = 450
                    },
                    new ArtPiece //22
                    {
                        ArtTitle = "Les Demoiselles d'Avignon",
                        Year = DateTime.Parse("1907"),
                        ArtStyle = "Cubism",
                        ArtistName = "Pablo Picasso",
                        ArtistBirth = DateTime.Parse("1881-10-25"),
                        Price = 375
                    },
                    new ArtPiece //23
                    {
                        ArtTitle = "The Swing",
                        Year = DateTime.Parse("1767"),
                        ArtStyle = "Historical",
                        ArtistName = "Jean-Honore Fragonard",
                        ArtistBirth = DateTime.Parse("1732-4-5"),
                        Price =  500
                    },
                    new ArtPiece //24
                    {
                        ArtTitle = "No. 5, 1948",
                        Year = DateTime.Parse("1948"),
                        ArtStyle = "Abstract",
                        ArtistName = "Jackson Pollock",
                        ArtistBirth = DateTime.Parse("1912-1-28"),
                        Price = 175
                    },
                    new ArtPiece //25
                    {
                        ArtTitle = "Grande Odalisque",
                        Year = DateTime.Parse("1814"),
                        ArtStyle = "Neoclassicism",
                        ArtistName = "Jean Auguste Dominique Ingres",
                        ArtistBirth = DateTime.Parse("1780-8-29"),
                        Price = 500
                    }

                );
                context.SaveChanges();

            }

            }
        }
    }