using System;
using System.Collections.Generic;
using System.Linq;

using RailwaySimulatorProtocol_Packet.Records.InformationPart.Objects;
using RailwaySimulatorProtocol_Packet.Records.InformationPart.SettingParameters;

namespace RailwaySimulatorProtocol_Packet.Records.InformationPart.SettingsParameters.Objects.ResetSettings
{
    /// <summary>
    /// Responsible for resetting the state of objects.
    /// </summary>
    /// <remarks>
    /// *For more information see base classes <see cref="ObjectRecord"/> : <see cref="SettingParametersRecord"/> : <see cref="InformationRecord"/> : <see cref="Record"/>.
    /// </remarks>
    public class Reset : ObjectRecord
    {
        public override RecordTag Tag => RecordTag.Reset;

        public override List<byte> Bytes => base.Bytes.Concat(
            FormBytes(
                BitConverter.GetBytes(Length)
            )
        ).ToList();
    }
}
