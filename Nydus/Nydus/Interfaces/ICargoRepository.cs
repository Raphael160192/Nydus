using empresa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nydus.Interfaces
{
    public interface ICargoRepository
    {
        IEnumerable<Cargo> GetCargos();
        Cargo GetCargoById(int id);
        void AddCargo(Cargo cargo);
        void UpdateCargo(Cargo cargo);
        void DeleteCargo(Cargo cargo);
    }
}
