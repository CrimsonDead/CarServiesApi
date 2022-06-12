using DataLayer.Context;
using DataLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Repository
{
    public class FormElementRepository : IRepository<FormElement>
    {
        private readonly ApplicationContext _context;

        public FormElementRepository(ApplicationContext context)
        {
            _context = context;
        }

        public FormElement Add(FormElement item)
        {
            _context.FormElements.Add(item);
            _context.SaveChanges();
            return item;
        }

        public FormElement Delete(FormElement item)
        {
            _context.FormElements.Remove(item);
            _context.SaveChanges();
            return item;
        }

        public FormElement GetItem(int id)
        {
            return _context.FormElements.FirstOrDefault(f => f.Id == id);
        }

        public IEnumerable<FormElement> GetItems()
        {
            return _context.FormElements.ToList();
        }

        public FormElement Update(FormElement item)
        {
            _context.FormElements.Update(item);
            _context.SaveChanges();
            return item;
        }
    }
}
