using DataLayer.Context;
using DataLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Repository
{
    public class FormRepository : IRepository<Form>
    {
        private readonly ApplicationContext _context;

        public FormRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Form Add(Form item)
        {
            _context.Forms.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Form Delete(Form item)
        {
            _context.Forms.Remove(item);
            _context.SaveChanges();
            return item;
        }

        public Form GetItem(int id)
        {
            return _context.Forms.FirstOrDefault(f => f.Id == id);
        }

        public IEnumerable<Form> GetItems()
        {
            return _context.Forms.ToList();
        }

        public Form Update(Form item)
        {
            _context.Forms.Update(item);
            _context.SaveChanges();
            return item;
        }
    }
}
