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


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            Console.WriteLine($"Cars Created: {CarLot.numberOfCars}");

            Car userCar1 = new Car();

            var CarList = new CarLot();


            
            Console.WriteLine("------------------------");
            Console.WriteLine("Car 1");
            Console.WriteLine("------------------------");

            userCar1.Make = "Honda";

            userCar1.Model = "Civic";

            userCar1.Year = 2025;

            userCar1.IsDriveable = true;

            userCar1.MakeEngineNoise("Vroom");
            userCar1.MakeHonkNoise("Honk");
            
            Console.WriteLine($"Cars Created: {CarLot.numberOfCars}");

            
            CarList.Cars.Add(userCar1);
            


            Console.WriteLine("------------------------");
            Console.WriteLine("Car 2");
            Console.WriteLine("------------------------");


            Car userCar2 = new Car()
            {
                Make = "Ford", 
                Model = "Coupe", 
                Year = 1932, 
                IsDriveable = false,
            };
            
                userCar2.MakeEngineNoise("Stutter");
                userCar2.MakeHonkNoise("La Cucaracha");
                
                Console.WriteLine($"Cars Created: {CarLot.numberOfCars}");

                
                CarList.Cars.Add(userCar2);
            

                //Console.WriteLine("What is the Car's Year?");
                //userCar2.Year = int.Parse(Console.ReadLine());

                //Console.WriteLine("Which Corporation made the Car?");
                //userCar2.Make = Console.ReadLine();

                //Console.WriteLine("What is the Car's Model?");
                //userCar2.Model = Console.ReadLine();

                //userCar2.Year = 1932;
                // userCar2.Make = "Ford";
                //userCar2.Model = "Coupe";
                //userCar2.HonkNoise = "Beep";
                //userCar2.EngineNoise = "Vroom";
                //userCar2.IsDriveable = false;

            
            
            Console.WriteLine("------------------------");
            Console.WriteLine("Car 3");
            Console.WriteLine("------------------------");

            Car userCar3 = new Car("Toyota", "Corolla", 1992, false);
            
            userCar3.MakeEngineNoise("Spud-Spud");
            userCar3.MakeHonkNoise("Beep");
            
            Console.WriteLine($"Cars Created: {CarLot.numberOfCars}");

            
            //userCar3.Year = 1992;
           // userCar3.Make = "Toyota";
            //userCar3.Model = "Corolla";
            //userCar3.HonkNoise = "Blam";
            //userCar3.EngineNoise = "Vroom";
            //userCar3.IsDriveable = false;
            
            CarList.Cars.Add(userCar3);

            
            CarList.CarListing();
            
            


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
