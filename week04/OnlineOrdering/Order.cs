using System;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    private const double USA_SHIPPING    = 5.0;
    private const double INTL_SHIPPING   = 35.0;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }


    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        if (_customer.LivesInUSA())
        {
            total += USA_SHIPPING;
        }
        else
        {
            total += INTL_SHIPPING;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "=== PACKING LABEL ===\n";

        foreach (Product product in _products)
        {
            label += $"{product.GetName()} - ID: {product.GetProductId()}\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        string label = "=== SHIPPING LABEL ===\n";
        label += $"{_customer.GetName()}\n";
        label += _customer.GetAddress().GetFullAddress();
        return label;
    }
}