using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    //Create a seperate class file called Car
    //Car shall have the following properties: Year, Make, Model, EngineNoise,
    //HonkNoise, IsDriveable
    //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
    //The methods should take one string parameter: the respective noise property
    internal class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool IsDriveable { get; set; }
        private CarLot carLotModifier;


        public Car(int year, string make, string model, bool isDriveable, CarLot carLot)
        {
            Year = year;
            Make = make;
            Model = model;
            isDriveable = true;
            carLotModifier = carLot;

            if (carLot != null)
            {
                carLot.AddCar(this);
            }
        }

        public void MakeEngineNoise(string EngineNoise)
        {
            Console.WriteLine(EngineNoise);
        }
        public void MakeHonkNoise(string HonkNoise)
        {
            Console.WriteLine(HonkNoise);
        }

    }
    


}
