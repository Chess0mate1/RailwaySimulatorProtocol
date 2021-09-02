using System.Collections.Generic;
using System.Threading.Tasks;

using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects.Static;

using Microsoft.EntityFrameworkCore;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.Getter.Static
{
    public class DbVerticesGetter : DbRailwayObjectsGetter<Vertex>
    {
        public override async Task<List<Vertex>> GetAsync()
            => await _context.Vertices
                        .AsNoTracking()
                        .ToListAsync();
    }
}
