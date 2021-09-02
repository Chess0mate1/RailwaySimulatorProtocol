using System;
using System.Collections.Generic;
using System.Linq;

using RailwaySimulatorProtocol_Packet.Patterns.PubSub;
using RailwaySimulatorProtocol_Packet.Records.InformationPart.SettingParameters.ModelTimeUpdating;

namespace RailwaySimulatorProtocol_Packet.Records.InformationPart.SettingParameters.StateSetting.StateSettings
{
    /// <summary>
    /// Responsible for the changing time of day (new <paramref name="ModelTime"/>).
    /// </summary>
    /// <remarks>
    /// *For more information see base classes <see cref="StateSettingRecord"/> : <see cref="SettingParametersRecord"/> : <see cref="InformationRecord"/> : <see cref="Record"/>
    /// </remarks>
    public class TimeOfDayRecord : SettingParametersRecord, IModelTimePub
    {
        // Contains time of day in hours (0-24)
        private double _timeOfDay;

        /// <summary>
        /// Creates <paramref name="TimeOfDayRecord"/> and set <paramref name="TimeOfDayState"/>.
        /// </summary>
        public TimeOfDayRecord(double timeOfDay)
        {
            TimeOfDay = timeOfDay;
        }

        public override RecordTag Tag => RecordTag.TimeOfDay;

        /// <summary>
        /// Set time of day in hours (0-24) and returns result
        /// </summary>
        public double TimeOfDay
        {
            get => _timeOfDay;
            set
            {
                if (0 <= value && value <= 24)
                {
                    _timeOfDay = value;
                    NotifySurvice();
                }
            }
        }

        public override uint Length => base.Length + CalculateLength(
            BitConverter.GetBytes((double)TimeOfDay)
        );

        public override List<byte> Bytes => base.Bytes.Concat(
            FormBytes(
                BitConverter.GetBytes((double)TimeOfDay)
            )
        ).ToList();

        public void NotifySurvice()
        {
            RecordTimeService.NotifySubscriber(this);
        }
    }
}
