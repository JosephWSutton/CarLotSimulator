using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            var Lot = new CarLot();

            var gWagon = new Car();
            gWagon.Year = 2020;
            gWagon.Make = "Mercedes";
            gWagon.Model = "G-Class";
            gWagon.EngineNoise = "haavuuuuuuuuuum";
            gWagon.HonkNoise = "heaaaaaank!";
            gWagon.IsDriveable = true;

            Lot.Cars.Add(gWagon);

            var camaro = new Car()
            {
                Make = "Chevrolet",
                Model = "Camaro ss",
                Year = 1968,
                EngineNoise = "vruuuum",
                HonkNoise = "Beeeeep",
                IsDriveable = false
            };

            Lot.Cars.Add(camaro);

            var wrx = new Car(2004, "Subaru", "WRXSTI", "spheeeww", "hiank", true);

            Lot.Cars.Add(wrx);

            gWagon.MakeEngineNoise(gWagon.EngineNoise);
            camaro.MakeEngineNoise(camaro.EngineNoise);
            wrx.MakeEngineNoise(wrx.EngineNoise);

            gWagon.MakeHonkNoise(gWagon.HonkNoise);
            camaro.MakeHonkNoise(camaro.HonkNoise);
            wrx.MakeHonkNoise(wrx.HonkNoise);

            foreach(var car in Lot.Cars)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
            }
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
