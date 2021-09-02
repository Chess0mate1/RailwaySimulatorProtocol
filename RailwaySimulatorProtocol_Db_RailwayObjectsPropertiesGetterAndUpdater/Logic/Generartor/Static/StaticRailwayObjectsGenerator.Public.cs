using System.Collections.Immutable;

using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects.Static;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Generartor.Static
{
    internal partial class StaticRailwayObjectsGenerator : RailwayObjectsGenerator
    {
        public ImmutableList<Vertex> Vertices
            => _vertices.ToImmutableList();

        public ImmutableList<Rail> Rails
            => _rails.ToImmutableList();

        public ImmutableList<Switch> Switches
            => _switches.ToImmutableList();

        public ImmutableList<Semaphore> Semaphores
            => _semaphores.ToImmutableList();

        public ImmutableList<Retarder> Retarders
            => _retarders.ToImmutableList();
    }
}
