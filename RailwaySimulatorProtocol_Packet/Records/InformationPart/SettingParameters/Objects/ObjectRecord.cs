using System;
using System.Collections.Generic;
using System.Linq;

using RailwaySimulatorProtocol_Packet.Records.InformationPart.SettingParameters;

namespace RailwaySimulatorProtocol_Packet.Records.InformationPart.Objects
{
    /// <summary>
    /// <para>Main class of a <paramref name="ObjectRecord"/>.</para>
    /// </summary>
    /// <remarks>
    /// *For more information see base classes <see cref="SettingParametersRecord"/> : <see cref="InformationRecord"/> : <see cref="Record"/>
    /// </remarks>
    public abstract class ObjectRecord : SettingParametersRecord
    {
        /// <summary>
        /// Return id of all <paramref name="ObjectRecord"/>.
        /// </summary>
        public virtual uint Id { get; }

        public override uint Length => base.Length + CalculateLength(
            BitConverter.GetBytes(Id)
        );

        public override List<byte> Bytes => base.Bytes.Concat(
            FormBytes(
                BitConverter.GetBytes(Length),
                BitConverter.GetBytes(Id)
            )
        ).ToList();
    }
}
