using System.Collections.Generic;
using System.Threading.Tasks;

using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects;
using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Context;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.Getter
{
    public abstract class DbRailwayObjectsGetter<T>
        where T : RailwayObject
    {
        private protected ApplicationContext _context = new();

        public abstract Task<List<T>> GetAsync();
    }
}
