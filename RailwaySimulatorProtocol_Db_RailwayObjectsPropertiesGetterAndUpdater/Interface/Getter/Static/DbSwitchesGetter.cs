using System.Collections.Generic;
using System.Threading.Tasks;

using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects.Static;

using Microsoft.EntityFrameworkCore;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.Getter.Static
{
    public class DbSwitchesGetter : DbRailwayObjectsGetter<Switch>
    {
        public override async Task<List<Switch>> GetAsync()
            => await _context.Switches
                        .AsNoTracking()
                        .ToListAsync();
    }
}
