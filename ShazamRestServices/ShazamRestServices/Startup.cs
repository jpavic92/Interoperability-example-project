using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ShazamRestServices.Models;

namespace ShazamRestServices
{
    public class Startup
    {
        internal static List<TrackForValidate> tracks;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            tracks = new List<TrackForValidate>();
            TrackForValidate track = new TrackForValidate
            {
                //Artists = new List<Artist> { new Artist { Id = "1", Name = "Pero", Adamid = "2" } },
                //Key = "3232",
                Title = "Neka pjesma",
                Url = "bla",

            };
            tracks.Add(track);
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddXmlDataContractSerializerFormatters();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
