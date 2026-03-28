namespace Week8;

public class Parcel : DeliveryItemBase
{
    private string _dimensions;
    
    public string Dimensions
    {
        get => _dimensions;
        set => _dimensions = value;
    }   
    
    public Parcel(string trackingNumber, double weight) : base(trackingNumber, weight)
    {
    }

    public override double CalculateCost()
    {
        return 50 + Weight * 25;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Dimensions: {Dimensions}");
    }
}