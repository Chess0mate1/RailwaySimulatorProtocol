using RailwaySimulatorProtocol_Packet.Connection;
using RailwaySimulatorProtocol_Packet.PacketInfo;

namespace RailwaySimulatorProtocol_Packet.PacketSending
{
    /// <summary>
    /// Contains method for <paramref name="Packet"/> sending
    /// </summary>
    public static class PacketSender
    {
        /// <summary>
        /// Send <paramref name="Packet"/> to Server
        /// </summary>
        /// <param name="packet"><paramref name="Packet"/> for sending</param>
        public static void Send(Packet packet)
        {
            _ = ConnectionService.SendMessage(
                packet.Bytes.ToArray()
            );
        }
    }
}
