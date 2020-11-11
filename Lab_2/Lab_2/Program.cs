using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Transport:");
            Transport transport = new Transport
            {
                MaxLoad = 1500,
                MaxSpeed = 300
            };

            Console.WriteLine(" Max speed: {0}", transport.MaxSpeed);
            Console.WriteLine(" Max load: {0}", transport.MaxLoad);
            
            Console.WriteLine("Air transport:");
            
            AirTransport airTransport = new AirTransport();

            airTransport.maxCapacity = 14000;
            Console.WriteLine(" Max capacity: {0}", airTransport.maxCapacity);

            Console.WriteLine("Land transport:");

            LandTransport landTransport = new LandTransport();
            Console.WriteLine(" Horsepower: {0}", landTransport.Horsepower);
            Console.WriteLine(" Type of engine: {0}", landTransport.EngineType);

            Console.WriteLine("Cars:");
            Cars cars = new Cars();
            Console.WriteLine(" Car type: {0}", cars.CarType);
            Console.WriteLine(" Car model: {0}", cars.CarModel);

            Console.WriteLine("Helicopters: ");
            Helicopters helicopters = new Helicopters();
            Console.WriteLine(" Screw count: {0}", helicopters.ScrewCount);
            Console.WriteLine(" Classification: {0}", helicopters.Classification);

            Console.WriteLine("Trains:");
            Trains trains = new Trains();
            Console.WriteLine(" Thrust: {0}", trains.Thrust);
            Console.WriteLine(" Type of energy: {0}", trains.TypeOfEnergy);
        }
    }
}
