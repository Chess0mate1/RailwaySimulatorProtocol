using System.Threading.Tasks;

using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Updater.Dynamic.Dynamics;
using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Updater.Static.Statics;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.FullUpdater
{
    public class FullDbRailwayObjectsUpdater
    {
        public async Task UpdateAsync()
        {
            VerticesUpdater verticesUpdater = new();
            RailsUpdater railsUpdater = new();
            SwitchesUpdater switchesUpdater = new();
            RetardersUpdater retardersUpdater = new();
            SemaphoresUpdater semaphoresUpdater = new();
            WagonsUpdater wagonsUpdater = new();

            Task[] modificationsTasks =
            {
                Task.Run(() => verticesUpdater.Update()),
                Task.Run(() => railsUpdater.Update()),
                Task.Run(() => switchesUpdater.Update()),
                Task.Run(() => retardersUpdater.Update()),
                Task.Run(() => semaphoresUpdater.Update()),
                Task.Run(() => wagonsUpdater.Update()),
            };

            await Task.WhenAll(modificationsTasks);
        }
    }
}
