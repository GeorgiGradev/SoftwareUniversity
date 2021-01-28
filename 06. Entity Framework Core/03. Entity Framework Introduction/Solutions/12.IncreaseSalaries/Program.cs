using System;
using System.Globalization;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SoftUni.Data;
using SoftUni.Models;

namespace SoftUni
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using var context = new SoftUniContext();

            var result = IncreaseSalaries(context);
            Console.WriteLine(result);
        }

        // 12. Increase Salaries

        public static string IncreaseSalaries(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context
                 .Employees
                 .Where(e => e.Department.Name == "Engineering"
                 || e.Department.Name == "Tool Design"
                 || e.Department.Name == "Marketing "
                 || e.Department.Name == "Information Services")
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName);

            foreach (Employee e in employees)
            {
                e.Salary *= 1.12m;
            }
            context.SaveChanges();

            var employeesToList = employees.ToList();

            foreach (var e in employeesToList)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} (${e.Salary:f2})");
            }
         

            return sb.ToString().TrimEnd();
        }
    }
}
