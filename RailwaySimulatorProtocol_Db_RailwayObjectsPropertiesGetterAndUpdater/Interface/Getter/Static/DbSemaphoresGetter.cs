using System.Collections.Generic;
using System.Threading.Tasks;

using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects.Static;

using Microsoft.EntityFrameworkCore;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.Getter.Static
{
    public class DbSemaphoresGetter : DbRailwayObjectsGetter<Semaphore>
    {
        public override async Task<List<Semaphore>> GetAsync()
            => await _context.Semaphores
                        .AsNoTracking()
                        .ToListAsync();
    }
}
