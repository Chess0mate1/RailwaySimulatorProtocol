using System.Collections.Generic;
using System.Threading.Tasks;

using DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects.Static;

using Microsoft.EntityFrameworkCore;

namespace DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.Getter.Static
{
    public class DbVerticesGetter : DbRailwayObjectsGetter<Vertex>
    {
        public override async Task<List<Vertex>> GetAsync()
            => await _context.Vertices
                        .AsNoTracking()
                        .ToListAsync();
    }
}
