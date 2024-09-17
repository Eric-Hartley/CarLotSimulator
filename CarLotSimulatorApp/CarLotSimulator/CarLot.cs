using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    class CarLot
    {
        public List<Car> Cars { get; set; }

        public CarLot()
        {
            Cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
        public void DisplayCars()
        {
            foreach (var car in Cars)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model} \nDriveable: {car.IsDriveable}");
                if (car.Make.ToUpper() == "BMW".ToUpper())
                {
                    car.MakeEngineNoise("stututuu");
                    car.MakeHonkNoise("beep bop");
                }
                if (car.Make.ToUpper() == "Subaru".ToUpper())
                {
                    car.MakeEngineNoise("stututuu");
                    car.MakeHonkNoise("beep boop");
                }
                if(car.Make.ToUpper() == "Toyota".ToUpper())
                {
                    car.MakeEngineNoise("stututuu");
                    car.MakeHonkNoise("beep beep");
                }
                
            }
        }
        


                
    }

}
