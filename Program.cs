using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {

            Zero fxs = new Zero()
            {
                MainColor = "red",
                MaximumOccupancy = 3,
                BatteryKWh = 5.2
            };

            Tesla modelS = new Tesla()
            {
                MainColor = "purple",
                MaximumOccupancy = 5,
                BatteryKWh = 3.2
            };

            Cessna mx410 = new Cessna()
            {
                MainColor = "aqua",
                MaximumOccupancy = 4,
                FuelCapacity = 3.2,
            };

            Ram Truck = new Ram()
            {
                MainColor = "black",
                MaximumOccupancy = 4,
                FuelCapacity = 10.5,
            };

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            Truck.Drive();
        }
    }
}