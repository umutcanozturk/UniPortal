using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebProgramlamaOdev.API.Models.Context;
using WebProgramlamaOdev.Core.Interfaces;
using WebProgramlamaOdev.Core.Models;

namespace WebProgramlamaOdev.API.Repository
{
    public class LoginRepository : GenericRepository<LoginModel>, ILoginRepository
    { 
        private readonly PostgreDbContext _postgreDbContext;
        public LoginRepository(PostgreDbContext dbContext) : base(dbContext)
        {
            _postgreDbContext = dbContext;
        }
        public async Task<bool> Validate(string mail, string pw)
        {
           var entity = await _postgreDbContext.Set<LoginModel>().AsNoTracking().FirstOrDefaultAsync(x => x.Emaild == mail && x.Password == pw);
            if(entity != null)
            {
                return true;
            }
            else { return false; }
        }
    }
}
