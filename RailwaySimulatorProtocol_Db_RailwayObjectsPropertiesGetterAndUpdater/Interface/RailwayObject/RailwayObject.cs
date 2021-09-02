using System.ComponentModel.DataAnnotations.Schema;

namespace DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects
{
    public enum RailwayObjectType
    {
        Vertix,
        Rail,
        Switch,
        Semaphore,
        Retarder,

        Wagon
    }

    public abstract class RailwayObject
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
    }
}
