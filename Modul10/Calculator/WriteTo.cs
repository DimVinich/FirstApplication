namespace Calculator
{
    public class WriteTo : IWriteTo
        {
            ILogger Logger { get; }
            public WriteTo(ILogger logger)
            {
                Logger = logger;
            }
            public void WriteResult(string result)
            {
                Logger.Event(result);
            }

            public void WriteError(string error)
            {
                Logger.Error(error);
            }

        }

}
