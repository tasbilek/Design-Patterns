// See https://aka.ms/new-console-template for more information


NotificationBase notificationBase = new NotifyUser();
notificationBase.SendNotification(NotificationType.Email, "This is an email notification message");
notificationBase.SendNotification(NotificationType.Sms, "This is a sms notification message");
notificationBase.SendNotification(NotificationType.Push, "This is a push notification message");

#region Notifications

interface INotification
{
    void Send(string message);
}

class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending Email: {message}");
    }
}

class SmsNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending Sms: {message}");
    }
}

class PushNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending Push Notification: {message}");
    }
}

enum NotificationType
{
    Email,
    Sms,
    Push
}

abstract class NotificationBase
{
    protected abstract INotification CreateNotification(NotificationType notificationType);

    public INotification SendNotification(NotificationType notificationType, string message)
    {
        INotification notification = CreateNotification(notificationType);

        notification.Send(message);

        return notification;
    }

}

#endregion

class NotifyUser : NotificationBase
{
    protected override INotification CreateNotification(NotificationType notificationType)
    {
        return notificationType switch
        {
            NotificationType.Email => new EmailNotification(),
            NotificationType.Sms => new SmsNotification(),
            NotificationType.Push => new PushNotification(),
            _ => throw new ArgumentException("Invalid notification type")
        };
    }
}
