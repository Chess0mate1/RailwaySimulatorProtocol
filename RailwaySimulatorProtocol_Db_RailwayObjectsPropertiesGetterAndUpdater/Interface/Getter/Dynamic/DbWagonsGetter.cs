using System.Collections.Generic;
using System.Threading.Tasks;

using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects.Dynamic;

using Microsoft.EntityFrameworkCore;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.Getter.Dynamic
{
    public class DbWagonsGetter : DbRailwayObjectsGetter<Wagon>
    {
        public override async Task<List<Wagon>> GetAsync()
            => await _context.Wagons
                        .AsNoTracking()
                        .ToListAsync();
    }
}
