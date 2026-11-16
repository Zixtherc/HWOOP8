using System;

interface IPricedItem
{
    void SetPrice(double price);
}

interface IDiscountable
{
    void ApplyDiscount(String discount);
    void ApplyPromocode(String promocode);
}

interface IClothingAttributes
{
    void SetColor(byte color);
    void SetSize(byte size);
}

class Book : IPricedItem, IDiscountable
{
    public double Price { get; private set; }
    public string Discount { get; private set; }
    public string Promocode { get; private set; }

    public void SetPrice(double price)
    {
        Price = price;
    }

    public void ApplyDiscount(string discount)
    {
        Discount = discount;
    }

    public void ApplyPromocode(string promocode)
    {
        Promocode = promocode;
    }
}

class Outerwear : IPricedItem, IDiscountable, IClothingAttributes
{
    public double Price { get; private set; }
    public string Discount { get; private set; }
    public string Promocode { get; private set; }
    public byte Color { get; private set; }
    public byte Size { get; private set; }

    public void SetPrice(double price)
    {
        Price = price;
    }

    public void ApplyDiscount(string discount)
    {
        Discount = discount;
    }

    public void ApplyPromocode(string promocode)
    {
        Promocode = promocode;
    }

    public void SetColor(byte color)
    {
        Color = color;
    }

    public void SetSize(byte size)
    {
        Size = size;
    }
}

class Program
{
    static void Main(string[] args)
    {
    }
}