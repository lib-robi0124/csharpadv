namespace HomeworkCars.Entities
{
    public class Car : BaseEntity
    {
        public string Model { get; set; }
        public double MilesPerGalon { get; set; }
        public int Cylinders { get; set; }
        public double HorsePower { get; set; }
        public double Weight { get; set; }

        /// <summary>
        /// Acceleration time to 100kmph
        /// </summary>
        public double AccelerationTime { get; set; }
        public string Origin { get; set; }
        public Car(string model, double milesPerGalon, int cylinders, double horsePower,
            double weight, double accelerationTime, string origin)
        {
            Model = model;
            MilesPerGalon = milesPerGalon;
            Cylinders = cylinders;
            HorsePower = horsePower;
            Weight = weight;
            AccelerationTime = accelerationTime;
            Origin = origin;
        }

        public Car()
        {
        }

        public override string Info()
        {
            return $"{Model} with {MilesPerGalon} miles per galon, {Cylinders} cylinders, " +
                $"{HorsePower} horse power, {Weight} weight, {AccelerationTime} acceleration time, " +
                $"and {Origin} origin";
        }
    }
}
