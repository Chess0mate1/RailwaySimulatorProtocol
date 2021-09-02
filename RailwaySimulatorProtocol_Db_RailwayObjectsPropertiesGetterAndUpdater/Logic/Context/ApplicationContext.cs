using DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects.Dynamic;
using DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects.Static;

using Microsoft.EntityFrameworkCore;

namespace DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Context
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Vertex> Vertices { get; set; }
        public DbSet<Rail> Rails { get; set; }
        public DbSet<Switch> Switches { get; set; }
        public DbSet<Semaphore> Semaphores { get; set; }
        public DbSet<Retarder> Retarders { get; set; }
        public DbSet<Wagon> Wagons { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=RailwayObjectsPropertiesGetterAndUpdater;Trusted_Connection=True;"
            );
        }
    }
}
