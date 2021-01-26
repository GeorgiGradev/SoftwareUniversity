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


            var result = GetEmployeesInPeriod(context);
            Console.WriteLine(result);
        }

        // 7. Employees and Projects

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context
                .Employees
                .Include(x => x.Manager)
                .Include(x => x.EmployeesProjects)
                .ThenInclude(x => x.Project)
                .Where(x => x.EmployeesProjects
                    .Any(project => project.Project.StartDate.Year > 2001
                        && project.Project.StartDate.Year <= 2003))
                .Take(10)
                .Select(x => new
                {
                    EmployeeFirstName = x.FirstName,
                    EmployeeLastname = x.LastName,
                    ManagerFisrstName = x.Manager.FirstName,
                    ManagerLastName = x.Manager.LastName,
                    Projects = x.EmployeesProjects
                })
                .ToList();

            foreach (var e in employees)
            {
                sb.AppendLine($"{e.EmployeeFirstName} {e.EmployeeLastname} - Manager: {e.ManagerFisrstName} {e.ManagerLastName}");
                foreach (var project in e.Projects)
                {
                    sb.AppendLine($"--{project.Project.Name} - " +
                        $"{project.Project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)} - " +
                        $"{(project.Project.EndDate == null ? "not finished" : project.Project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture))}");
                }
            }
          
            return sb.ToString().TrimEnd();
        }
    }
}
