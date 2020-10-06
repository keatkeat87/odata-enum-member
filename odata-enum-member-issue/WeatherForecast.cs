using System;
using System.Runtime.Serialization;

namespace odata_route_constraint_issue
{
    [DataContract]
    public enum Status { 
        [EnumMember(Value = "Sold out")]
        SoldOut
    }
    public class WeatherForecast
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public Status status { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
