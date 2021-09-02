using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects.Static;
using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Line;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Converter.Static
{
    internal class VertexConverter : RailwayObjectConverter<Vertex>
    {
        public override Vertex GetObjectFrom(LineElements textElements) => new()
        {
            Id = (int)GetIntValue(textElements[0]),

            X = (double)GetDoubleValue(textElements[1]),
            Y = (double)GetDoubleValue(textElements[2]),
            Z = (double)GetDoubleValue(textElements[3])
        };
    }
}
