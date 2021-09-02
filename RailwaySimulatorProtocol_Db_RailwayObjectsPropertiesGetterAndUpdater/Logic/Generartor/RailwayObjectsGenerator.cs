using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.DataReader;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Generartor
{
    internal abstract class RailwayObjectsGenerator
    {
        public RailwayObjectsGenerator()
        {
            Reader.OpenFile();

            SetRailwayObjects();

            Reader.CloseFile();
        }

        protected abstract FileDataReader Reader { get; }

        protected abstract void SetRailwayObjects();
    }
}