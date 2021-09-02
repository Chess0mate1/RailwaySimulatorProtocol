using System;
using System.Collections.Generic;
using System.Linq;

using RailwaySimulatorProtocol_Packet.Patterns.PubSub;
using RailwaySimulatorProtocol_Packet.Records.InformationPart.SettingParameters.ModelTimeUpdating;
using RailwaySimulatorProtocol_Packet.Records.InformationPart.SettingParameters.StateSetting.StateSettings;

namespace RailwaySimulatorProtocol_Packet.Records.InformationPart.SettingParameters
{
    /// <summary>
    /// <para>Main class of a <paramref name="SettingParametersRecord"/>.</para>
    /// <para>Contains <paramref name="ModelTime"/>.</para>
    /// </summary>
    /// <remarks>
    /// *For more information see base classes <see cref="InformationRecord"/> : <see cref="Record"/>
    /// </remarks>
    public abstract class SettingParametersRecord : InformationRecord, IModelTimeSubscriber
    {
        protected double _hoursDifference;

        /// <summary>
        /// <para>Basic constructor for <paramref name="SettingParametersRecord"/>.</para>
        /// <para>Signs for a notification of changing <paramref name="ModelTime"/>.</para>
        /// </summary>
        public SettingParametersRecord()
        {
            RecordTimeService.AddSubscriber(this);
        }

        /// <summary>
        /// Returns the internal time of model
        /// </summary>
        public double ModelTime =>
            RecordTimeService.CurrentTimeInMilliseconds - _hoursDifference;

        public override uint Length => base.Length + CalculateLength(
            BitConverter.GetBytes(ModelTime)
        );

        public override List<byte> Bytes => base.Bytes.Concat(
            FormBytes(
                BitConverter.GetBytes(Length),
                BitConverter.GetBytes(ModelTime)
            )
        ).ToList();

        public void UpdateModelTime(TimeOfDayRecord subject)
        {
            double newModelTimeHours = TimeSpan.FromHours(
                subject.TimeOfDay
            ).TotalMilliseconds;

            double newHoursDifference = ModelTime - newModelTimeHours;

            _hoursDifference = newHoursDifference;
        }
    }
}
