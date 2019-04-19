using System.Collections.Generic;
using System.Data.Entity;

namespace CityPhonesApp
{
    public class DataInitializer : CreateDatabaseIfNotExists<CityContext>
    {
        private List<City> cities;

        public DataInitializer()
        {
            cities = new List<City>();
            cities.Add(new City {
                Name = "Нур-Султан",
                Number = 7172
            });
            cities.Add(new City
            {
                Name = "Алматы",
                Number = 727
            });
            cities.Add(new City
            {
                Name = "Павлодар",
                Number = 7182
            });
            cities.Add(new City
            {
                Name = "Петропавловск",
                Number = 7152
            });
            cities.Add(new City
            {
                Name = "Костанай",
                Number = 7142
            });
            cities.Add(new City
            {
                Name = "Караганда",
                Number = 7212
            });
            cities.Add(new City
            {
                Name = "Кызылорда",
                Number = 72422
            });
            cities.Add(new City
            {
                Name = "Шымкент",
                Number = 7252
            });
            cities.Add(new City
            {
                Name = "Актау",
                Number = 7292
            });
            cities.Add(new City
            {
                Name = "Уральск",
                Number = 7112
            });
            cities.Add(new City
            {
                Name = "Тараз",
                Number = 7262
            });
            cities.Add(new City
            {
                Name = "Талдыкорган",
                Number = 7282
            });
            cities.Add(new City
            {
                Name = "Усть-Каменогорск",
                Number = 7232
            });
            cities.Add(new City
            {
                Name = "Атырау",
                Number = 7122
            });
            cities.Add(new City
            {
                Name = "Кокшетау",
                Number = 7162
            });
            cities.Add(new City
            {
                Name = "Актобе",
                Number = 7132
            });
        }

        protected override void Seed(CityContext context)
        {
            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}