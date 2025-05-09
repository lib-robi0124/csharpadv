using Domain.Enums;

namespace Domain.Models
{
    public class DriverAssignment
    {
        public Driver Driver { get; set; } // Navigation property to the Driver entity
        public DriverShift Shift { get; set; } // e.g., Morning, Afternoon, Night, DayOff
    }
}
