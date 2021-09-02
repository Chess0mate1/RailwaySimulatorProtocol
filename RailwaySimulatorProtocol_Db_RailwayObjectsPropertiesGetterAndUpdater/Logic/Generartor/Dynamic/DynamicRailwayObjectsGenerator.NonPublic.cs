using System.Collections.Generic;

using DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects.Dynamic;
using DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Converter.Dynamic;
using DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.DataReader.Word;
using DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Line;

namespace DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Generartor.Dynamic
{
    internal partial class DynamicRailwayObjectsGenerator
    {
        private readonly List<Wagon> _wagons = new();
        private LineElements _lineElements;

        protected override DocxFileDataReader Reader { get; } = new();

        protected override void SetRailwayObjects()
        {
            while (TryReadLine())
            {
                if (IsLineArrayOfValues(_lineElements))
                {
                    WagonConverter converter = new();
                    _wagons.Add(converter.GetObjectFrom(_lineElements));
                }
            }
        }

        private bool TryReadLine()
            => (_lineElements = Reader.ReadLine()) is not null;

        private bool IsLineArrayOfValues(LineElements line)
        {
            string wagonIndex = line[0].Split()[0];

            return int.TryParse(
                wagonIndex,
                out int _
            );
        }
    }
}
