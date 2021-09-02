using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects.Static;
using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Line;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Converter.Static
{
    internal class SwitchConverter : RailwayObjectConverter<Switch>
    {
        public override Switch GetObjectFrom(LineElements textElements) => new()
        {
            Id = (int)GetIntValue(textElements[0]),

            RwNumber = (int)GetIntValue(textElements[1]),

            RearRailId = (int)GetIntValue(textElements[2]),

            LeftRailId = (int)GetIntValue(textElements[3]),
            RightRailId = (int)GetIntValue(textElements[4])
        };
    }
}
