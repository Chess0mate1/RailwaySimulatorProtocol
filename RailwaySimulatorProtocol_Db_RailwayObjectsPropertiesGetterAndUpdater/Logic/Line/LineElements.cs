using System.Collections;
using System.Collections.Generic;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Line
{
    internal class LineElements : IEnumerable<string>
    {
        private readonly List<string> _linesElements = new();

        public LineElements() { }

        public LineElements(IEnumerable<string> elements)
        {
            _linesElements.AddRange(elements);
        }


        public IEnumerator<string> GetEnumerator()
        {
            foreach (var element in _linesElements)
                yield return element;
        }

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();


        public int Length => _linesElements.Count;

        public string this[int index] => _linesElements[index];
    }
}
