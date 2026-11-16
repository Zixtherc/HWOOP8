using System.Collections.Generic;

class Item
{
}

class Order
{
    private List<Item> itemList;

    internal List<Item> ItemList
    {
        get { return itemList; }
        set { itemList = value; }
    }

    public void CalculateTotalSum() { /*...*/ }
    public void GetItems() { /*...*/ }
    public void GetItemCount() { /*...*/ }
    public void AddItem(Item item) { /*...*/ }
    public void DeleteItem(Item item) { /*...*/ }
}

class OrderRepository
{
    public Order Load(int orderId) { /*...*/ return new Order(); }
    public void Save(Order order) { /*...*/ }
    public void Update(Order order) { /*...*/ }
    public void Delete(Order order) { /*...*/ }
}

class OrderViewer
{
    public void PrintOrder(Order order) { /*...*/ }
    public void ShowOrder(Order order) { /*...*/ }
}
class Program
{
    static void Main(string[] args)
    {
    }
}