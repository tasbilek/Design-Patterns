
//OldPaymentSystem paymentSystem = new OldPaymentSystem();
IPaymentSystem paymentSystem = new PaymentAdapter(new NewPaymentSystem());
paymentSystem.MakePayment("Customer1", 23.50);


#region Payment Systems

public class OldPaymentSystem
{
    public void MakePayment(string customer, double amount)
    {
        Console.WriteLine($"Payment made for {customer} by old payment system");
    }
}

public class NewPaymentSystem
{
    public void ProcessTransaction(string user, double totalAmount)
    {
        Console.WriteLine($"Payment made for {user} by new payment system");
    }
}

#endregion

#region Adapter Pattern

public interface IPaymentSystem
{
    void MakePayment(string customer, double amount);
}

public class PaymentAdapter : IPaymentSystem
{
    private readonly NewPaymentSystem _newPaymentSystem;

    public PaymentAdapter(NewPaymentSystem newPaymentSystem)
    {
        _newPaymentSystem = newPaymentSystem;
    }

    public void MakePayment(string customer, double amount)
    {
        _newPaymentSystem.ProcessTransaction(customer, amount);
    }
}

#endregion