using BA.UserManagement.Source.BO;

namespace BuroAsistan.Source.Variables
{
    static class AppVariables
    {
        private static Users _CurrentUser = null;
        public static Users CurrentUser
        {
            get { return AppVariables._CurrentUser; }
            set { AppVariables._CurrentUser = value; }
        }

    }
}
