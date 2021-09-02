namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects.Static
{
    [ToString]
    public class Switch : RailwayObject
    {
        public int RwNumber { get; set; }


        public int RearRailId { get; set; }

        public int LeftRailId { get; set; }
        public int RightRailId { get; set; }
    }
}
