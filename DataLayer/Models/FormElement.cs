using System.Collections.Generic;

namespace DataLayer.Models
{
    public class FormElement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Form> Forms { get; set; }
    }
}
