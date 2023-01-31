using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineBookStore.Models;

namespace OnlineBookStore.Data
{
    public class OnlineBookStoreContext : DbContext
    {
        public OnlineBookStoreContext (DbContextOptions<OnlineBookStoreContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; } 
       // public DbSet<UserName> username { get; set; }
       // public DbSet<Orders> order { get; set; }
    }
}
