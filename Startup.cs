using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Biblioteca_Web_System.Models;

namespace Biblioteca_Web_System
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
            services.AddDbContext<Models.LivroContexto>(options => options.UseSqlServer(Configuration.GetConnectionString("ConexaoSqlServer1")));

            services.AddDbContext<Models.PessoaContexto>(options => options.UseSqlServer(Configuration.GetConnectionString("ConexaoSqlServer2")));

            services.AddDbContext<Models.CategoriaContexto>(options => options.UseSqlServer(Configuration.GetConnectionString("ConexaoSqlServer3")));

            services.AddDbContext<Models.FuncionarioContexto>(options => options.UseSqlServer(Configuration.GetConnectionString("ConexaoSqlServer4")));

            services.AddDbContext<Models.LocacaoContexto>(options => options.UseSqlServer(Configuration.GetConnectionString("ConexaoSqlServer5")));


            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env , LivroContexto contexto  , PessoaContexto contexto1, FuncionarioContexto contexto2, LocacaoContexto contexto3, CategoriaContexto contexto4 )
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            InicializaCategoriaDB.Initialize(contexto4);
            InicializaFuncionarioDB.Initialize(contexto2);
            InicializaPessoaDB.Initialize(contexto1);
            InicializaLocacaoDB.Initialize(contexto3);
            InicializaLivroDB.Initialize(contexto);





        }
    }
}
