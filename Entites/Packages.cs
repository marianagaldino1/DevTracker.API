using DevTrackR.API.Persistence;
using DevTrackR.API.Controllers;
using DevTrackR.API.Models;
using DevTrackR.API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevTrackR.API.Entities
{
    public class Package
    {
        public Package(string title, decimal weight)
        {
            Code = Guid.NewGuid().ToString();
            Title = title;
            Weight = weight;
            Delivered = false;
            PostedAt = DateTime.Now;
            Updates = new List<PackageUpdate>();
        }

        public void AddUpdate(string status, bool delivered) {
            Updates.Add(new PackageUpdate(status, Id));

            if (delivered){
                Delivered = true;
            }
        }

        public int Id { get; private set; }
        public string Code { get; private set; }
        public string Title { get; private set; }
        public decimal Weight { get; private set; }
        public bool Delivered { get; private set; }
        public DateTime PostedAt { get; private set; }
        public List<PackageUpdate> Updates { get; private set; }
    }
}