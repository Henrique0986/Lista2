using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WEBList2.Models;

namespace WEBList2.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<WEBList2.Models.Cadclientes> Cadclientes { get; set; } = default!;

        public DbSet<WEBList2.Models.CadMaquinas> CadMaquinas { get; set; } = default!;

        public DbSet<WEBList2.Models.Inventario> Inventario { get; set; } = default!;
    }
}
