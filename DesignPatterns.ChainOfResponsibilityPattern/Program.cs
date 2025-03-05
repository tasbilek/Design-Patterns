
Order order = new()
{
    ProductName = "Order 1",
    Quantity = 2,
    Price = 15
};

var paymentHandler = new PaymentHandler();
var preparationHandler = new PreparationHandler();
var deliveryHandler = new DeliveryHandler();
var completedHandler = new CompletedHandler();

paymentHandler.SetNext(preparationHandler);
preparationHandler.SetNext(deliveryHandler);
deliveryHandler.SetNext(completedHandler);

paymentHandler.Handle(order);

public class Order
{
    public string ProductName { get; set; } = default!;
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}

public interface IOrderHandler
{
    void SetNext(IOrderHandler next);
    bool Handle(Order order);
}

public class PaymentHandler : IOrderHandler
{
    private IOrderHandler? _next;

    public void SetNext(IOrderHandler next)
    {
        _next = next;
    }

    public bool Handle(Order order)
    {
        bool paymentSuccess = true; //Payment Service Response

        Console.WriteLine("Payment Handler");

        if (_next is not null && paymentSuccess)
        {
            return _next.Handle(order);
        }
        return paymentSuccess;
    }
}
public class PreparationHandler : IOrderHandler
{
    private IOrderHandler? _next;

    public void SetNext(IOrderHandler next)
    {
        _next = next;
    }

    public bool Handle(Order order)
    {
        bool preparationSuccess = true; //Preparation Service Response

        Console.WriteLine("Preparation Handler");

        if (_next is not null && preparationSuccess)
        {
            return _next.Handle(order);
        }
        return preparationSuccess;
    }
}
public class DeliveryHandler : IOrderHandler
{
    private IOrderHandler? _next;

    public void SetNext(IOrderHandler next)
    {
        _next = next;
    }

    public bool Handle(Order order)
    {
        bool deliverySuccess = true; //Delivery Service Response

        Console.WriteLine("Delivery Handler");

        if (_next is not null && deliverySuccess)
        {
            return _next.Handle(order);
        }
        return deliverySuccess;
    }
}
public class CompletedHandler : IOrderHandler
{
    private IOrderHandler? _next;

    public void SetNext(IOrderHandler next)
    {
        _next = next;
    }

    public bool Handle(Order order)
    {
        bool completedSuccess = true; 

        Console.WriteLine("Completed Handler");

        if (_next is not null && completedSuccess)
        {
            return _next.Handle(order);
        }
        return completedSuccess;
    }
}
