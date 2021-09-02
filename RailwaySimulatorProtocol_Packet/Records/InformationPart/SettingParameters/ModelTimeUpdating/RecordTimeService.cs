using System.Collections.Generic;

using RailwaySimulatorProtocol_Packet.Records.InformationPart.SettingParameters.StateSetting.StateSettings;

using static System.DateTime;

namespace RailwaySimulatorProtocol_Packet.Records.InformationPart.SettingParameters.ModelTimeUpdating
{
    /// <summary>
    /// Service for subscribing and notifying <paramref name="SettingParametersRecord"/>s about <paramref name="ModelTime"/>.
    /// </summary>
    public static class RecordTimeService
    {
        // SettingParametersRecords-subscribers for updating model time
        private static List<SettingParametersRecord> _subscribers = new();

        /// <summary>
        /// Returns current time in milliseconds of computer.
        /// </summary>
        public static double CurrentTimeInMilliseconds =>
            Now.TimeOfDay.TotalMilliseconds;

        /// <summary>
        /// Add to a notification about сhanging in <paramref name="ModelTime"/>.
        /// </summary>
        /// <param name="subscriberRecord"><paramref name="SettingParametersRecord"/>s-subscribers.</param>
        public static void AddSubscriber(SettingParametersRecord subscriberRecord)
        {
            _subscribers.Add(subscriberRecord);
        }

        /// <summary>
        /// Notify all nested <see cref="SettingParametersRecord"/>about сhanging in <paramref name="ModelTime"/>.
        /// </summary>
        /// <param name="publisher"><paramref name="TimeOfDayRecord"/>-notifier.</param>
        public static void NotifySubscriber(TimeOfDayRecord publisher)
        {
            foreach (SettingParametersRecord subscriber in _subscribers)
                subscriber.UpdateModelTime(publisher);
        }
    }
}
