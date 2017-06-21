namespace Adapter.Wrapper
{
    using WebMatrix.WebData;

    /// <summary>
    /// Wraps WebSecurity so it can be injected.
    /// </summary>
    public class WebSecurityProvider : IWebSecurityProvider
    {
        /// <summary>Gets a value that indicates whether the <see cref="M:WebMatrix.WebData.WebSecurity.InitializeDatabaseConnection(System.String,System.String,System.String,System.String,System.Boolean)" /> 
        /// method has been called.</summary>
        /// <returns>true if the initialization method has been called; otherwise, false.</returns>
        public bool Initialized => WebSecurity.Initialized;

        /// <summary>Returns the ID for a user based on the specified user name.</summary>
        /// <returns>The user ID.</returns>
        /// <param name="userName">The user name.</param>
        /// <exception cref="T:System.InvalidOperationException">The <see cref="M:WebMatrix.WebData.SimpleMembershipProvider.Initialize(System.String,System.Collections.Specialized.NameValueCollection)" /> method was not called.-or-The <see cref="Overload:WebMatrix.WebData.WebSecurity.InitializeDatabaseConnection" /> method was not called.-or-The <see cref="T:WebMatrix.WebData.SimpleMembershipProvider" /> membership provider is not registered in the configuration of your site. For more information, contact your site's system administrator.</exception>
        public int CurrentUserId => WebSecurity.GetUserId(this.CurrentUserName);

        /// <summary>Gets the user name for the current user.</summary>
        /// <returns>The name of the current user.</returns>
        public string CurrentUserName => WebSecurity.CurrentUserName;

        /// <summary>Gets a value that indicates whether the current user has a user ID.</summary>
        /// <returns>true if the user has a user ID; otherwise, false.</returns>
        public bool HasUserId => WebSecurity.HasUserId;

        /// <summary>Gets the authentication status of the current user.</summary>
        /// <returns>true if the current user is authenticated; otherwise, false. The default is false.</returns>
        public bool IsAuthenticated => WebSecurity.IsAuthenticated;

        /// <summary>Logs the user in.</summary>
        /// <returns>true if the user was logged in; otherwise, false. </returns>
        /// <param name="userName">The user name.</param>
        /// <param name="password">The password.</param>
        /// <param name="persistCookie">(Optional) true to specify that the authentication token in the cookie should be persisted beyond the current session; otherwise false. The default is false.</param>
        /// <exception cref="T:System.InvalidOperationException">The <see cref="M:WebMatrix.WebData.SimpleMembershipProvider.Initialize(System.String,System.Collections.Specialized.NameValueCollection)" /> method was not called.-or-The <see cref="Overload:WebMatrix.WebData.WebSecurity.InitializeDatabaseConnection" /> method was not called.-or-The <see cref="T:WebMatrix.WebData.SimpleMembershipProvider" /> membership provider is not registered in the configuration of your site. For more information, contact your site's system administrator.</exception>
        public bool Login(string userName, string password, bool persistCookie = false) => WebSecurity.Login(userName, password, persistCookie);

        /// <summary>Logs the user out.</summary>
        /// <exception cref="T:System.InvalidOperationException">The <see cref="M:WebMatrix.WebData.SimpleMembershipProvider.Initialize(System.String,System.Collections.Specialized.NameValueCollection)" /> method was not called.-or-The <see cref="Overload:WebMatrix.WebData.WebSecurity.InitializeDatabaseConnection" /> method was not called.-or-The <see cref="T:WebMatrix.WebData.SimpleMembershipProvider" /> membership provider is not registered in the configuration of your site. For more information, contact your site's system administrator.</exception>
        public void Logout() => WebSecurity.Logout();

        /// <summary>Changes the password for the specified user.</summary>
        /// <returns>true if the password is successfully changed; otherwise, false.</returns>
        /// <param name="userName">The user name.</param>
        /// <param name="currentPassword">The current password for the user.</param>
        /// <param name="newPassword">The new password.</param>
        /// <exception cref="T:System.InvalidOperationException">The <see cref="M:WebMatrix.WebData.SimpleMembershipProvider.Initialize(System.String,System.Collections.Specialized.NameValueCollection)" /> method was not called.-or-The <see cref="Overload:WebMatrix.WebData.WebSecurity.InitializeDatabaseConnection" /> method was not called.-or-The <see cref="T:WebMatrix.WebData.SimpleMembershipProvider" /> membership provider is not registered in the configuration of your site. For more information, contact your site's system administrator.</exception>
        public bool ChangePassword(string userName, string currentPassword, string newPassword) => WebSecurity.ChangePassword(userName, currentPassword, newPassword);

        /// <summary>Confirms that an account is valid and activates the account.</summary>
        /// <returns>true if the account is confirmed; otherwise, false.</returns>
        /// <param name="accountConfirmationToken">A confirmation token to pass to the authentication provider.</param>
        /// <exception cref="T:System.InvalidOperationException">The <see cref="M:WebMatrix.WebData.SimpleMembershipProvider.Initialize(System.String,System.Collections.Specialized.NameValueCollection)" /> method was not called.-or-The <see cref="Overload:WebMatrix.WebData.WebSecurity.InitializeDatabaseConnection" /> method was not called.-or-The <see cref="T:WebMatrix.WebData.SimpleMembershipProvider" /> membership provider is not registered in the configuration of your site. For more information, contact your site's system administrator.</exception>
        public bool ConfirmAccount(string accountConfirmationToken) => WebSecurity.ConfirmAccount(accountConfirmationToken);

        /// <summary>Confirms that an account for the specified user name is valid and activates the account.</summary>
        /// <returns>true if the account is confirmed; otherwise, false.</returns>
        /// <param name="userName">The user name.</param>
        /// <param name="accountConfirmationToken">A confirmation token to pass to the authentication provider.</param>
        /// <exception cref="T:System.InvalidOperationException">The <see cref="M:WebMatrix.WebData.SimpleMembershipProvider.Initialize(System.String,System.Collections.Specialized.NameValueCollection)" /> method was not called.-or-The <see cref="Overload:WebMatrix.WebData.WebSecurity.InitializeDatabaseConnection" /> method was not called.-or-The <see cref="T:WebMatrix.WebData.SimpleMembershipProvider" /> membership provider is not registered in the configuration of your site. For more information, contact your site's system administrator.</exception>
        public bool ConfirmAccount(string userName, string accountConfirmationToken) => WebSecurity.ConfirmAccount(userName, accountConfirmationToken);

        /// <summary>Creates a new membership account using the specified user name and password and optionally lets you specify that the user must explicitly confirm the account.</summary>
        /// <returns>A token that can be sent to the user to confirm the account.</returns>
        /// <param name="userName">The user name.</param>
        /// <param name="password">The password.</param>
        /// <param name="requireConfirmationToken">(Optional) true to specify that the account must be confirmed by using the token return value; otherwise, false. The default is false. </param>
        /// <exception cref="T:System.Web.Security.MembershipCreateUserException">
        /// <paramref name="username" /> is empty.-or-<paramref name="username" /> already has a membership account.-or-<paramref name="password" /> is empty.-or-<paramref name="password" /> is too long.-or-The database operation failed.</exception>
        /// <exception cref="T:System.InvalidOperationException">The <see cref="M:WebMatrix.WebData.SimpleMembershipProvider.Initialize(System.String,System.Collections.Specialized.NameValueCollection)" /> method was not called.-or-The <see cref="Overload:WebMatrix.WebData.WebSecurity.InitializeDatabaseConnection" /> method was not called.-or-The <see cref="T:WebMatrix.WebData.SimpleMembershipProvider" /> membership provider is not registered in the configuration of your site. For more information, contact your site's system administrator.</exception>
        public string CreateAccount(string userName, string password, bool requireConfirmationToken = false) => WebSecurity.CreateAccount(userName, password, requireConfirmationToken);

        /// <summary>Creates a new user profile entry and a new membership account.</summary>
        /// <returns>A token that can be sent to the user to confirm the user account.</returns>
        /// <param name="userName">The user name.</param>
        /// <param name="password">The password for the user.</param>
        /// <param name="propertyValues">(Optional) A dictionary that contains additional user attributes. The default is null.</param>
        /// <param name="requireConfirmationToken">(Optional) true to specify that the user account must be confirmed; otherwise, false. The default is false.</param>
        /// <exception cref="T:System.InvalidOperationException">The <see cref="M:WebMatrix.WebData.SimpleMembershipProvider.Initialize(System.String,System.Collections.Specialized.NameValueCollection)" /> method was not called.-or-The <see cref="Overload:WebMatrix.WebData.WebSecurity.InitializeDatabaseConnection" /> method was not called.-or-The <see cref="T:WebMatrix.WebData.SimpleMembershipProvider" /> membership provider is not registered in the configuration of your site. For more information, contact your site's system administrator.</exception>
        public string CreateUserAndAccount(string userName, string password, object propertyValues = null, bool requireConfirmationToken = false) 
            => WebSecurity.CreateUserAndAccount(userName, password, propertyValues, requireConfirmationToken);

        /// <summary>Generates a password reset token that can be sent to a user in email.</summary>
        /// <returns>A token to send to the user.</returns>
        /// <param name="userName">The user name.</param>
        /// <param name="tokenExpirationInMinutesFromNow">(Optional) The time in minutes until the password reset token expires. The default is 1440 (24 hours).</param>
        /// <exception cref="T:System.InvalidOperationException">The <see cref="M:WebMatrix.WebData.SimpleMembershipProvider.Initialize(System.String,System.Collections.Specialized.NameValueCollection)" /> method was not called.-or-The <see cref="Overload:WebMatrix.WebData.WebSecurity.InitializeDatabaseConnection" /> method was not called.-or-The <see cref="T:WebMatrix.WebData.SimpleMembershipProvider" /> membership provider is not registered in the configuration of your site. For more information, contact your site's system administrator.</exception>
        public string GeneratePasswordResetToken(string userName, int tokenExpirationInMinutesFromNow = 1440) 
            => WebSecurity.GeneratePasswordResetToken(userName, tokenExpirationInMinutesFromNow);

        /// <summary>Returns a value that indicates whether the specified user exists in the membership database.</summary>
        /// <returns>true if the <paramref name="username" /> exists in the user profile table; otherwise, false. </returns>
        /// <param name="userName">The user name.</param>
        /// <exception cref="T:System.InvalidOperationException">The <see cref="M:WebMatrix.WebData.SimpleMembershipProvider.Initialize(System.String,System.Collections.Specialized.NameValueCollection)" /> method was not called.-or-The <see cref="Overload:WebMatrix.WebData.WebSecurity.InitializeDatabaseConnection" /> method was not called.-or-The <see cref="T:WebMatrix.WebData.SimpleMembershipProvider" /> membership provider is not registered in the configuration of your site. For more information, contact your site's system administrator.</exception>
        public bool UserExists(string userName) => WebSecurity.UserExists(userName);

        /// <summary>Returns the ID for a user based on the specified user name.</summary>
        /// <returns>The user ID.</returns>
        /// <param name="userName">The user name.</param>
        /// <exception cref="T:System.InvalidOperationException">The <see cref="M:WebMatrix.WebData.SimpleMembershipProvider.Initialize(System.String,System.Collections.Specialized.NameValueCollection)" /> method was not called.-or-The <see cref="Overload:WebMatrix.WebData.WebSecurity.InitializeDatabaseConnection" /> method was not called.-or-The <see cref="T:WebMatrix.WebData.SimpleMembershipProvider" /> membership provider is not registered in the configuration of your site. For more information, contact your site's system administrator.</exception>
        public int GetUserId(string userName) => WebSecurity.GetUserId(userName);

        /// <summary>Returns a user ID from a password reset token.</summary>
        /// <returns>The user ID.</returns>
        /// <param name="token">The password reset token.</param>
        /// <exception cref="T:System.InvalidOperationException">The <see cref="M:WebMatrix.WebData.SimpleMembershipProvider.Initialize(System.String,System.Collections.Specialized.NameValueCollection)" /> method was not called.-or-The <see cref="Overload:WebMatrix.WebData.WebSecurity.InitializeDatabaseConnection" /> method was not called.-or-The <see cref="T:WebMatrix.WebData.SimpleMembershipProvider" /> membership provider is not registered in the configuration of your site. For more information, contact your site's system administrator.</exception>
        public int GetUserIdFromPasswordResetToken(string token) => WebSecurity.GetUserIdFromPasswordResetToken(token);

        /// <summary>Returns a value that indicates whether the user name of the logged-in user matches the specified user name.</summary>
        /// <returns>true if the logged-in user name matches <paramref name="userName" />; otherwise, false.</returns>
        /// <param name="userName">The user name to compare the logged-in user name to.</param>
        /// <exception cref="T:System.InvalidOperationException">The <see cref="M:WebMatrix.WebData.SimpleMembershipProvider.Initialize(System.String,System.Collections.Specialized.NameValueCollection)" /> method was not called.-or-The <see cref="Overload:WebMatrix.WebData.WebSecurity.InitializeDatabaseConnection" /> method was not called.-or-The <see cref="T:WebMatrix.WebData.SimpleMembershipProvider" /> membership provider is not registered in the configuration of your site. For more information, contact your site's system administrator.</exception>
        public bool IsCurrentUser(string userName) => WebSecurity.IsCurrentUser(userName);

        /// <summary>Returns a value that indicates whether the user has been confirmed.</summary>
        /// <returns>true if the user is confirmed; otherwise, false.</returns>
        /// <param name="userName">The user name.</param>
        public bool IsConfirmed(string userName) => WebSecurity.IsConfirmed(userName);
    }
}