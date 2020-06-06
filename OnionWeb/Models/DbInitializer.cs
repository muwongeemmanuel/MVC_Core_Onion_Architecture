using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnionDomain;
using OnionRepository;
using Microsoft.Extensions.DependencyInjection;

namespace OnionWeb.Models
{
    public class DbInitializer
    {
        //public static void Seed (IApplicationBuilder applicationBuilder)
        //{
        //    AppDbContext context = applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

        //    if (!context.Employees.Any())
        //    {
        //        context.AddRange(
        //            new Employee
        //            {
        //                FirstName = "Emmanuel",
        //                LastName = "Muwonge",
        //                Position = "Software Engineer",
        //                Department = "I.T",
        //                DOB = "1997/12/25",
        //                Salary = "3000000"

        //            },
        //            new Employee
        //            {
        //                FirstName = "Sherry",
        //                LastName = "Akakunda ",
        //                Position = "Auditor",
        //                Department = "Audit",
        //                DOB = "2002/10/25",
        //                Salary = "2500000"

        //            });
        //    }
        //    context.SaveChanges();
        //}
        public static void Initialize (AppDbContext context)
        {
            context.Database.EnsureCreated();

            //Look for any employees
            if (!context.Employees.Any())
            {
                context.AddRange(
                    new Employee
                    {
                        FirstName = "Emmanuel",
                        LastName = "Muwonge",
                        Position = "Software Engineer",
                        Department = "I.T",
                        DOB = "1997/12/25",
                        Salary = "3000000"

                    },
                    new Employee
                    {
                        FirstName = "Sherry",
                        LastName = "Akakunda ",
                        Position = "Auditor",
                        Department = "Audit",
                        DOB = "2002/10/25",
                        Salary = "2500000"

                    });
                context.SaveChanges();
            }
        }
    }
}
