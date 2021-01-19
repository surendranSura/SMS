using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using SMSAPI.Authentication;
using System.Text;

namespace SMS
{
	public class Startup
	{
		//readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			//services.AddCors(options =>
			//{
			//	options.AddPolicy(name: MyAllowSpecificOrigins,
			//					  builder =>
			//					  {
			//						  builder.WithOrigins("http://localhost:4200");
			//					  });
			//});

			string key = "My secret key to validate the JWt token authentication";
			services.AddControllersWithViews();
			services.AddAuthentication(X =>
			{
				X.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				X.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

			}).AddJwtBearer(X =>
			{
				X.RequireHttpsMetadata = false;
				X.SaveToken = true;
				X.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
				{
					ValidateIssuerSigningKey = true,
					IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
					ValidateAudience = false,
					ValidateIssuer = false
				};
			});

			services.AddAuthorization(options =>
			{
				//options.AddPolicy("Founderonly", policy => policy.RequireClaim(""));
				options.AddPolicy("Staffonly", policy => policy.RequireClaim("StaffNumber"));
				options.AddPolicy("Studentonly", policy => policy.RequireClaim("AdmissionNumber"));
			});

			// In production, the Angular files will be served from this directory
			services.AddSpaStaticFiles(configuration =>
			{
				configuration.RootPath = "ClientApp/dist";
			});

			services.AddSingleton<IJwtAuthenticationManager>(new JwtAuthenticationManager(key));
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
			}

			app.UseStaticFiles();
			if (!env.IsDevelopment())
			{
				app.UseSpaStaticFiles();
			}

			app.UseRouting();

			//app.UseCors(MyAllowSpecificOrigins);

			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller}/{action=Index}/{id?}");
			});

			app.UseSpa(spa =>
			{
				// To learn more about options for serving an Angular SPA from ASP.NET Core,
				// see https://go.microsoft.com/fwlink/?linkid=864501

				spa.Options.SourcePath = "ClientApp";

				if (env.IsDevelopment())
				{
					spa.UseAngularCliServer(npmScript: "start");
				}
			});
		}
	}
}
