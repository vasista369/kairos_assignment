using ItemsApi.Services;

public class ItemCartServiceFake : ItemsService
{
    private readonly List<Items> _shoppingCart;

    public ItemCartServiceFake()
    {
        _shoppingCart = new List<Items>()
            {
                new Items() { Id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c200"),
                    Name = "Orange Juice", Manufacturer="Orange Tree", Price = 5.00M },
                new Items() { Id = new Guid("815accac-fd5b-478a-a9d6-f171a2f6ae7f"),
                    Name = "Diary Milk", Manufacturer="Cow", Price = 4.00M },
                new Items() { Id = new Guid("33704c4a-5b87-464c-bfb6-51971b4d18ad"),
                    Name = "Frozen Pizza", Manufacturer="Uncle Mickey", Price = 12.00M }
            };
    }

    public IEnumerable<Items> GetAllItems()
    {
        return _shoppingCart;
    }

    public Items Add(Items newItem)
    {
        newItem.Id = Guid.NewGuid();
        _shoppingCart.Add(newItem);
        return newItem;
    }

    public Items GetById(Guid id)
    {
        return _shoppingCart.Where(a => a.Id == id)
            .FirstOrDefault();
    }

    public void Remove(Guid id)
    {
        var existing = _shoppingCart.First(a => a.Id == id);
        _shoppingCart.Remove(existing);
    }
}