using System.Globalization;

using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects;
using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Line;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Converter
{
    internal abstract class RailwayObjectConverter<T>
        where T : RailwayObject
    {
        protected double? GetDoubleValue(string text)
        {
            return IsNumber(out var value) ?
                value :
                null;

            bool IsNumber(out double value)
            {
                return double.TryParse(
                    text,
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out value
                );
            }
        }

        protected int? GetIntValue(string text)
        {
            return IsNumber(out var value) ?
                value :
                null;

            bool IsNumber(out int value)
            {
                return int.TryParse(
                    text,
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out value
                );
            }
        }

        public abstract T GetObjectFrom(LineElements textElements);
    }
}
