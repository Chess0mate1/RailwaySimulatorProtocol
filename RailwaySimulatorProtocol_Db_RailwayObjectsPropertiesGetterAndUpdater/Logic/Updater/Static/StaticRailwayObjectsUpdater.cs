using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Generartor.Static;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Updater.Static
{
    internal abstract class StaticRailwayObjectsUpdater : RailwayObjectsUpdater
    {
        protected static StaticRailwayObjectsGenerator _staticGenerator = new();
    }
}
