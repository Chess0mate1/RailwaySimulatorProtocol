namespace DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects.Dynamic
{
    [ToString]
    public class Wagon : RailwayObject
    {
        public string Type { get; set; }

        public double Length { get; set; }
        public double Base { get; set; }
        public double CartBase { get; set; }

        public string WagonModelName { get; set; }
        public string CartName { get; set; }

        public bool Destroyed { get; set; }
    }
}
