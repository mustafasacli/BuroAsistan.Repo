using BA.ResourceManagement;
using BA.UserManagement.Source.BO;
using BA.UserManagement.Source.DL;
using Net.LawORM.Log.Error;
using System;

namespace BA.UserManagement
{
    public class UserManager
    {
        public Users GetUser(string username, string password)
        {
            Users user = null;
            try
            {
                using (UsersDL usersDL = new UsersDL())
                {
                    user = usersDL.GetUser(username, password);
                }
            }
            catch (Exception ex)
            {
                FreeLogger log = new FreeLogger()
                {
                    LogCode = "1000",
                    Title = Rc.GetString("1000")
                };
                throw new FreeException(ex, log);
            }
            return user;
        }

    }
}
