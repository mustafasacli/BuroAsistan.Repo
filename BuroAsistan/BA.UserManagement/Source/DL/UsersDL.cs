using BA.UserManagement.Source.BO;
using Net.LawORM.Entity.QueryBuilding;
using Net.LawORM.Logic.BaseDal;
using Net.LawORM.Logic.Extensions;
using System;
using System.Data;

namespace BA.UserManagement.Source.DL
{
    internal class UsersDL : MainDL
    {
        internal UsersDL()
            : base()
        {
        }

        public Users GetUser(string username, string password)
        {
            Users user = null;
            try
            {
                user = new Users()
                {
                    UserName = username,
                    Pass = password,
                    IsActive = 1
                };
                QueryBuilder qB = CreateQueryBuilder(QueryTypes.SelectWhereChangeColumns, user);
                user = null;

                DataTable dt = base.GetResultSetOfQuery(qB.QueryString, qB.Properties).Tables[0];
                DataRow row = dt.Rows[0];
                user = new Users()
                {
                    OBJID = row["OBJID"].ToInt(),
                    UserName = row["UserName"].ToStr(),
                    FirstName = row["FirstName"].ToStr(),
                    LastName = row["LastName"].ToStr(),
                    UserType = row["UserType"].ToInt(),
                    IsActive = row["IsActive"].ToInt()
                };
            }
            catch (Exception)
            {
                user = null;
                throw;
            }
            return user;
        }
    }
}