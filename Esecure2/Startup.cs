using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO.Compression;
using Microsoft.AspNetCore.ResponseCompression;
using EsecureModel.Usuario;
using EsecureWebApp.Data;
using Amazon.S3;
using Microsoft.AspNetCore.Identity.UI.Services;
using EsecureWebApp.Services;

namespace Esecure2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        //public ILoggerFactory logger { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            // Conexión a base de datos
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            // Amazon web services

            services.AddAWSService<IAmazonS3>();


            // Identity para usuarios
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultUI()
                .AddDefaultTokenProviders();

            // versión de .net core
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddRazorPagesOptions(options =>
                {
                    options.AllowAreas = true;
                    options.Conventions.AuthorizeAreaFolder("Identity", "/Account/Manage");
                    options.Conventions.AuthorizeAreaPage("Identity", "/Account/Logout");
                    options.Conventions.AuthorizeAreaPage("Identity", "/Account/Login");
                });

            services.AddSingleton<IEmailSender, EmailSender>();
            
            services.Configure<AuthMessageSenderOptions>(Configuration);

            // Traza los form requests
            services.AddAntiforgery(o => o.HeaderName = "XSRF-TOKEN");

            //services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));

            /* deshabilitamos compresión
            services.AddResponseCompression(options =>
            {
                options.Providers.Add<GzipCompressionProvider>();
                //options.Providers.Add<CustomCompressionProvider>();
                options.MimeTypes =
                    ResponseCompressionDefaults.MimeTypes.Concat(
                        new[] {
                            "image/svg+xml",
                            "application/javascript",
                            "application/json",
                            "application/xml",
                            "text/css",
                            "text/html",
                            "text/json",
                            "text/plain",
                            "text/xml"
                        });
            });
            services.Configure<GzipCompressionProviderOptions>(options =>
            {
                options.Level = CompressionLevel.Optimal;
            });
            */
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ApplicationDbContext context, RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                //sapp.UseExceptionHandler("/Error");
            }
            else
            {
                // depurar en la nube !!!
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                // descomentar cuando se libere a producción
                // app.UseExceptionHandler("/Error");
                //app.UseHsts();
            }

            // app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();
            // app.UseResponseCompression();
            app.UseMvc();

            // DummyData.Initialize(context, userManager, roleManager).Wait();// seed here
        }
    }
}
