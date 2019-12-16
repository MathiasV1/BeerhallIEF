using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerhallIEF.Data
{
    public class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionstring =
                @"Server =.;Database=Beerhall;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionstring);
        }
    }
}
