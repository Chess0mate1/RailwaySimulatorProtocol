using DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects.Static;
using DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Line;

namespace DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Converter.Static
{
    internal class RailConverter : RailwayObjectConverter<Rail>
    {
        public override Rail GetObjectFrom(LineElements textElements) => new()
        {
            Id = (int)GetIntValue(textElements[0]),

            RearVertexId = (int)GetIntValue(textElements[1]),
            FrontVertexId = (int)GetIntValue(textElements[2]),

            RearRailId = GetIntValue(textElements[3]),
            FrontRailId = GetIntValue(textElements[4]),

            RearSwitchId = GetIntValue(textElements[5]),
            FrontSwitchId = GetIntValue(textElements[6]),

            LeftRailId = GetIntValue(textElements[7]),
            RightRailId = GetIntValue(textElements[8])
        };
    }
}
