using System;
using System.Collections.Generic;
using System.Linq;

namespace RailwaySimulatorProtocol_Packet.Records.InformationPart.SettingParameters.StateSetting.StateSettings
{
    /// <summary>
    /// Contains all station flag states.
    /// </summary>
    public enum StationFlagState
    {
        Main = 0,
        Additional = 1
    }

    /// <summary>
    /// Responsible for the state of station flag.
    /// </summary>
    /// <remarks>
    /// *For more information see base classes <see cref="StateSettingRecord"/> : <see cref="SettingParametersRecord"/> : <see cref="InformationRecord"/> : <see cref="Record"/>.
    /// </remarks>
    public class StationRecord : SettingParametersRecord
    {
        /// <summary>
        /// Creates <paramref name="StationRecord"/> and set <paramref name="StationFlagState"/>.
        /// </summary>
        public StationRecord(StationFlagState flag)
        {
            Flag = flag;
        }

        public override RecordTag Tag => RecordTag.Station;

        /// <summary>
        /// Returns state of station flag.
        /// </summary>
        public StationFlagState Flag { get; set; }

        public override uint Length => base.Length + CalculateLength(
            BitConverter.GetBytes((uint)Flag)
        );

        public override List<byte> Bytes => base.Bytes.Concat(
            FormBytes(
                BitConverter.GetBytes((uint)Flag)
            )
        ).ToList();
    }
}
