namespace LoginUser
{
    public class LoginUsers
    {
        public string Login(string username, string password)
        {
            string result = "";
            if (username == "ram1256" && password == "ram@1256")
            {
                result = "Login Success";

            }
            else
            {
                result = "Login Failed";
            }
            return result;
        }
    }
}
