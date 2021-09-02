using System.Collections;
using System.Collections.Generic;
using System.Linq;

using RailwaySimulatorProtocol_Packet.Patterns.Observer;
using RailwaySimulatorProtocol_Packet.Records;
using RailwaySimulatorProtocol_Packet.Records.InformationPart.Format;
using RailwaySimulatorProtocol_Packet.Records.InformationPart.Objects;
using RailwaySimulatorProtocol_Packet.Records.InformationPart.SettingParameters;
using RailwaySimulatorProtocol_Packet.Records.TransportPart.Format;
using RailwaySimulatorProtocol_Packet.Records.TransportPart.Header;

namespace RailwaySimulatorProtocol_Packet.PacketInfo
{
    /// <summary>
    /// <para>Main class of a <paramref name="Packet"/>.</para>
    /// <para>Contains methods for creating, forming and operating a <paramref name="Packet"/> and nested <see cref="Record"/>s.</para> 
    /// </summary>
    public class Packet : IPacketLengthSubject, IEnumerable<Record>
    {
        // contains nested records in Packet.
        private List<Record> _records = new();

        /// <summary>
        /// <para>Basic constructor for <paramref name="Packet"/>.</para>
        /// <para>Creates a base <paramref name="Packet"/>.</para>
        /// </summary>
        public Packet()
        {
            _records.Add(new TransportFormatRecord());
            _records.Add(new TransportHeaderRecord());
            _records.Add(new InformationFormatRecord());
            Notify();
        }

        /// <summary>
        /// Summarize the <see cref="Record.Length"/> of all <see cref="Record"/>s and return resilt.
        /// </summary>
        public uint Length => (uint)_records.Sum(
            record => record.Length
        );

        /// <summary>
        /// Select all <see cref="Record.Bytes"/> from nested <paramref name="Record"/>s and return result.
        /// </summary>
        public virtual List<byte> Bytes => _records.SelectMany(
            record => record.Bytes
         ).ToList();

        public void Attach(params SettingParametersRecord[] observers)
        {
            _records.AddRange(observers);
            Notify();
        }

        // TODO: Realisation (now not need)
        public void Dettach(params SettingParametersRecord[] observers)
        {
            //throw new NotImplementedException();
        }

        public void Notify()
        {
            foreach (Record record in _records)
                record.UpdatePacketLength(this);
        }

        public IEnumerator<Record> GetEnumerator() => _records.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <summary>
        /// Find <paramref name="Record"/> by <paramref name="Tag"/> and returns result.
        /// </summary>
        /// <param name="tag">The <paramref name="Tag"/> of the <paramref name="Record"/> to find.</param>
        /// <returns>Required <paramref name="Record"/>.</returns>
        /// <remarks>*Only for non <see cref="ObjectRecord"/>s.</remarks>
        public Record this[RecordTag tag] => (from record in _records
                                              where (!(record is ObjectRecord) &&
                                                      (record.Tag == tag))
                                              select record).First();

        /// <summary>
        /// Find <paramref name="ObjectRecord"/> by <paramref name="Tag"/> and <paramref name="Id"/> and returns result.
        /// </summary>
        /// <param name="tag">The <paramref name="Tag"/> of the <paramref name="Record"/> to find.</param>
        /// <param name="id">The <paramref name="Id"/> of the <paramref name="Record"/> to find.</param>
        /// <returns>Required <paramref name="Record"/>.</returns>
        /// <remarks>*Only for <see cref="ObjectRecord"/>s.</remarks>
        public ObjectRecord this[RecordTag tag, uint id]
        {
            get
            {
                List<ObjectRecord> objectRecords = (List<ObjectRecord>)(from record in _records
                                                                        where (record is ObjectRecord &&
                                                                               record.Tag == tag)
                                                                        select record);

                ObjectRecord requiredRecord = (from record in objectRecords
                                               where (record.Id == id)
                                               select record).First();

                return requiredRecord;
            }
        }
    }
}
