using System.Collections.Generic;
using System.Threading.Tasks;

using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects.Static;

using Microsoft.EntityFrameworkCore;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.Getter.Static
{
    public class DbRetardersGetter : DbRailwayObjectsGetter<Retarder>
    {
        public override async Task<List<Retarder>> GetAsync()
            => await _context.Retarders
                        .AsNoTracking()
                        .ToListAsync();
    }
}
