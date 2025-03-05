// See https://aka.ms/new-console-template for more information

ILogger logger = new ConsolLogger();
logger = new TimestampLogger(logger);
logger = new ErrorLogger(logger);

logger.Log("Payment processing error");


public interface ILogger
{
    void Log(string message);
}

public class ConsolLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[Info] {message}");
    }
}

public abstract class LoggerDecorator : ILogger
{
    protected readonly ILogger _logger;
    public LoggerDecorator(ILogger logger)
    {
        _logger = logger;
    }

    public virtual void Log(string message)
    {
        _logger.Log(message);
    }
}

public class ErrorLogger : LoggerDecorator
{
    public ErrorLogger(ILogger logger) : base(logger) {}

    public override void Log(string message)
    {
        _logger.Log($"[Error] {message}");
    }
}

public class TimestampLogger : LoggerDecorator
{
    public TimestampLogger(ILogger logger) : base(logger) {}

    public override void Log(string message)
    {
        _logger.Log($"[{DateTimeOffset.Now}] {message}");
    }
}
