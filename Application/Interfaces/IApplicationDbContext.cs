using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IApplicationDbContext
    {
        // khai báo thực thể
      
        // lưu bất đồng bộ
        Task<int> SaveChangesAsync();
    }
}
