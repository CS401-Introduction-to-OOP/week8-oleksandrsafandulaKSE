namespace Week8;

public class Letter : DeliveryItemBase
{
    public Letter(string trackingNumber, double weight) : base(trackingNumber, weight) { }

    public override double CalculateCost()
    {
        return 15 + Weight * 10;
    }
    
}