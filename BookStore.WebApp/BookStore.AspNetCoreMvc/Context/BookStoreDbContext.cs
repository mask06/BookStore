using BookStore.AspNetCoreMvc.Context.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BookStore.AspNetCoreMvc.Context
{
    public class BookStoreDbContext : DbContext
    {
        private static string _connectionString;
        public BookStoreDbContext(DbContextOptions contextOptions): base(contextOptions)
        {
            
        }
        /*        public BookStoreDbContext(IConfiguration configuration)
                {
                    _connectionString = configuration.GetConnectionString("BookStorDbBilkent");

        *//*            var test = configuration.GetSection("Ogrenciler:Ank18:Mustafa");
                    Console.WriteLine("ConStr:" + _connectionString);
                    Console.WriteLine("test:" + test);*//*
                }*/

        public DbSet<City> Cities { get; set; }

/*        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }*/
    }
}