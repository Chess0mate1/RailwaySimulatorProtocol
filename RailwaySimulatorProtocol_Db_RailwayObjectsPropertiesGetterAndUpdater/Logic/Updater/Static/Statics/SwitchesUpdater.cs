using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Extensions;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Updater.Static.Statics
{
    internal class SwitchesUpdater : StaticRailwayObjectsUpdater
    {
        protected override void Modify()
            => _context.Switches.Modify(_staticGenerator.Switches);
    }
}
