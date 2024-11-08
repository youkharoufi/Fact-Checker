using Serilog;

namespace FactChecker.Api.Extensions
{
    public static class LoggingExtensions
    {
        public static void ConfigureLogging(this IHostBuilder hostBuilder)
        {
            hostBuilder.UseSerilog((context, services, configuration) =>
            {
                // Set the log file path to the bin/Debug/net8.0/Logs directory
                var logFilePath = Path.Combine(AppContext.BaseDirectory, "Logs/fact-checker-logs.txt");

                configuration
                    .ReadFrom.Configuration(context.Configuration)
                    .WriteTo.Console()
                    .WriteTo.File(logFilePath, rollingInterval: RollingInterval.Day);
            });
        }
    }
}
