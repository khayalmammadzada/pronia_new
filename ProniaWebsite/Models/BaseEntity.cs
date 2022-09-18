using System;
namespace ProniaWebsite.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedTime { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedTime { get; set; } = DateTime.UtcNow;



    }
}
