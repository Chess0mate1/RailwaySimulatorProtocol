namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects.Static
{
    [ToString]
    public class Rail: RailwayObject
    {
        public int RearVertexId { get; set; }
        public int FrontVertexId { get; set; }


        public int? RearRailId { get; set; }
        public int? FrontRailId { get; set; }

        public int? LeftRailId { get; set; }
        public int? RightRailId { get; set; }


        public int? RearSwitchId { get; set; }
        public int? FrontSwitchId { get; set; }
    }
}
