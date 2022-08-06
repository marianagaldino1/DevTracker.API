using DevTrackR.API.Entities;
using DevTrackR.API.Models;
using DevTrackR.API.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;
using SendGrid;
using SendGrid.Helpers.Mail;
using Microsoft.EntityFrameworkCore;
 
namespace DevTrackR.API.Persistence.Repositories
{
   public interface IPackageRepository
   {
       List<Package> GetAll();
       Package GetByCode(string code);
       void Add(Package package);
       void Update(Package package);
   }
}