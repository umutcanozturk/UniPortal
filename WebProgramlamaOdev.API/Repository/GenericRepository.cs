using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebProgramlamaOdev.API.Models.Context;
using WebProgramlamaOdev.Core.Interfaces;
using WebProgramlamaOdev.Core.Models;

namespace WebProgramlamaOdev.API.Repository
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly PostgreDbContext _dbContext;
        public GenericRepository(PostgreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Create(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
             _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _dbContext.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
