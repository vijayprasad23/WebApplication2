using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

    public class Movies2ContextDb : DbContext
    {
        public Movies2ContextDb (DbContextOptions<Movies2ContextDb> options)
            : base(options)
        {
        }

        public DbSet<WebApplication2.Models.Movie> Movie { get; set; }

        public DbSet<WebApplication2.Models.Producer> Producer { get; set; }
    }
