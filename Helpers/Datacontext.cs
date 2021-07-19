using ApiInterciclo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiInterciclo.Helpers
{
    public class Datacontext : DbContext
    {
        public Datacontext(DbContextOptions<Datacontext> option) : base(option)
        {
        }

        public DbSet<User> User { get; set; }
    }
}
