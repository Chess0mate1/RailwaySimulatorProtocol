using System;
using System.Collections.Generic;
using System.Linq;

namespace RailwaySimulatorProtocol_Packet.Records.InformationPart.SettingParameters.StateSetting.StateSettings
{
    /// <summary>
    /// Contains all fog states.
    /// </summary>
    public enum FogState
    {
        No = 0,
        Yes = 1
    }

    /// <summary>
    /// Responsible for the state of fog.
    /// </summary>
    /// <remarks>
    /// *For more information see base classes <see cref="StateSettingRecord"/> : <see cref="SettingParametersRecord"/> : <see cref="InformationRecord"/> : <see cref="Record"/>.
    /// </remarks>
    public class FogRecord : SettingParametersRecord
    {
        /// <summary>
        /// Creates <paramref name="FogRecord"/> and set <paramref name="FogState"/>.
        /// </summary>
        public FogRecord(FogState isFogOn)
        {
            IsFogOn = isFogOn;
        }

        public override RecordTag Tag => RecordTag.Fog;

        /// <summary>
        /// Returns state of fog.
        /// </summary>
        public FogState IsFogOn { get; set; }

        public override uint Length => base.Length + CalculateLength(
            BitConverter.GetBytes((uint)IsFogOn)
        );

        public override List<byte> Bytes => base.Bytes.Concat(
            FormBytes(
                BitConverter.GetBytes((uint)IsFogOn)
            )
        ).ToList();
    }
}
