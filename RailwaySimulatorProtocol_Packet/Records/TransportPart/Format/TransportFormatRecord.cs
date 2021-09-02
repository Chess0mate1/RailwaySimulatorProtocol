using System;
using System.Collections.Generic;
using System.Linq;

using RailwaySimulatorProtocol_Packet.PacketInfo;

namespace RailwaySimulatorProtocol_Packet.Records.TransportPart.Format
{
    /// <summary>
    /// <para>Responsible for the <paramref name="TransportFormat"/> of the <see cref="Packet"/>.</para>
    /// </summary>
    /// <remarks>
    /// *For more information see base classes <see cref="TransportRecord"/> : <see cref="Record"/>
    /// </remarks>
    public class TransportFormatRecord : TransportRecord
    {
        public override RecordTag Tag => RecordTag.TransportFormat;

        public override List<byte> Bytes => base.Bytes.Concat(
            FormBytes(
                BitConverter.GetBytes(PacketLength)
            )
        ).ToList();
    }
}
