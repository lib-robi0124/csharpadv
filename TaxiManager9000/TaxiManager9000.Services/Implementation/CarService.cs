﻿using TaxiManager9000.Domain.Models;
using TaxiManager9000.Services.Abstraction;
using TaxiManager9000.Services.Abstraction.Interfaces;

namespace TaxiManager9000.Services.Implementation
{
    public class CarService : ServiceBase<Car>, ICarService
    {
        public bool IsAvailableCar(Car car) =>
            car.IsLicensePlateExpired() == Domain.Enums.ExpiryStatus.Expired ||
            car.AsignedDrivers?.Count == 3 ? false : true;
    }
}
