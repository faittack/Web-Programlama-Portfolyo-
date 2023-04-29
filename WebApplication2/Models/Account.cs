namespace WebApplication2.Models
{
    public class Account
    {
        public int username { get; set; }

        public int password { get; set; }

        public string ErrorMesaj{ get; set; }

        public bool UserLoginControll(string username, string password)
        {
            

            if (username =="admin" && password == "1234") {
                return true;
            }
            else
            {
                ErrorMesaj = " Kullanıcı adı ya da şifre hatalı";
                return false;
            }
               
           
        }
    }
}
