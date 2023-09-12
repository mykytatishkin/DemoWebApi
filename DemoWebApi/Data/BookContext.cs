using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoWebApi.Models;

    public class BookContext : DbContext
    {
        public BookContext (DbContextOptions<BookContext> options)
            : base(options)
        {
        }

        public DbSet<DemoWebApi.Models.Book> Book { get; set; } = default!;
        public DbSet<DemoWebApi.Models.Picture> Images { get; set; } = default!;
}
