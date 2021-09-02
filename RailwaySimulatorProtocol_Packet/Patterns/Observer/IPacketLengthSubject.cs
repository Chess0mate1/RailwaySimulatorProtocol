using RailwaySimulatorProtocol_Packet.PacketInfo;
using RailwaySimulatorProtocol_Packet.Records;
using RailwaySimulatorProtocol_Packet.Records.InformationPart.SettingParameters;

namespace RailwaySimulatorProtocol_Packet.Patterns.Observer
{
    /// <summary>
    /// Contains methods of attaching, dettaching to a notification about сhanging in <see cref="Packet.Length"/>
    /// <list type="bullet">
    /// <item>
    /// <term><paramref name="Attach"/></term>
    /// <description><see cref="Record"/> subscription</description>
    /// </item>
    /// <item>
    /// <term><paramref name="Dettach"/></term>
    /// <description><see cref="Record"/> unsubscribe</description>
    /// </item>
    /// <item>
    /// <term><paramref name="Notify"/></term>
    /// <description><see cref="Record"/> notification</description>
    /// </item>
    /// </list>
    /// </summary>
    public interface IPacketLengthSubject
    {
        /// <summary>
        /// Attach to a notification about сhanging in <see cref="Packet.Length"/>
        /// </summary>
        /// <param name="observers">New <paramref name="InformationRecord"/>s-subscribers.</param>
        public void Attach(params SettingParametersRecord[] observers);

        /// <summary>
        /// Dettach to a notification about сhanging in <see cref="Packet.Length"/>
        /// </summary>
        /// <param name="observers"><paramref name="InformationRecord"/>s-unsubscribers.</param>
        public void Dettach(params SettingParametersRecord[] observers);

        /// <summary>
        /// Notify all nested <see cref="Record"/>about сhanging in <see cref="Packet.Length"/>
        /// </summary>
        public void Notify();
    }
}
