namespace WeatherApp.Entity
{
    public class Weather
    {
        public int Id { get; set; } 
        public float Temperature { get; set; }
        public int Humidity { get; set; } 
        public float WindSpeed { get; set; } 
        public string Condition { get; set; }
        public int CityId { get;  set; }
        public City? City { get; set; }
    }
}
