using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Extensions;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Updater.Static.Statics
{
    internal class RailsUpdater : StaticRailwayObjectsUpdater
    {
        protected override void Modify()
            => _context.Rails.Modify(_staticGenerator.Rails);
    }
}
