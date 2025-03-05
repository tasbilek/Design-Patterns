
var notificationService = new NotificationService();

var user1 = new User("User1");
var user2 = new User("User2");

notificationService.Register(user1);
notificationService.Register(user2);

notificationService.Notify("New product is in stock now");

notificationService.UnRegister(user1);

notificationService.Notify("50% discount on new product only for 2 days");


public interface IObserver
{
    void UpdateNews(string message);
}

public class User : IObserver
{
    public string Name {get;}
    public User(string name)
    {
        Name = name;
    }

    public void UpdateNews(string message)
    {
        Console.WriteLine($"{Name} received notification: {message}");
    }
}

public class NotificationService
{
    private readonly List<IObserver> _observers = new();

    public void Register(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void UnRegister(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(string message)
    {
        foreach (var observer in _observers)
        {
            observer.UpdateNews(message);
        }
    }
}