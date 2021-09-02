using DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects.Dynamic;
using DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Line;

namespace DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Converter.Dynamic
{
    internal class WagonConverter : RailwayObjectConverter<Wagon>
    {
        public override Wagon GetObjectFrom(LineElements textElements) => new()
        {
            Id = (int)GetIntValue(textElements[0].Split()[0]),

            Type = textElements[1],

            Length = (double)GetDoubleValue(textElements[2]),
            Base = (double)GetDoubleValue(textElements[3]),
            CartBase = (double)GetDoubleValue(textElements[4]),

            WagonModelName = textElements[5],
            CartName = textElements[6],
        };
    }
}
