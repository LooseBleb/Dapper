using Dapper.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.DAO.Interface
{
    public interface IUserRepository : IRepositoryGeneric<User>
    {
    }
}
