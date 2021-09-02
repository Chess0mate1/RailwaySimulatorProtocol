using RailwaySimulatorProtocol_Packet.Records.InformationPart.SettingParameters;
using RailwaySimulatorProtocol_Packet.Records.InformationPart.SettingParameters.StateSetting.StateSettings;

namespace RailwaySimulatorProtocol_Packet.Patterns.PubSub
{
    /// <summary>
    /// Contain method for updating <see cref="SettingParametersRecord.ModelTime"/>.
    /// <list type="bullet">
    /// <item>
    /// <term><paramref name="UpdateModelTime"/></term>
    /// <description>Update <see cref="SettingParametersRecord.ModelTime"/>.</description>
    /// </item>
    /// </list>
    /// </summary>
    public interface IModelTimeSubscriber
    {
        /// <summary>
        /// Update <see cref="SettingParametersRecord.ModelTime"/>.
        /// </summary>
        /// <param name="subject">Record-notifier.</param>
        public void UpdateModelTime(TimeOfDayRecord subject);
    }
}
