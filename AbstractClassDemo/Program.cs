namespace AbstractClassDemo;

class Program
{
    static void Main(string[] args)
    {

        Console.ReadLine();
    }
}

public abstract class InventoryItem
{
    public string ProductName { get; set; }
    public int QuantityOnHand { get; set; }
}

public class Book : InventoryItem
{

}

public class Vehicle : InventoryItem
{

}