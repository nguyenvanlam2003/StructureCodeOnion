using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class MyDbContext : DbContext, IApplicationDbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        
        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
        // khai báo DbSet cho các thực thể
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Áp dụng cấu hình từ UserConfiguration
        }
    }
}
