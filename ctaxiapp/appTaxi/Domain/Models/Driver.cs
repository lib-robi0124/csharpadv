using Domain.Enums;

namespace Domain.Models
{
    public class Driver : BaseEntity
    {
        public Driver() { } // Parameterless constructor for EF Core
        public Driver(string firstName, string lastName, string license, Car car, DateTime licenseExpiryDate, DriverShift shift)
        {
            FirstName = firstName;
            LastName = lastName;
            License = license;
            Shift = shift;
            Car = car;
            LicenseExpiryDate = licenseExpiryDate;
        }
        public override string Print()
        {
            return $"{FirstName} {LastName} with license {License}";
        }
        public List<DriverShift> AssignedShifts { get; set; } = new List<DriverShift>();
    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string License { get; set; }
        public DriverShift Shift { get; set; } // e.g., Morning, Afternoon, Night, DayOff
        public Car Car { get; set; } // Navigation property to the Car entity
        public DateTime LicenseExpiryDate { get; set; } // Expiry date of the driver's license
    }
}
