
var paymentService = new PaymentService(new CreditCardPayment());
paymentService.ProcessPayment(15.20);

paymentService.SetPaymentService(new PayPalPayment());
paymentService.ProcessPayment(199.99);


public interface IPaymentService
{
    void Pay(double amount);
}

public class CreditCardPayment : IPaymentService
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Payment of {amount} made by Credit Card");
    }
}

public class PayPalPayment : IPaymentService
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Payment of {amount} made by PayPal");
    }
}

public class PaymentService
{
    private IPaymentService? _paymentService;

    public PaymentService() {}

    public PaymentService(IPaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    public void SetPaymentService(IPaymentService paymentService)
    {
        _paymentService = paymentService; 
    }

    public void ProcessPayment(double amount)
    {
        if (_paymentService is null)
            throw new ArgumentException("Payment service is not set");
        _paymentService.Pay(amount);
    }
}