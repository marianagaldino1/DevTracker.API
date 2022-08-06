using DevTrackR.API.Entities;
using DevTrackR.API.Models;
using DevTrackR.API.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;
using SendGrid;
using SendGrid.Helpers.Mail;
using Microsoft.EntityFrameworkCore;
namespace DevTrackR.API.Models
{
    public class AddPackageUpdateInputModel
    {
        public string? Status { get; set; }
        public bool Delivered { get; set; }
    }
}