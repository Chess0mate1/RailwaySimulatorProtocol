﻿using DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects.Static;
using DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Line;

namespace DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Converter.Static
{
    internal class RetarderConverter : RailwayObjectConverter<Retarder>
    {
        public override Retarder GetObjectFrom(LineElements textElements) => new()
        {
            Id = (int)GetIntValue(textElements[0]),

            RwNumber = (int)GetIntValue(textElements[1]),
            RailId = (int)GetIntValue(textElements[2])
        };
    }
}
