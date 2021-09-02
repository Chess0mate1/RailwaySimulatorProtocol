using System;
using System.Collections.Generic;
using System.Linq;

using RailwaySimulatorProtocol_Packet.PacketInfo;
using RailwaySimulatorProtocol_Packet.Patterns;

namespace RailwaySimulatorProtocol_Packet.Records
{
    /// <summary>
    /// Contains all record's tags
    /// </summary>
    public enum RecordTag : uint
    {
        TransportFormat = 0x20574C54,
        TransportHeader = 0x1,

        InformationFormat = 0x20574C52,

        CreateWagon = 0x2001,
        DestroyWagon = 0x2004,
        WagonPosition2D = 0x2005,
        FreezeWagon = 0x2006,
        WagonPosition3D = 0x2007,

        TurnountLateralMove = 0x3001,
        TurnountForwardMove = 0x3002,
        Retarder = 0x5001,
        TrafficLight = 0x6001,

        WatcherPos = 0x7001,
        WatcherPosVel = 0x7002,
        AddWatcherToWagon = 0x7004,
        WatcherfovX = 0x7007, // fovX - shit name, ok....

        OnRetardersOnWheelsSound = 0x8001,
        OffRetardersOnWheelsSound = 0x8002,
        WagonsHeatingSound = 0x8003,

        Reset = 0x80001,

        TimeOfDay = 0x9001,
        Sky = 0x9002,
        Precipitation = 0x9003,
        Fog = 0x9004,
        TimeOfYear = 0x9005,
        WetGlass = 0x9006,
        Station = 0x9007
    }

    /// <summary>
    /// <para>Main class of a <paramref name="Record"/>.</para>
    /// <para>Contains <paramref name="Tag"/>, <paramref name="Length"/>, <paramref name="Bytes"/> method of updating info about <see cref="Packet.Length"/>.</para>
    /// </summary>
    public abstract class Record : IPacketLengthObserver
    {
        // length in bytes of uint property - Length
        private const uint LengthOfLength = 4;

        public void UpdatePacketLength(Packet subject)
        {
            PacketLength = subject.Length;
        }

        /// <summary>
        /// Returns <paramref name="Tag"/> of the <paramref name="Record"/>.
        /// </summary>
        public abstract RecordTag Tag { get; }

        /// <summary>
        /// Return length of all <paramref name="Record"/>s elements, included in <see cref="Packet"/>.
        /// </summary>
        public virtual uint Length => LengthOfLength + CalculateLength(
            BitConverter.GetBytes((uint)Tag)
        );

        /// <summary>
        /// Get bytes of all <paramref name="Record"/>'s elements, included in <see cref="Packet"/>.
        /// </summary>
        public virtual List<byte> Bytes => FormBytes(
            BitConverter.GetBytes((uint)Tag)
        );

        /// <summary>
        /// Length of Packet, in which record is
        /// </summary>
        protected uint PacketLength { get; set; }

        /// <summary>
        /// Summarize length of all Records elements, included in Packet and return result
        /// </summary>
        /// <param name="recordElementsBytes">Arrays of bytes of elements.</param>
        /// <returns>Full length of <paramref name="Record"/></returns>
        protected uint CalculateLength(params byte[][] recordElementsBytes)
        {
            return (uint)recordElementsBytes.Sum(
                 item => item.Length
            );
        }

        /// <summary>
        /// Form bytes of all <paramref name="Record"/>'s elements, included in <see cref="Packet"/>, and return result
        /// </summary>
        /// <param name="recordElementsBytes">Arrays of bytes of elements.</param>
        /// <returns>All formed  <paramref name="Record"/>'s bytes</returns>
        protected List<byte> FormBytes(params byte[][] recordElementsBytes)
        {
            if (!BitConverter.IsLittleEndian)
                ReverseBytes(recordElementsBytes);

            return recordElementsBytes.SelectMany(
                record => record
            ).ToList();

            void ReverseBytes(params byte[][] recordElementsBytes)
            {
                foreach (byte[] elementBytes in recordElementsBytes)
                    Array.Reverse(elementBytes);
            }
        }
    }
}
