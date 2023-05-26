using empresa.Data;
using empresa.Models;
using System.Collections.Generic;
using System.Linq;

namespace empresa.Repositories
{
    public class EmpresaRepository
    {
        private readonly ApplicationContext _context;

        public EmpresaRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Add(Empresa empresa)
        {
            _context.Empresas.Add(empresa);
            _context.SaveChanges();
        }

        public Empresa GetById(int id)
        {
            return _context.Empresas.Find(id);
        }

        public List<Empresa> GetAll()
        {
            return _context.Empresas.ToList();
        }

        public void Update(Empresa empresa)
        {
            _context.Empresas.Update(empresa);
            _context.SaveChanges();
        }

        public void Delete(Empresa empresa)
        {
            _context.Empresas.Remove(empresa);
            _context.SaveChanges();
        }
    }
}
