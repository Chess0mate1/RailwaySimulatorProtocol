using System.Collections.Generic;
using System.Configuration;
using System.Linq;

using DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Line;

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.DataReader.Word
{
    internal class DocxFileDataReader : FileDataReader
    {
        private WordprocessingDocument _document;
        private Table _table;
        private IEnumerable<TableRow> _rows;
        private int _rowsCount;

        private int nextLineIndex = 0;
        protected override AppConfigKey Key
            => AppConfigKey.Word;


        public override void OpenFile()
        {
            var path = ConfigurationManager.AppSettings[Key.ToString()];

            _document = WordprocessingDocument.Open(path, false);
            _table = _document.MainDocumentPart.Document.Body.Elements<Table>().First();
            _rows = _table.Elements<TableRow>();
            _rowsCount = _rows.Count();
        }

        public override LineElements ReadLine()
        {
            if (nextLineIndex != _rowsCount)
            {
                var cells = from cell in _rows
                            .ElementAt(nextLineIndex)
                            .Elements<TableCell>()
                            select cell.InnerText;

                nextLineIndex++;

                return new LineElements(cells.ToList());
            }
            else
            {
                return null;
            }
        }

        public override void CloseFile()
            => _document.Close();
    }
}
