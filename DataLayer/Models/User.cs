using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class User : IdentityUser
    {
        public List<Form> Forms { get; set; }
    }
}
