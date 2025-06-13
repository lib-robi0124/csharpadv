using TaxiManager9000.Domain.Enums;

namespace TaxiManager9000.Domain.Models
{
    public class Car : BaseEntity
    {
        public string Model { get; set; } = string.Empty;
        public string LicensePlate { get; set; } = string.Empty;
        public DateTime LicensePlateExpieryDate { get; set; }

        public List<Driver> AsignedDrivers { get; set; } = new();

        public Car(string model, string licensePlate, DateTime licensePlateExpieryDate)
        {
            Model = model;
            LicensePlate = licensePlate;
            LicensePlateExpieryDate = licensePlateExpieryDate;
            AsignedDrivers = new List<Driver>();

        }


        public override string GetInfo()
        {
            string drivers = string.Empty;
            foreach (Driver driver in AsignedDrivers)
            {
                drivers += $"{driver.Id}.) {driver.FirstName} {driver.LastName}\n";
            }
            return $"Car {Model} with plates {LicensePlate} that expire on {LicensePlateExpieryDate.ToShortDateString()} is driven by : \n{drivers}";
        }
        public ExpiryStatus IsLicensePlateExpired()
        {
            if (DateTime.Today >= LicensePlateExpieryDate) return ExpiryStatus.Expired;
            else if (DateTime.Today.AddMonths(3) >= LicensePlateExpieryDate) return ExpiryStatus.Warning;
            else return ExpiryStatus.Valid;
        }
    }
}
