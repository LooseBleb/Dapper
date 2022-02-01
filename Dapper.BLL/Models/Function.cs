using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.BLL.Models
{
    public class Function : IdentityRole<string>
    {
        public string Description { get; set; }
    }
}
