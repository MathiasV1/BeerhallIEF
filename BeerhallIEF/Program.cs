using BeerhallIEF.Data;
using System;

namespace BeerhallIEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                Console.WriteLine("Database created");
            }
        }
    }
}
