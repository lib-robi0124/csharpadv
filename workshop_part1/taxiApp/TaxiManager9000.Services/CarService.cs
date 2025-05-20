using TaxiManager9000.Domain.Models;
using TaxiManager9000.Services.Interfaces;


namespace TaxiManager9000.Services
{
    public class CarService : ServiceBase<Car>, ICarService
    {
        //public bool IsAvailableCar(Car car)
        //{
        //    if (car.IsLicensePlateExpired() == Domain.Enums.ExpiryStatus.Expired || car.DriverAssigned.Count == 3)
        //        return false;
        //    return true;
        //}
        public bool IsAvailableCar(Car car) =>
            car.IsLicensePlateExpired() == Domain.Enums.ExpiryStatus.Expired ||
            car.DriverAssigned?.Count == 3 ? false : true;

    }
}
