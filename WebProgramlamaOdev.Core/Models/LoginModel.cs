using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProgramlamaOdev.Core.Models
{
    public class LoginModel : BaseEntity
    {

        public string Username { get; set; }
        public string Password { get; set; }
        public string Emaild { get; set; }
    }
}
