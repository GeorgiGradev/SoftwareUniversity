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

            var result = RemoveTown(context);
            Console.WriteLine(result);
        }

        //15. Remove Town

        public static string RemoveTown(SoftUniContext context)
        {
            var employeesInSeattle = context
                .Employees
                .Where(e => e.Address.Town.Name == "Seattle");

            int addressesCount = employeesInSeattle.Count();

            foreach (var e in employeesInSeattle)
            {
                e.AddressId = null;
            }

            var addressesToRemove = context
                .Addresses
                .Where(a => a.Town.Name == "Seattle");

            foreach (var a in addressesToRemove)
            {
                context.Remove(a);
            }

            var townToRemove = context
                .Towns
                .Where(t => t.Name == "Seattle")
                .Single();

            context.Remove(townToRemove);

            context.SaveChanges();

            return $"{addressesCount} addresses in Seattle were deleted";
        }
    }
}
