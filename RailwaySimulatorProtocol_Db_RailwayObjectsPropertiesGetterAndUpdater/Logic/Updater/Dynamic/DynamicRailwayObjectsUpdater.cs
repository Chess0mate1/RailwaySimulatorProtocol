using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Generartor.Dynamic;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Updater.Dynamic
{
    internal abstract class DynamicRailwayObjectsUpdater : RailwayObjectsUpdater
    {
        protected static DynamicRailwayObjectsGenerator _dynamicGenerator = new();
    }
}
