using DevTrackR.API.Entities;
using DevTrackR.API.Models;
using DevTrackR.API.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;
using SendGrid;
using SendGrid.Helpers.Mail;
using Microsoft.EntityFrameworkCore;

namespace DevTrackR.API.Models
{
    public class AddPackageInputModel
    {
        public string? Title { get; set; }
        public decimal Weight { get; set; }
        public string? SenderName { get; set; }
        public string? SenderEmail { get; set; }
    }
}