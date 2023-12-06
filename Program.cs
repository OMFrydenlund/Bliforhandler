//bruker er kunde, når programmet kjører møtes med visning direkte til inventar, og har valg om hvordan bilene filtreres (vil du se hele inv eller søke manuelt)
//kjøp eller gå tilbake til inventar/søk

// shop (forhandler, transaksjon)
// - biler (Opel Vectra 2010 120000km)

// kunde (penger, eierskap/garasje)

using Bliforhandler;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Market.Run();
    }
    public static void CarsList()
    {
        List<Car> carList = new List<Car>();
        carList.Add(new Car("Toyota Cresta", 1984, "AZ 38591", 240000, 100000));
        carList.Add(new Car("Audi RS6", 2020, "JF 50684", 110000, 150000));
        carList.Add(new Car("Lamborghini Gallardo", 2005, "MF 13373", 220000, 1200000));
        carList.Add(new Car("Ford Focus", 2013, "CZ 39428", 300000, 80000));

        foreach (Car vehicle in carList)
        {
            Console.WriteLine($"Model: {vehicle.Model}, Year: {vehicle.Year}, License Plate: {vehicle.RegNumber}, Price: {vehicle.Price}, Mileage: {vehicle.Kilometer}");
        }
    }
}
