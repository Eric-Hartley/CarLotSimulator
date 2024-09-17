using System;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            CarLot carLot = new CarLot();
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise,
            //HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            //Now that the Car class is created we can instantiate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var beamer = new Car(2015, "BMW", "335i", true, carLot);
            beamer.MakeEngineNoise("stututuu");
            beamer.MakeHonkNoise("beep bop");

            var supra = new Car(1996, "Toyota", "Supra", true, carLot);
            supra.MakeEngineNoise("stututuu");
            supra.MakeHonkNoise("beep beep");

            var wrx = new Car(2018, "Subaru", "WRX", true, carLot);
            wrx.MakeEngineNoise("stututuu");
            wrx.MakeHonkNoise("beep boop");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instantiate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            
            
            carLot.DisplayCars();


        }
    }
}
