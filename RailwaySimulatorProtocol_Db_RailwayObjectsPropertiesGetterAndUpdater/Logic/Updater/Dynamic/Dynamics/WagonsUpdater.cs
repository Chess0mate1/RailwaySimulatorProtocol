

using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Extensions;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Updater.Dynamic.Dynamics
{
    internal class WagonsUpdater : DynamicRailwayObjectsUpdater
    {
        protected override void Modify()
            => _context.Wagons.Modify(_dynamicGenerator.Wagons);
    }
}
