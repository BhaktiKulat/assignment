using System;

namespace StationeryStoreManagementSystem
{
    class LoginFailedException : Exception
    {
        public LoginFailedException()
            : base("Login Failed! Account Locked.")
        {
        }
    }
}
