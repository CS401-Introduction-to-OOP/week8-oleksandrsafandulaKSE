namespace Week8;

public abstract class DeliveryItemBase
{
    private string _trackingNumber;
    private double _weight;

    public string TrackingNumber
    {
        get => _trackingNumber;
        set => _trackingNumber = value;
    }

    public double Weight
    {
        get => _weight;
        set => _weight = value;
    }

    public DeliveryItemBase(string trackingNumber, double weight)
    {
        TrackingNumber = trackingNumber;
        Weight = weight;
    }

    public abstract double CalculateCost();

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Tracking number: {TrackingNumber}, Weight: {Weight}");
    }
    
}