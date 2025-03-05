

IPaymentService paymentServiceAuth = new PaymentServiceProxy(true);
paymentServiceAuth.ProcessPayment(59.99);

Console.WriteLine("------------------");

IPaymentService paymentServiceUnAuth = new PaymentServiceProxy(false);
paymentServiceUnAuth.ProcessPayment(199.99);

public interface IPaymentService
{
    void ProcessPayment(double amount);
}

public class PaymentService : IPaymentService
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing payment of {amount}");
    }
}

public class PaymentServiceProxy : IPaymentService
{
    private readonly PaymentService _paymentService;
    private readonly bool _isAuthorized;

    public PaymentServiceProxy(bool isAuthorized)
    {
        _isAuthorized = isAuthorized;
        _paymentService = new();
    }

    public void ProcessPayment(double amount)
    {
        if (!_isAuthorized)
        {
            Console.WriteLine("Unauthorized payment attempt blocked!");
            return;
        }

        Console.WriteLine("Authorization proxy is successful");
        _paymentService.ProcessPayment(amount);
    }
}
