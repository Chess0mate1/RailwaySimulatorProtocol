using System.Collections.Generic;
using System.Threading.Tasks;

using DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects.Static;

using Microsoft.EntityFrameworkCore;

namespace DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.Getter.Static
{
    public class DbSemaphoresGetter : DbRailwayObjectsGetter<Semaphore>
    {
        public override async Task<List<Semaphore>> GetAsync()
            => await _context.Semaphores
                        .AsNoTracking()
                        .ToListAsync();
    }
}
