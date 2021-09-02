using RailwaySimulatorProtocol_Packet.PacketInfo;
using RailwaySimulatorProtocol_Packet.Records;

namespace RailwaySimulatorProtocol_Packet.Patterns
{
    /// <summary>
    /// Contain method for updating <see cref="Packet.Length"/> for all <see cref="Record"/>s-subscribers.
    /// <list type="bullet">
    /// <item>
    /// <term><paramref name="UpdatePacketLength"/></term>
    /// <description>Update <see cref="Packet.Length"/> for all <see cref="Record"/>s-subscribers.</description>
    /// </item>
    /// </list>
    /// </summary>
    public interface IPacketLengthObserver
    {
        /// <summary>
        /// Update <see cref="Packet.Length"/> for all <see cref="Record"/>s-subscribers
        /// </summary>
        /// <param name="subject">Packet-notifier.</param>
        public void UpdatePacketLength(Packet subject);
    }
}
