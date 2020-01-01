using BuroAsistan.Source.DL;
using Net.LawORM.Entity.Base;

namespace BuroAsistan.Source.BO
{
    internal class PersonProcurations : BaseBO
    {
        private int _OBJID;
        public int OBJID
        {
            set { _OBJID = value; OnPropertyChanged("OBJID"); }
            get { return _OBJID; }
        }

        private int _PersonId;
        public int PersonId
        {
            set { _PersonId = value; OnPropertyChanged("PersonId"); }
            get { return _PersonId; }
        }

        private int _ProcurationId;
        public int ProcurationId
        {
            set { _ProcurationId = value; OnPropertyChanged("ProcurationId"); }
            get { return _ProcurationId; }
        }

        private int _IsActive;
        public int IsActive
        {
            set { _IsActive = value; OnPropertyChanged("IsActive"); }
            get { return _IsActive; }
        }

        public override string GetTableName()
        {
            return "PersonProcurations";
        }

        public override string GetIdColumn()
        {
            return "OBJID";
        }

        internal int Insert()
        {
            try
            {
                using (PersonProcurationsDL _personprocurationsdlDL = new PersonProcurationsDL())
                {
                    return _personprocurationsdlDL.Insert(this);
                }
            }
            catch
            {
                throw;
            }
        }

        internal int InsertAndGetId()
        {
            try
            {
                using (PersonProcurationsDL _personprocurationsdlDL = new PersonProcurationsDL())
                {
                    return _personprocurationsdlDL.InsertAndGetId(this);
                }
            }
            catch
            {
                throw;
            }
        }

        internal int Update()
        {
            try
            {
                using (PersonProcurationsDL _personprocurationsdlDL = new PersonProcurationsDL())
                {
                    return _personprocurationsdlDL.Update(this);
                }
            }
            catch
            {
                throw;
            }
        }

        internal int Delete()
        {
            try
            {
                using (PersonProcurationsDL _personprocurationsdlDL = new PersonProcurationsDL())
                {
                    return _personprocurationsdlDL.Delete(this);
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
