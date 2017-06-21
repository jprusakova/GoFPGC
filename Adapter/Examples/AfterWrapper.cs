namespace Adapter.Examples
{
    using Adapter.Wrapper;

    public class AfterWrapper
    {
        private readonly IWebSecurityProvider provider;

        /// <summary>
        /// Initializes a new instance of the <see cref="AfterWrapper"/> class.
        /// </summary>
        public AfterWrapper(IWebSecurityProvider provider)
        {
            // shortcut to not have to set up IoC.
            this.provider = provider ?? new WebSecurityProvider();
        }

        public string Login(string username, string password)
        {
            if (this.provider.Login(username, password))
            {
                return "User logged in successfully.";
            }

            return "Bad username or password.";
        }
    }
}