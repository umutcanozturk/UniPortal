using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProgramlamaOdev.Core.Models;

namespace WebProgramlamaOdev.Models
{
    public class LoginModelBase : LoginModel
    {

        public string ReturnUrl { get; set; }
    }
}
