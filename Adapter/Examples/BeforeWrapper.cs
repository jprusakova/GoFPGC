namespace Adapter.Examples
{
    using WebMatrix.WebData;

    public class BeforeWrapper
    {
        public string Login(string username, string password)
        {
            if (WebSecurity.Login(username, password))
            {
                return "User logged in successfully.";
            }

            return "Bad username or password.";
        }
    }
}