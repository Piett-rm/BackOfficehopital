namespace BackOfficeHopital.Core
{
    public class LoginJWT
    {
        public string username { get; set; }
        public string password { get; set; }

        public LoginJWT( string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}