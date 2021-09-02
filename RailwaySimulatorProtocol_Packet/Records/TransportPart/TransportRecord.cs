using RailwaySimulatorProtocol_Packet.Records.InformationPart.SettingParameters.ModelTimeUpdating;

namespace RailwaySimulatorProtocol_Packet.Records.TransportPart
{
    /// <summary>
    /// <para>Main class of a <paramref name="TransportRecord"/>.</para>
    /// <para>Contains <paramref name="LocalTime"/>.</para>
    /// </summary>
    /// <remarks>
    /// *For more information see base classes <see cref="Record"/>
    /// </remarks>
    public abstract class TransportRecord : Record
    {
        /// <summary>
        /// Returns the <paramref name="LocalTime"/> of the computer
        /// </summary>
        public double LocalTime => RecordTimeService.CurrentTimeInMilliseconds;
    }
}
