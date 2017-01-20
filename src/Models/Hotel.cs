using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace NewJoiner.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class Hotel
    {
        public int id { get; set; }
        public string name { get; set; }
        public int stars { get; set; }
        public string city { get; set; }
        public string country { get; set; }
    }
}
