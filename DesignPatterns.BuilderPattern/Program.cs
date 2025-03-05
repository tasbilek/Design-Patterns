// See https://aka.ms/new-console-template for more information


using System.Text.Json;

var logBuilder = new Logger.LogBuilder();

var log = logBuilder
            .WithType(Logger.LogType.Error)
            .WithMessage("An unexpected error occured")
            .WithException(new ArgumentException("Invalid operation").ToString())
            .WithSource("PaymentService")
            .Build();

Console.WriteLine(JsonSerializer.Serialize(log));


public class Logger
{
    public string Source { get; private set; } = string.Empty;
    public string Message { get; private set; } = string.Empty;
    public string? Exception { get; private set; }
    public LogType Type { get; private set; } =  LogType.Error;
    public DateTimeOffset LogDate { get; private set; } = DateTimeOffset.Now;

    private Logger(){}

    public enum LogType
    {
        Info,
        Warning,
        Error,
        Success
    }

    public class LogBuilder
    {
        private readonly Logger _logger;

        public LogBuilder()
        {
            _logger = new();
        }

        public LogBuilder WithSource(string source)
        {
            _logger.Source = source;
            return this;
        }

        public LogBuilder WithMessage(string message)
        {
            _logger.Message = message;
            return this;
        }
        
        public LogBuilder WithException(string exception)
        {
            _logger.Exception = exception;
            return this;
        }
        
        public LogBuilder WithType(LogType logType)
        {
            _logger.Type = logType;
            return this;
        }
        
        public Logger Build()
        {
            return _logger;
        }
    }
}