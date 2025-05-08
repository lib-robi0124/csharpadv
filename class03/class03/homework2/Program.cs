using homework2.Models;

Vehicle car = new Car();
Vehicle motorBike = new MotorBike();
Vehicle boat = new Boat();
Vehicle plane = new Airplane();
Console.WriteLine("DisplayInfo");
car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo();

Console.WriteLine("Homework-class04-task2");
car.Drive();
motorBike.Wheelie();
boat.Sail();
plane.Fly();
