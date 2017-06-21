namespace Adapter.Adapters
{
    public interface INewLogger
    {
        void Debug(string message);

        void Warning(string message);

        void Error(string message);
    }
}