using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;


namespace TaxiManager9000.Helpers
{
    public static class ListExtensions
    {
        private static readonly Dictionary<ExpiryStatus, ConsoleColor> StatusColorMapper = new()
        {
            {ExpiryStatus.Valid, ConsoleColor.Green },
            {ExpiryStatus.Warning, ConsoleColor.Yellow },
            {ExpiryStatus.Expired, ConsoleColor.Red },

        };
        public static void Print<T>(this List<T> list) where T : BaseEntity
        {
            if (list.Count == 0)
            {
                ExtendedConsole.NoItemsMessage<T>();
            }
            else
            {
                foreach (T item in list)
                {
                    Console.WriteLine(item.GetInfo());
                }
            }
            Console.ReadLine();
        }
        public static void PrintStatus(this List<Car> list)
        {
            if (list.Count == 0)
            {
                ExtendedConsole.NoItemsMessage<Car>();
            }
            else
            {
                foreach (var car in list)
                {
                    ExpiryStatus status = car.IsLicensePlateExpired();
                    ExtendedConsole.PrintTitle($"[{status}]) ", StatusColorMapper[status]);
                    Console.WriteLine($"Car Id: {car.Id} - Plate {car.LicensePlate} with expiry date: {car.LicensePlateExpieryDate}");
                }
            }
            Console.ReadLine();
        }
    }
}
