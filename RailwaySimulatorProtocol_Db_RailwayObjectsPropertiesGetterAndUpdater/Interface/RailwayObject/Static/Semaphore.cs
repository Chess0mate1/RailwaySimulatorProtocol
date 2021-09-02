namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects.Static
{
    [ToString]
    public class Semaphore : RailwayObject
    {
        public string Name { get; set; }

        public int VertexId { get; set; }
    }
}
