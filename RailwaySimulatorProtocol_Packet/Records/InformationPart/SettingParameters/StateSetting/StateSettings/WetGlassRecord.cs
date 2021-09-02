using System;
using System.Collections.Generic;
using System.Linq;

namespace RailwaySimulatorProtocol_Packet.Records.InformationPart.SettingParameters.StateSetting.StateSettings
{
    /// <summary>
    /// Contains all wet glass states
    /// </summary>
    public enum WetGlassState : uint
    {
        No = 0,
        Yes = 1
    }

    /// <summary>
    /// Responsible for the state of wet glass.
    /// </summary>
    /// <remarks>
    /// *For more information see base classes <see cref="StateSettingRecord"/> : <see cref="SettingParametersRecord"/> : <see cref="InformationRecord"/> : <see cref="Record"/>.
    /// </remarks>
    public class WetGlassRecord : StateSettingRecord
    {
        /// <summary>
        /// Creates <paramref name="WetGlassRecord"/> and set <paramref name="WetGlassState"/>.
        /// </summary>
        public WetGlassRecord(WetGlassState state)
        {
            State = state;
        }

        public override RecordTag Tag => RecordTag.WetGlass;

        /// <summary>
        /// Returns state of wet glass
        /// </summary>
        public WetGlassState State { get; }

        public override uint Length => base.Length + CalculateLength(
            BitConverter.GetBytes((uint)State)
        );

        public override List<byte> Bytes => base.Bytes.Concat(
            FormBytes(
                BitConverter.GetBytes((uint)State)
            )
        ).ToList();
    }
}
