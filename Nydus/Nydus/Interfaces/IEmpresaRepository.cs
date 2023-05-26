using empresa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nydus.Interfaces
{
    public interface IEmpresaRepository
    {
        void Add(Empresa empresa);
        Empresa GetById(int id);
        List<Empresa> GetAll();
        void Update(Empresa empresa);
        void Delete(Empresa empresa);
    }
}
