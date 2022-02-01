using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.DAO.Interface
{
    public interface IRepositoryGeneric<TEntity> where TEntity : class
    {
        Task<IReadOnlyList<TEntity>> GetAllAsync();
        Task<TEntity> GetById(int id);
        Task Delete(int id);

        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task<TEntity> GetById(string id);

    }
}
