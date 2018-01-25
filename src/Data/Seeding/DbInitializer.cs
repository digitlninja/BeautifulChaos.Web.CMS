using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Data.Contexts;
using Data.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace Data.Seeding
{
    public static class DbInitializer
    {
        /// <summary>
        /// Checks if all available migrations are applied.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static bool AllMigrationsApplied(this DbContext context)
        {
            var appliedMigrations = context.GetService<IHistoryRepository>()
                .GetAppliedMigrations()
                .Select(m => m.MigrationId);

            var totalMigrations = context.GetService<IMigrationsAssembly>()
                .Migrations
                .Select(m => m.Key);

            // Are there any migrations in the difference between the total migrations and applied
            // IE : Are there any unapplied migrations
            return !totalMigrations.Except(appliedMigrations).Any();
        }

        public static void SeedFreshData(IApplicationBuilder applicationBuilder)
        {
            var context = applicationBuilder.ApplicationServices.GetRequiredService<BeautifulChaosContext>();

            SeedPage(applicationBuilder, context);
            SeedAbout(applicationBuilder, context);
            SeedServicesPage(applicationBuilder, context);
            SeedServices(applicationBuilder, context);
            SeedTestimonialsPage(applicationBuilder, context);
            SeedTestimonials(applicationBuilder, context);
            SeedWorkPage(applicationBuilder, context);
            SeedImages(applicationBuilder, context);

            SeedContentColumns(applicationBuilder, context);
        }

        public static void SeedPage(IApplicationBuilder applicationBuilder, BeautifulChaosContext context)
        {
            if (context.Page.Any())
                return;

            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    var source = Directory.GetCurrentDirectory();
                    source += @"\SeedData\Page.json";

                    var data = File.ReadAllText(source);

                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Page] ON");

                    var pages = JsonConvert.DeserializeObject<List<Page>>(data);
                    context.Page.AddRange(pages);
                    context.SaveChanges();

                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Page] OFF");

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    var msg = ex;
                }
            }
        }

        public static void SeedAbout(IApplicationBuilder applicationBuilder, BeautifulChaosContext context)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                if (context.About.Any())
                    return;

                try
                {
                    var source = Directory.GetCurrentDirectory();
                    source += @"\SeedData\About.json";

                    var data = File.ReadAllText(source);

                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].About ON");

                    var about = JsonConvert.DeserializeObject<About>(data);
                    context.About.Add(about);
                    context.SaveChanges();

                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].About OFF");
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    var msg = ex.InnerException;
                }
            }
        }

        public static void SeedServicesPage(IApplicationBuilder applicationBuilder, BeautifulChaosContext context)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                if (context.ServicesPage.Any())
                    return;

                try
                {
                    var source = Directory.GetCurrentDirectory();
                    source += @"\SeedData\ServicesPage.json";

                    var data = File.ReadAllText(source);

                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].ServicesPage ON");

                    var servicesPage = JsonConvert.DeserializeObject<ServicesPage>(data);
                    context.ServicesPage.Add(servicesPage);
                    context.SaveChanges();

                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].ServicesPage OFF");
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    var msg = ex;
                }
            }
        }

        public static void SeedServices(IApplicationBuilder applicationBuilder, BeautifulChaosContext context)
        {
            if (context.Services.Any())
                return;

            try
            {
                var source = Directory.GetCurrentDirectory();
                source += @"\SeedData\Services.json";

                var data = File.ReadAllText(source);

                var services = JsonConvert.DeserializeObject<List<Service>>(data);
                context.Services.AddRange(services);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                var msg = ex;
            }
        }

        public static void SeedTestimonialsPage(IApplicationBuilder applicationBuilder, BeautifulChaosContext context)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                if (context.TestimonialsPage.Any())
                    return;

                try
                {
                    var source = Directory.GetCurrentDirectory();
                    source += @"\SeedData\TestimonialsPage.json";

                    var data = File.ReadAllText(source);

                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].TestimonialsPage ON");

                    var testimonialsPage = JsonConvert.DeserializeObject<TestimonialsPage>(data);
                    context.TestimonialsPage.Add(testimonialsPage);
                    context.SaveChanges();

                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].TestimonialsPage OFF");
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    var msg = ex;
                }
            }
        }

        public static void SeedTestimonials(IApplicationBuilder applicationBuilder, BeautifulChaosContext context)
        {
            if (context.Testimonial.Any())
                return;

            try
            {
                var source = Directory.GetCurrentDirectory();
                source += @"\SeedData\Testimonials.json";

                var data = File.ReadAllText(source);

                var testimonials = JsonConvert.DeserializeObject<List<Testimonial>>(data);
                context.Testimonial.AddRange(testimonials);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                var msg = ex;
            }
        }

        public static void SeedWorkPage(IApplicationBuilder applicationBuilder, BeautifulChaosContext context)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                if (context.Work.Any())
                    return;

                try
                {
                    var source = Directory.GetCurrentDirectory();
                    source += @"\SeedData\Work.json";

                    var data = File.ReadAllText(source);

                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].Work ON");

                    var work = JsonConvert.DeserializeObject<Work>(data);
                    context.Work.Add(work);
                    context.SaveChanges();

                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].Work OFF");
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    var msg = ex;
                }
            }
        }

        public static void SeedImages(IApplicationBuilder applicationBuilder, BeautifulChaosContext context)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                if (context.Images.Any())
                    return;

                try
                {
                    var source = Directory.GetCurrentDirectory();
                    source += @"\SeedData\Image.json";

                    var data = File.ReadAllText(source);

                    var image = JsonConvert.DeserializeObject<Image>(data);
                    context.Images.Add(image);
                    context.SaveChanges();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    var msg = ex;
                }
            }
        }

        public static void SeedContentColumns(IApplicationBuilder applicationBuilder, BeautifulChaosContext context)
        {
            if (context.ContentColumn.Any())
                return;

            try
            {
                var source = Directory.GetCurrentDirectory();
                source += @"\SeedData\ContentColumn.json";

                var data = File.ReadAllText(source);

                var contentColumn = JsonConvert.DeserializeObject<List<ContentColumn>>(data);
                context.ContentColumn.AddRange(contentColumn);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                var msg = ex;
            }
        }
    }
}