using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck: IVechicle, ICompany
    {
        public double BedLength { get; set; }
        public string TruckSize { get; set; }
        public int NumberOfWheels { get; set; }
        public decimal Mileage { get; set; }
        public string EngineType { get; set; }
        public bool IsDriveable { get; set; }
        public string Model { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
    }  
}
