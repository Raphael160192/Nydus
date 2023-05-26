using empresa.Models;
using System.Collections.Generic;

namespace Nydus.Interfaces
{
    public interface IHistoricoCargoRepository
    {
        IEnumerable<HistoricoCargo> GetHistoricoCargos();
        HistoricoCargo GetHistoricoCargoById(int id);
        void AddHistoricoCargo(HistoricoCargo historicoCargo);
        void UpdateHistoricoCargo(HistoricoCargo historicoCargo);
        void DeleteHistoricoCargo(HistoricoCargo historicoCargo);
    }
}
