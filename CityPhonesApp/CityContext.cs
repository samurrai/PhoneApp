namespace CityPhonesApp
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CityContext : DbContext
    {
        public CityContext()
            : base("name=CityContext")
        {
            Database.SetInitializer(new DataInitializer());
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
    }
}