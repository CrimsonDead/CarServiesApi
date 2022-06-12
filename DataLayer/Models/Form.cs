using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    public class Form
    {
        public int Id { get; set; }
        public string OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        [InverseProperty("OwnedForms")]
        public User Owner { get; set; }
        [InverseProperty("PassedForms")]
        public List<User> Responers { get; set; }
        public List<FormElement> Elements { get; set; }

    }
}
