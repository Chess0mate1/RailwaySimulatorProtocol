using System;
using System.Configuration;
using System.IO;

using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Line;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.DataReader.Text
{
    internal class TxtFileDataReader : FileDataReader
    {
        private StreamReader _reader;
        protected override AppConfigKey Key
            => AppConfigKey.Text;


        public override void OpenFile()
        {
            var path = ConfigurationManager.AppSettings[Key.ToString()];
            _reader = new(path);
        }

        public override LineElements ReadLine()
        {
            string line;

            return TryReadLine() switch
            {
                true => GetLineElements(),
                false => null
            };


            bool TryReadLine()
                => (line = _reader.ReadLine()) != null;

            LineElements GetLineElements()
                => new(line.Split(
                    ' ', StringSplitOptions.RemoveEmptyEntries
            ));
        }

        public override void CloseFile()
            => _reader.Close();
    }
}
