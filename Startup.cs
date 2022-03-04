using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Recon.Repository;
using Recon.Repository.Infrastructure;
using ReconUtility_Core.Recon.Repository;

namespace ReconUtility_Core
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContextPool<ReconDB>(option => option.UseSqlServer(Configuration.GetConnectionString("ReconDBConnectionString")));
            services.AddScoped<IBillingRepository, BillingRepository>();
            services.AddScoped<IPolicyRepository, PolicyRepository>();
            services.AddScoped<IReInsurancePolicyRepository, ReInsurancePolicyRepository>();
            services.AddScoped<IReInsuranceClaimRepository, ReInsuranceClaimRepository>();
            services.AddScoped<IClaimRepository, ClaimsRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
