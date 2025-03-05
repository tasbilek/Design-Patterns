
Order order = new();
order.NotifyOrderStatus();

order.NextState();
order.NotifyOrderStatus();

order.NextState();
order.NotifyOrderStatus();

order.NextState();
order.NotifyOrderStatus();

order.NextState();


public class Order
{
    public IOrderState State { get; set; }

    public Order()
    {
        State = new OrderReceivedState();
    }

    public void NextState()
    {
        State.Next(this);
    }

    public void PreviousState()
    {
        State.Previous(this);
    }

    public void NotifyOrderStatus()
    {
        State.NotifyStatus();
    }
}

public interface IOrderState
{
    void Next(Order order);
    void Previous(Order order);
    void NotifyStatus();
}

public record OrderReceivedState : IOrderState
{
    public void Next(Order order)
    {
        order.State = new PreparingState();
    }

    public void NotifyStatus()
    {
        Console.WriteLine("Order is received");
    }

    public void Previous(Order order)
    {
        Console.WriteLine("This is the initial state!");
    }
}

public record PreparingState : IOrderState
{
    public void Next(Order order)
    {
        order.State = new OutForDeliveryState();
    }

    public void NotifyStatus()
    {
        Console.WriteLine("Order is preparing");
    }

    public void Previous(Order order)
    {
        order.State = new OrderReceivedState();
    }
}

public record OutForDeliveryState : IOrderState
{
    public void Next(Order order)
    {
        order.State = new DeliveredState();
    }

    public void NotifyStatus()
    {
        Console.WriteLine("Order is out for delivery");
    }

    public void Previous(Order order)
    {
        order.State = new PreparingState();
    }
}

public record DeliveredState : IOrderState
{
    public void Next(Order order)
    {
        Console.WriteLine("This is the final state");
    }

    public void NotifyStatus()
    {
        Console.WriteLine("Order is delivered");
    }

    public void Previous(Order order)
    {
        order.State = new OutForDeliveryState();
    }
}
