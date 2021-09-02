using System;
using System.Collections.Generic;
using System.Linq;

namespace RailwaySimulatorProtocol_Packet.Records.TransportPart.Header
{
    /// <inheritdoc/>
    /// <summary>
    /// <para>Responsible for the <paramref name="TransportHeader"/> of the <see cref="Packet"/>.</para>
    /// </summary>
    /// <remarks>
    /// *For more information see base classes <see cref="TransportRecord"/> : <see cref="Record"/>
    /// </remarks>
    public class TransportHeaderRecord : TransportRecord
    {
        public override RecordTag Tag => RecordTag.TransportHeader;
        public override uint Length => base.Length + CalculateLength(
            BitConverter.GetBytes(LocalTime)
        );

        public override List<byte> Bytes => base.Bytes.Concat(
            FormBytes(
                BitConverter.GetBytes(Length),
                BitConverter.GetBytes(LocalTime)
            )
        ).ToList();
    }
}
