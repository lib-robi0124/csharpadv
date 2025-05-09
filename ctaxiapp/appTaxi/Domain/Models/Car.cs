using Domain.Enums;

namespace Domain.Models
{
    public class Car : BaseEntity
    {
        public Car() { } // Parameterless constructor for EF Core
        public Car(string model, string licensePlate, DateTime licensePlateExpiryDate)
        {
            
            Model = model;
            LicensePlate = licensePlate;
            LicensePlateExpiryDate = licensePlateExpiryDate;
            AssignedDrivers = new List<DriverShift>();
        }

        public string Model { get; set; }
        public string LicensePlate { get; set; }   
        public DateTime LicensePlateExpiryDate { get; set; }
        public List<DriverShift> AssignedDrivers { get; set; } = new List<DriverShift>();
        public override string Print()
        {
            int assignedPercentage = AssignedDrivers.Count == 0 ? 0 : 100 / 3 * AssignedDrivers.Count + 1;
            return $"{Model} with license plate {LicensePlate} and utilized {assignedPercentage}% of the drivers.";
        }
    }
}
