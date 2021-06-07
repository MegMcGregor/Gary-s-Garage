using System;
namespace Garage
{
    public class Ram : Vehicle  // Gas powered truck
    {
        private const string V = "RuuUmbLeE";

        public double FuelCapacity { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"The truck says {V}");
        }
        public void RefuelTank()
        {
            // method definition omitted
        }
    }
}