using System;

namespace WebProgramlamaOdev.Core.Models
{
    public class Teacher : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime JoinDate { get; set; }
        public string Password { get; set; }
        public string MobileNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Education { get; set; }
    }
}
