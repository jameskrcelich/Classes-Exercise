using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a separate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            //Now that the Car class is created we can instantiate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Car myFirstCar = new Car();

            myFirstCar.Year = 1969;
            myFirstCar.Make = "Chevrolet";
            myFirstCar.Model = "Camaro";
            myFirstCar.MakeEngineNoise("Varoom");
            myFirstCar.MakeHonkNoise("Beep beep");
            myFirstCar.IsDrivable = false;
            
           // Set the properties utilizing the 3 different ways we learned about, one way for each car

            Car mySecondCar = new Car()
            {
                Year = 1989,
                Make = "Pontiac",
                Model = "Grand Prix",
                IsDrivable = true
            };
            mySecondCar.MakeEngineNoise("Varoom");
            mySecondCar.MakeHonkNoise("Beep beep");

            Car myThirdCar = new Car(2025, "Toyota", "Corolla", true);
            myThirdCar.MakeEngineNoise("Varoom");
            myThirdCar.MakeHonkNoise("Beep beep");
            
            Console.WriteLine($"{myFirstCar.Year} {myFirstCar.Make} {myFirstCar.Model}");  
            Console.WriteLine($"\t Engine noise = {myFirstCar.EngineNoise}, Car Honk Noise = {myFirstCar.HonkNoise}, Is Drivable = {myFirstCar.IsDrivable}");
            Console.WriteLine($"{mySecondCar.Year} {mySecondCar.Make} {mySecondCar.Model}");  
            Console.WriteLine($"\t Engine noise = {mySecondCar.EngineNoise}, Car Honk Noise = {mySecondCar.HonkNoise}, Is Drivable = {mySecondCar.IsDrivable}");
            Console.WriteLine($"{myThirdCar.Year} {myThirdCar.Make} {myThirdCar.Model}");  
            Console.WriteLine($"\t Engine noise = {myThirdCar.EngineNoise}, Car Honk Noise = {myThirdCar.HonkNoise}, Is Drivable = {myThirdCar.IsDrivable}");
        }
    }
}
