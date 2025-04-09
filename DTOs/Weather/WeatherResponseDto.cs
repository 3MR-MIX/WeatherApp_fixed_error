using System.ComponentModel.DataAnnotations;

namespace WeatherApp.DTOs.Weather
{
    public class WeatherResponseDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public float Temperature { get; set; }

        [Required]
        public int Humidity { get; set; }

        [Required]
        public float WindSpeed { get; set; }

        [Required]
        public string Condition { get; set; }
    }
}
