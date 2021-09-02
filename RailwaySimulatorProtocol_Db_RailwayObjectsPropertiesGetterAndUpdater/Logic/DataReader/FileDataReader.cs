using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Line;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.DataReader
{
    internal enum AppConfigKey
    {
        Text,
        Word
    }

    internal abstract class FileDataReader
    {
        protected abstract AppConfigKey Key { get; }


        public abstract void OpenFile();

        public abstract LineElements ReadLine();

        public abstract void CloseFile();
    }
}
