using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ATCSHARP.Models;

namespace ATCSHARP.Data
{
    public class ATCSHARPContext : DbContext
    {
        public ATCSHARPContext (DbContextOptions<ATCSHARPContext> options)
            : base(options)
        {
        }

        public DbSet<ATCSHARP.Models.Pessoas> Pessoas { get; set; } = default!;
    }
}
