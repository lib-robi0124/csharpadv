﻿namespace homework2.Models
{
    public class MotorBike : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Im a motorbike and i drive on 2 wheels :)");
        }
        public override void Wheelie()
        {
            Console.WriteLine("The motorbike is doing a wheelie.");
        }
    }
 
}