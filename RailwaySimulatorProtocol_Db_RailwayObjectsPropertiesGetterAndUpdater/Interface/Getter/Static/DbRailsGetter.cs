using System.Collections.Generic;
using System.Threading.Tasks;

using DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects.Static;

using Microsoft.EntityFrameworkCore;

namespace DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.Getter.Static
{
    public class DbRailsGetter : DbRailwayObjectsGetter<Rail>
    {
        public override async Task<List<Rail>> GetAsync()
            => await _context.Rails
                        .AsNoTracking()
                        .ToListAsync();
    }
}
