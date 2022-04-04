using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Form
    {
        public int Id { get; set; }
        public string Master { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
