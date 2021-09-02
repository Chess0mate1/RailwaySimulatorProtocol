using System;
using System.Collections.Generic;
using System.Linq;

namespace RailwaySimulatorProtocol_Packet.Records.InformationPart.SettingParameters.StateSetting.StateSettings
{
    /// <summary>
    /// Contains all time of year states
    /// </summary>
    public enum TimeOfYearState
    {
        Summer = 0,
        Winter = 1
    }

    /// <summary>
    /// Responsible for the state of time of year.
    /// </summary>
    /// <remarks>
    /// *For more information see base classes <see cref="StateSettingRecord"/> : <see cref="SettingParametersRecord"/> : <see cref="InformationRecord"/> : <see cref="Record"/>.
    /// </remarks>
    public class TimeOfYearRecord : StateSettingRecord
    {
        /// <summary>
        /// Creates <paramref name="TimeOfYearRecord"/> and set <paramref name="TimeOfYearState"/>.
        /// </summary>
        public TimeOfYearRecord(TimeOfYearState timeOfYear)
        {
            TimeOfYear = timeOfYear;
        }

        public override RecordTag Tag => RecordTag.TimeOfYear;

        /// <summary>
        /// Returns state of time of year
        /// </summary>
        public TimeOfYearState TimeOfYear { get; set; }

        public override uint Length => base.Length + CalculateLength(
            BitConverter.GetBytes((uint)TimeOfYear)
        );

        public override List<byte> Bytes => base.Bytes.Concat(
            FormBytes(
                BitConverter.GetBytes((uint)TimeOfYear)
            )
        ).ToList();
    }
}
