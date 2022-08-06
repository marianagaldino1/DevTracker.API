using DevTrackR.API.Entities;
using DevTrackR.API.Models;
using DevTrackR.API.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;
using SendGrid;
using SendGrid.Helpers.Mail;
using Microsoft.EntityFrameworkCore;

namespace DevTrackR.API.Persistence.Repositories
{
   public class PackageRepository : IPackageRepository
   {
       private readonly DevTrackRContext _context;
       public PackageRepository(DevTrackRContext context)
       {
           _context = context;
       }
 
       public void Add(Package package)
       {
           _context.Packages.Add(package);
           _context.SaveChanges();
       }
 
       public List<Package> GetAll()
       {
           return _context.Packages.ToList();
       }
 
       public Package GetByCode(string code)
       {
           return _context
               .Packages
               .Include(s => s.Updates)
               .SingleOrDefault(s => s.Code == code);
       }
 
       public void Update(Package package)
       {
           _context.Entry(package).State = EntityState.Modified;
           _context.SaveChanges();
       }
   }
}