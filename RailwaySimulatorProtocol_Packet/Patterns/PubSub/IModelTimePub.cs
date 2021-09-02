using RailwaySimulatorProtocol_Packet.Records.InformationPart.SettingParameters;

namespace RailwaySimulatorProtocol_Packet.Patterns.PubSub
{
    /// <summary>
    /// Contain method for notyfication obout <see cref="SettingParametersRecord.ModelTime"/> for all <see cref="Record"/>s-subscribers.
    /// <list type="bullet">
    /// <item>
    /// <term><paramref name="UpdateModelTime"/></term>
    /// <description>Notify obout <see cref="SettingParametersRecord.ModelTime"/> for all <see cref="Record"/>s-subscribers.</description>
    /// </item>
    /// </list>
    /// </summary>
    public interface IModelTimePub
    {
        /// <summary>
        /// Notify obout <see cref="SettingParametersRecord.ModelTime"/>.
        /// </summary>
        public void NotifySurvice();
    }
}
