using BA.UserManagement.Source.DL;
using Net.LawORM.Entity.Base;
using System;

namespace BA.UserManagement.Source.BO
{
    public class UserTypes : BaseBO
    {
        private int _OBJID;
        public int OBJID
        {
            set { _OBJID = value; OnPropertyChanged("OBJID"); }
            get { return _OBJID; }
        }

        private string _UserTypeName;
        public string UserTypeName
        {
            set { _UserTypeName = value; OnPropertyChanged("UserTypeName"); }
            get { return _UserTypeName; }
        }

        private int _IsActive;
        public int IsActive
        {
            set { _IsActive = value; OnPropertyChanged("IsActive"); }
            get { return _IsActive; }
        }

        public override string GetTableName()
        {
            return "UserTypes";
        }

        public override string GetIdColumn()
        {
            return "OBJID";
        }

        internal int Insert()
        {
            try
            {
                using (UserTypesDL _usertypesdlDL = new UserTypesDL())
                {
                    return _usertypesdlDL.Insert(this);
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
                using (UserTypesDL _usertypesdlDL = new UserTypesDL())
                {
                    return _usertypesdlDL.InsertAndGetId(this);
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
                using (UserTypesDL _usertypesdlDL = new UserTypesDL())
                {
                    return _usertypesdlDL.Update(this);
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
                using (UserTypesDL _usertypesdlDL = new UserTypesDL())
                {
                    return _usertypesdlDL.Delete(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
