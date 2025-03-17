using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiSegundoDS_bt.models;

namespace ApiSegundoDS_bt.Data
{
    public class ApiSegundoDS_btContext : DbContext
    {
        public ApiSegundoDS_btContext (DbContextOptions<ApiSegundoDS_btContext> options)
            : base(options)
        {
        }

        public DbSet<ApiSegundoDS_bt.models.Aluno> Aluno { get; set; } = default!;
        public DbSet<ApiSegundoDS_bt.models.professor> professor { get; set; } = default!;
        public DbSet<ApiSegundoDS_bt.models.escola> escola { get; set; } = default!;
    }
}
