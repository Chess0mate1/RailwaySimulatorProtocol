using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Extensions;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Updater.Static.Statics
{
    internal class VerticesUpdater : StaticRailwayObjectsUpdater
    {
        protected override void Modify()
            => _context.Vertices.Modify(_staticGenerator.Vertices);
    }
}
