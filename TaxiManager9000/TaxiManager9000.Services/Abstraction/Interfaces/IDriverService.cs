using TaxiManager9000.Domain.Models;

namespace TaxiManager9000.Services.Abstraction.Interfaces
{
    public interface IDriverService : IServiceBase<Driver>
    {
        void AssignDriver(Driver driver, Car car);
        void UnassignDriver(Driver driver);
        bool IsAvailableDriver(Driver driver);
    }
}
