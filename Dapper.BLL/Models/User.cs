using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.BLL.Models
{
    public class User : IdentityUser<string>
    {
        public string CPF { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
