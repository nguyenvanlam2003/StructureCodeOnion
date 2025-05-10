using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class  DenpendencyInjection
    {
        // Phương thức mở rộng cho IServiceCollection để thêm các dịch vụ của ứng dụng
        public static IServiceCollection AddApplication(this IServiceCollection services,  IConfiguration configuration)
        {
            // Add application services MediatR
            services.AddMediatR(Assembly.GetExecutingAssembly());
            // Thêm các dịch vụ khác của ứng dụng tại đây
            return services;
        }
    }
}
