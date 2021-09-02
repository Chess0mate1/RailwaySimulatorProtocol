using System.Collections.Immutable;

using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects.Dynamic;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Generartor.Dynamic
{
    internal partial class DynamicRailwayObjectsGenerator : RailwayObjectsGenerator
    {
        public ImmutableList<Wagon> Wagons
            => _wagons.ToImmutableList();
    }
}
