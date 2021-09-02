using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Extensions;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Updater.Static.Statics
{
    internal class SemaphoresUpdater : StaticRailwayObjectsUpdater
    {
        protected override void Modify()
            => _context.Semaphores.Modify(_staticGenerator.Semaphores);
    }
}
