using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVechicle
    {
        public int NumberOfWheels { get; set; }

        public decimal Mileage { get; set; }

        public string EngineType { get; set; }

        public bool IsDriveable { get; set; } 
        public string Model { get; set; }
    }
}
