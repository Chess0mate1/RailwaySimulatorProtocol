﻿using DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects.Static;
using DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Line;

namespace DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Converter.Static
{
    internal class SemaphoreConverter : RailwayObjectConverter<Semaphore>
    {
        public override Semaphore GetObjectFrom(LineElements textElements) => new()
        {
            Id = (int)GetIntValue(textElements[0]),

            Name = textElements[1],
            VertexId = (int)GetIntValue(textElements[2])
        };
    }
}
