namespace J7z_E_Commerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                            new Product
                            {
                                Id = 1,
                                Title = "Star Wars Episode I: The Phantom Menace",
                                Description = "written by Terry Brooks and published on April 21, 1999",
                                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/ca/Phantommenacenovel_obiwan.jpg",
                                Price = 9.99m
                            },
            new Product
            {
                Id = 2,
                Title = "Star Wars: Episode II – Attack of the Clones",
                Description = "The biggest addition to the story is the fact that the Lars family are introduced and have their own subplot leading up to when they appear in the movie.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/5d/Attackoftheclones_novel.jpg",
                Price = 8.99m
            },
            new Product
            {
                Id = 3,
                Title = "Star Wars: Revenge of the Sith",
                Description = "The lightsaber fight between Anakin, Obi-Wan and Count Dooku is portrayed in far greater detail than in the film.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/88/RevengeOfTheSithNovel.jpg",
                Price = 7.99m
            }
                );
        }

        public DbSet<Product> products { get; set; }


    }
}
