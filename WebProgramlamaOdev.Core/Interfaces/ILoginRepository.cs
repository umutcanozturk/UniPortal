using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProgramlamaOdev.Core.Models;

namespace WebProgramlamaOdev.Core.Interfaces
{
    public interface ILoginRepository : IRepository<LoginModel>
    {
        Task<bool> Validate(string id, string pw);
    }
}
