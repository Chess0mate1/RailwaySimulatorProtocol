using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Extensions;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Updater.Static.Statics
{
    internal class RetardersUpdater : StaticRailwayObjectsUpdater
    {
        protected override void Modify()
            => _context.Retarders.Modify(_staticGenerator.Retarders);
    }
}
