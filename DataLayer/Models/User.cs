using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public class User : IdentityUser
    {
        public List<Form> OwnedForms { get; set; }
        public List<Form> PassedForms { get; set; }
    }
}
