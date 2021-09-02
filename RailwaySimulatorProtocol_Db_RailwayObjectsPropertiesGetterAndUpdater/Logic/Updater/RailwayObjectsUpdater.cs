using DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Context;

namespace DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Updater
{
    internal abstract class RailwayObjectsUpdater
    {
        protected ApplicationContext _context = new();

        public void Update()
        {
            Modify();

            _context.BulkSaveChanges();
        }

        protected abstract void Modify();
    }
}
