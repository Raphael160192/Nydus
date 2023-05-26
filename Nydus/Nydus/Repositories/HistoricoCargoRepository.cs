using empresa.Data;
using empresa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace empresa.Repositories
{
    public class HistoricoCargoRepository
    {
        private readonly ApplicationContext _context;

        public HistoricoCargoRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<HistoricoCargo> GetHistoricoCargos()
        {
            return _context.HistoricoCargos.ToList();
        }

        public HistoricoCargo GetHistoricoCargoById(int id)
        {
            return _context.HistoricoCargos.FirstOrDefault(h => h.Id == id);
        }

        public void AddHistoricoCargo(HistoricoCargo historicoCargo)
        {
            _context.HistoricoCargos.Add(historicoCargo);
            _context.SaveChanges();
        }

        public void UpdateHistoricoCargo(HistoricoCargo historicoCargo)
        {
            _context.HistoricoCargos.Update(historicoCargo);
            _context.SaveChanges();
        }

        public void DeleteHistoricoCargo(HistoricoCargo historicoCargo)
        {
            _context.HistoricoCargos.Remove(historicoCargo);
            _context.SaveChanges();
        }
    }
}
