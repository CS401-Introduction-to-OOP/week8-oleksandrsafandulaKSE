namespace Week8;

public class CargoContainer<T> where T: DeliveryItemBase
{
    private List<T> _container;

    public CargoContainer()
    {
        _container = new List<T>();
    }

    public void AddItem(T item)
    {
        _container.Add(item);
    }

    public double GetTotalCost()
    {
        return _container.Sum(x => x.CalculateCost());
    }
    
}