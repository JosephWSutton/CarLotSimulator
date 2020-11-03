using System;
namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool IsDriveable { get; set; }
        public string HonkNoise { get; set; }
        public string EngineNoise { get; set; }


        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

        public void MakeHonkNoise(string honk)
        {
            Console.WriteLine(honk);
        }

        public void MakeEngineNoise(string engine)
        {
            Console.WriteLine(engine);
        }
    }
}
