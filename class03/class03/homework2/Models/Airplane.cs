﻿namespace homework2.Models
{
    public class Airplane : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Im a plane and i have a couple of wheels :)");
        }
        public override void Fly()
        {
            Console.WriteLine("The airplane is flying.");
        }
    }
}
