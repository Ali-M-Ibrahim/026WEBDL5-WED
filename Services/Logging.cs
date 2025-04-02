namespace TPINCIWED.Services
{
    public class Logging
    {
        private readonly ILogger<Logging> _logger;

        public Logging(ILogger<Logging> logger)
        {
            
            _logger = logger;
        }

        public void Log(string message) { 
        
                _logger.LogInformation(message);

        }
    }
}
