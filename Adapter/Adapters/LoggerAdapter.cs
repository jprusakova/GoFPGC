namespace Adapter.Adapters
{
    public class LoggerAdapter : IOldLogger
    {
        private readonly INewLogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggerAdapter"/> class.
        /// </summary>
        public LoggerAdapter(INewLogger logger)
        {
            this.logger = logger;
        }

        public void Log(Level level, string message)
        {
            switch (level)
            {
                case Level.Debug:
                    this.logger.Debug(message);
                    break;
                case Level.Warning:
                    this.logger.Warning(message);
                    break;
                case Level.Error:
                    this.logger.Error(message);
                    break;
                case Level.Critical:
                    this.logger.Error(message);
                    break;
            }
        }
    }
}
