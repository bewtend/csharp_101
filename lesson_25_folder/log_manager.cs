namespace csharp_learning
{
    public class LogManager : ILogger
    {
        public ILogger _logger;
        public LogManager(ILogger logger)
        {
            _logger = logger;
        }

        public void rLog()
        {
            _logger.rLog();
        }

        public void wLog()
        {
            _logger.wLog();
        }
    }
}