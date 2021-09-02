using System;
using System.Collections.Generic;
using System.Linq;

namespace RailwaySimulatorProtocol_Packet.Records.InformationPart.Format
{
    /// <summary>
    /// <para>Responsible for the <paramref name="InformationFormat"/> of the <see cref="Packet"/>.</para>
    /// </summary>
    /// <remarks>
    /// *For more information see base classes <see cref="InformationRecord"/> : <see cref="Record"/>
    /// </remarks>
    class InformationFormatRecord : InformationRecord
    {
        public override RecordTag Tag => RecordTag.InformationFormat;

        public override List<byte> Bytes => base.Bytes.Concat(
            FormBytes(
                BitConverter.GetBytes(PacketLength)
            )
        ).ToList();
    }
}