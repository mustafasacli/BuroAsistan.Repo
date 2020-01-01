using BA.UserManagement.Source.DL;
using Net.LawORM.Entity.Base;
using System;

namespace BA.UserManagement.Source.BO
{
    public class UserRoles : BaseBO
    {
        private int _OBJID;
        public int OBJID
        {
            set { _OBJID = value; OnPropertyChanged("OBJID"); }
            get { return _OBJID; }
        }

        private int _UserId;
        public int UserId
        {
            set { _UserId = value; OnPropertyChanged("UserId"); }
            get { return _UserId; }
        }

        private int _RoleId;
        public int RoleId
        {
            set { _RoleId = value; OnPropertyChanged("RoleId"); }
            get { return _RoleId; }
        }

        public override string GetTableName()
        {
            return "UserRoles";
        }

        public override string GetIdColumn()
        {
            return "OBJID";
        }

        internal int Insert()
        {
            try
            {
                using (UserRolesDL _userrolesdlDL = new UserRolesDL())
                {
                    return _userrolesdlDL.Insert(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal int InsertAndGetId()
        {
            try
            {
                using (UserRolesDL _userrolesdlDL = new UserRolesDL())
                {
                    return _userrolesdlDL.InsertAndGetId(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal int Update()
        {
            try
            {
                using (UserRolesDL _userrolesdlDL = new UserRolesDL())
                {
                    return _userrolesdlDL.Update(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal int Delete()
        {
            try
            {
                using (UserRolesDL _userrolesdlDL = new UserRolesDL())
                {
                    return _userrolesdlDL.Delete(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
