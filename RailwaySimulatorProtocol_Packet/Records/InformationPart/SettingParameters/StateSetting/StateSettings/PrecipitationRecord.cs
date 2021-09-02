using System;
using System.Collections.Generic;
using System.Linq;

namespace RailwaySimulatorProtocol_Packet.Records.InformationPart.SettingParameters.StateSetting.StateSettings
{
    /// <summary>
    /// Contains all precipitation states.
    /// </summary>
    public enum PrecipitationState
    {
        No = 0,
        Yes = 1
    }

    /// <summary>
    /// Responsible for the state of precipitation.
    /// </summary>
    /// <remarks>
    /// *For more information see base classes <see cref="StateSettingRecord"/> : <see cref="SettingParametersRecord"/> : <see cref="InformationRecord"/> : <see cref="Record"/>.
    /// </remarks>
    public class PrecipitationRecord : SettingParametersRecord
    {
        /// <summary>
        /// Creates <paramref name="PrecipitationRecord"/> and set <paramref name="PrecipitationState"/>.
        /// </summary>
        public PrecipitationRecord(PrecipitationState isPrecipitationOn)
        {
            IsPrecipitationOn = isPrecipitationOn;
        }

        public override RecordTag Tag => RecordTag.Precipitation;

        /// <summary>
        /// Returns state of precipitation.
        /// </summary>
        public PrecipitationState IsPrecipitationOn { get; set; }

        public override uint Length => base.Length + CalculateLength(
            BitConverter.GetBytes((uint)IsPrecipitationOn)
        );

        public override List<byte> Bytes => base.Bytes.Concat(
            FormBytes(
                BitConverter.GetBytes((uint)IsPrecipitationOn)
            )
        ).ToList();
    }
}
