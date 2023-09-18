namespace AbstractClassDemo;

class Program
{
    static void Main(string[] args)
    {

        Console.ReadLine();
    }
}

public interface IPurchasable
{
    void Buy();
}

public abstract class Vehicle : IPurchasable
{
    public string VIN { get; set; }
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public int YearManufactured { get; set; }

    public void Buy()
    {
        Console.WriteLine("Bought");
    }
}

public class Car : Vehicle
{
    public int NumberOfWheels { get; set; } = 4;

}