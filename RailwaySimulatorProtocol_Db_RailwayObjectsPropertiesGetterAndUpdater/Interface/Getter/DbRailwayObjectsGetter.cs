using System.Collections.Generic;
using System.Threading.Tasks;

using DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects;
using DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Context;

namespace DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.Getter
{
    public abstract class DbRailwayObjectsGetter<T>
        where T : RailwayObject
    {
        private protected ApplicationContext _context = new();

        public abstract Task<List<T>> GetAsync();
    }
}
