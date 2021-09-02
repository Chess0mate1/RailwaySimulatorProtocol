using DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Generartor.Static;

namespace DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Updater.Static
{
    internal abstract class StaticRailwayObjectsUpdater : RailwayObjectsUpdater
    {
        protected static StaticRailwayObjectsGenerator _staticGenerator = new();
    }
}
