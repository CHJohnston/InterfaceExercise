using System;
using System.Collections.Generic;
using System.Xml;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE- TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE - Create 2 Interfaces called IVehicle & ICompany

            //DONE - Create 3 classes called Car , Truck , & SUV

            //DONE - In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //DONE - In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //DONE - In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //DONE - Now, create objects of your 3 classes and give their members values;

            Car car1 = new Car()
            {
                BodyType = "Sedean",
                CargoSize = 95.5,
                NumberOfWheels = 4,
                Mileage = 35123,
                EngineType = "Gas",
                IsDriveable = true,
                Model = "Taurus",
                Logo = "Oval",
                Name = "Ford"          
            };

            Car car2 = new Car()
            {
                BodyType = "Hatchback",
                CargoSize = 92.5,
                NumberOfWheels = 4,
                Mileage = 155653,
                EngineType = "Gas",
                IsDriveable = false,
                Model = "Rav4",
                Logo = "Oval",
                Name = "Toyota"
            };

            Truck truck1 = new Truck()
            {
                BedLength =96,
                TruckSize = "OneTon",
                NumberOfWheels = 6,
                Mileage = 155653,
                EngineType = "Diesel",
                IsDriveable = false,
                Model = "F-350",
                Logo = "Oval",
                Name = "Ford"
            };


            //Creatively display and organize their values
            List<IVechicle> vechicles = new List<IVechicle>();
            vechicles.Add(car1);
            vechicles.Add(car2);
            vechicles.Add(truck1);

            foreach (var vech in vechicles)
            {
                Console.WriteLine($"Engine Type  {vech.EngineType} -- Model {vech.Model}");                
                Console.WriteLine();
            }
        }
    }
}
