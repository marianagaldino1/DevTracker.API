using DevTrackR.API.Entities;
using DevTrackR.API.Models;
using DevTrackR.API.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;
using SendGrid;
using SendGrid.Helpers.Mail;
using Microsoft.EntityFrameworkCore;


namespace DevTrackR.API.Entities
{
    public class PackageUpdate
    {
        public PackageUpdate(string status, int packageId)
        {
            Status = status;
            PackageId = packageId;
        }

        public int Id { get; private set; }
        public int PackageId { get; private set; }
        public string Status { get; private set; }
    }
}