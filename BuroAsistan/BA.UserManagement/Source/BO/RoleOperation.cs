using BA.UserManagement.Source.DL;
using Net.LawORM.Entity.Base;
using System;

namespace BA.UserManagement.Source.BO
{
    public class RoleOperation : BaseBO
    {
        private int _OBJID;
        public int OBJID
        {
            set { _OBJID = value; OnPropertyChanged("OBJID"); }
            get { return _OBJID; }
        }

        private int _RoleId;
        public int RoleId
        {
            set { _RoleId = value; OnPropertyChanged("RoleId"); }
            get { return _RoleId; }
        }

        private int _OperationId;
        public int OperationId
        {
            set { _OperationId = value; OnPropertyChanged("OperationId"); }
            get { return _OperationId; }
        }

        public override string GetTableName()
        {
            return "RoleOperation";
        }

        public override string GetIdColumn()
        {
            return "OBJID";
        }

        internal int Insert()
        {
            try
            {
                using (RoleOperationDL _roleoperationdlDL = new RoleOperationDL())
                {
                    return _roleoperationdlDL.Insert(this);
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
                using (RoleOperationDL _roleoperationdlDL = new RoleOperationDL())
                {
                    return _roleoperationdlDL.InsertAndGetId(this);
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
                using (RoleOperationDL _roleoperationdlDL = new RoleOperationDL())
                {
                    return _roleoperationdlDL.Update(this);
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
                using (RoleOperationDL _roleoperationdlDL = new RoleOperationDL())
                {
                    return _roleoperationdlDL.Delete(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
