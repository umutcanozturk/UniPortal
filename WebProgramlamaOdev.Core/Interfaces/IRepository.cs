using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProgramlamaOdev.Core.Models;

namespace WebProgramlamaOdev.Core.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll();
        Task Delete(int id);
        Task Update(TEntity entity);
        Task<TEntity> GetById(int id);
        Task Create(TEntity entity);
    }
}
