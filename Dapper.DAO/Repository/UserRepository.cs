using Dapper.BLL.Models;
using Dapper.DAO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.DAO.Repository
{
    public class UserRepository : RepositoryGeneric<User>, IUserRepository
    {
        private readonly Context _context;
        public UserRepository(Context context) : base(context, "user")
        {
            _context = context;
        }
    }
}
