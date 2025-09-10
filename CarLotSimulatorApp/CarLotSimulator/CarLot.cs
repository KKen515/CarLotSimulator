using System.Collections.Generic;
namespace CarLotSimulator;
public class CarLot
{

    public static int numberOfCars;
    
    public List<Car> Cars { get; set; } = new List<Car>();

    public void CarListing()
    {
        foreach (var car in Cars)
        {
            car.CarList();
        }
    }
    
}
