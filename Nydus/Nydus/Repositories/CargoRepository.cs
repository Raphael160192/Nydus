using empresa.Models;
using empresa.Data;
using System.Collections.Generic;
using System.Linq;


namespace empresa.Repositories
{
    public class CargoRepository
    {
        private readonly ApplicationContext _context;

        public CargoRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Cargo> GetCargos()
        {
            return _context.Cargos.ToList();
        }

        public Cargo GetCargoById(int id)
        {
            return _context.Cargos.FirstOrDefault(c => c.Id == id);
        }

        public void AddCargo(Cargo cargo)
        {
            _context.Cargos.Add(cargo);
            _context.SaveChanges();
        }

        public void UpdateCargo(Cargo cargo)
        {
            _context.Cargos.Update(cargo);
            _context.SaveChanges();
        }

        public void DeleteCargo(Cargo cargo)
        {
            _context.Cargos.Remove(cargo);
            _context.SaveChanges();
        }
    }
}
