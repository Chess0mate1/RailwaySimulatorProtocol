using System.Collections.Generic;
using System.Threading.Tasks;

using DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects.Dynamic;

using Microsoft.EntityFrameworkCore;

namespace DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.Getter.Dynamic
{
    public class DbWagonsGetter : DbRailwayObjectsGetter<Wagon>
    {
        public override async Task<List<Wagon>> GetAsync()
            => await _context.Wagons
                        .AsNoTracking()
                        .ToListAsync();
    }
}
