using System;
using System.Collections.Generic;
using System.Linq;

namespace RailwaySimulatorProtocol_Packet.Records.InformationPart.SettingParameters.StateSetting.StateSettings
{
    /// <summary>
    /// Contains all sky states.
    /// </summary>
    public enum SkyState
    {
        Overcust = 0,
        Clear = 1
    }

    /// <summary>
    /// Responsible for the state of sky.
    /// </summary>
    /// <remarks>
    /// *For more information see base classes <see cref="StateSettingRecord"/> : <see cref="SettingParametersRecord"/> : <see cref="InformationRecord"/> : <see cref="Record"/>.
    /// </remarks>
    public class SkyRecord : SettingParametersRecord
    {
        /// <summary>
        /// Creates <paramref name="SkyRecord"/> and set <paramref name="SkyState"/>.
        /// </summary>
        public SkyRecord(SkyState sky)
        {
            Sky = sky;
        }

        public override RecordTag Tag => RecordTag.Sky;

        /// <summary>
        /// Returns state of sky.
        /// </summary>
        public SkyState Sky { get; set; }

        public override uint Length => base.Length + CalculateLength(
            BitConverter.GetBytes((double)Sky)
        );

        public override List<byte> Bytes => base.Bytes.Concat(
            FormBytes(
                BitConverter.GetBytes((double)Sky)
            )
        ).ToList();
    }
}
