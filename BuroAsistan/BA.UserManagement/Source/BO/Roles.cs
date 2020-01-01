using BA.UserManagement.Source.DL;
using Net.LawORM.Entity.Base;
using System;

namespace BA.UserManagement.Source.BO
{
    public class Roles : BaseBO
    {
        private int _OBJID;
        public int OBJID
        {
            set { _OBJID = value; OnPropertyChanged("OBJID"); }
            get { return _OBJID; }
        }

        private string _RoleName;
        public string RoleName
        {
            set { _RoleName = value; OnPropertyChanged("RoleName"); }
            get { return _RoleName; }
        }

        private int _IsActive;
        public int IsActive
        {
            set { _IsActive = value; OnPropertyChanged("IsActive"); }
            get { return _IsActive; }
        }

        public override string GetTableName()
        {
            return "Roles";
        }

        public override string GetIdColumn()
        {
            return "OBJID";
        }

        internal int Insert()
        {
            try
            {
                using (RolesDL _rolesdlDL = new RolesDL())
                {
                    return _rolesdlDL.Insert(this);
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
                using (RolesDL _rolesdlDL = new RolesDL())
                {
                    return _rolesdlDL.InsertAndGetId(this);
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
                using (RolesDL _rolesdlDL = new RolesDL())
                {
                    return _rolesdlDL.Update(this);
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
                using (RolesDL _rolesdlDL = new RolesDL())
                {
                    return _rolesdlDL.Delete(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
