namespace WeatherApp.Entity
{
    public class City
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public string Country { get; set; } 

        public Weather weather { get; set; }
        public IList<Forecast>? Forecasts { get; set; }
    }
}
