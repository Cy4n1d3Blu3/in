using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzzWeb.Models;
using Microsoft.EntityFrameworkCore;
namespace FizzBuzzWeb.Data
{
    public class PeopleContext : DbContext
    {
        public DbSet<Models.Data> data { get; set; }
        public PeopleContext(DbContextOptions options) : base(options) { }
    }
}
