using Dapper.DAO.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.DAO.Repository
{
    public class RepositoryGeneric<TEntity> : IRepositoryGeneric<TEntity> where TEntity : class
    {

        private readonly Context _context;
        private readonly string _tableName;
     
        public RepositoryGeneric(Context context, string tableName)
        {
            _context = context;
            _tableName = tableName;
        }

        public Task Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<TEntity>> GetAllAsync()
        {
            try
            {
                var Query = $"SELECT * FROM [{_tableName}]";

                using (var conn = _context.CreateConnection())
                {
                    conn.Open();

                    var result = await conn.QueryAsync<TEntity>(Query);

                    conn.Close();

                    return result.ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<TEntity> GetById(int id)
        {
            var Query = $"SELECT * FROM [{_tableName}] WHERE [Id] = {id}";

            using (var conn = _context.CreateConnection())
            {
                return (TEntity)await conn.QueryAsync<TEntity>(Query);
            }
        }

        public async Task<TEntity> GetById(string id)
        {
            var Query = $"SELECT * FROM [{_tableName}] WHERE [Id] in {id}";

            using (var conn = _context.CreateConnection())
            {
                try
                {
                    conn.Open();
                    var result = await conn.QueryAsync<TEntity>(Query);
                    conn.Close();
                    return (TEntity)result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public Task Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
