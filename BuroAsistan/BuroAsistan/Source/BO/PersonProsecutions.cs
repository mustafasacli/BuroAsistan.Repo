using System;
using BuroAsistan.Source.DL;
using Net.LawORM.Entity.Base;

namespace BuroAsistan.Source.BO
{
    public class PersonProsecutions : BaseBO
    {
        private int _OBJID;
        public int OBJID
        {
            set { _OBJID = value; OnPropertyChanged("OBJID"); }
            get { return _OBJID; }
        }

        private int _PresecutionId;
        public int PresecutionId
        {
            set { _PresecutionId = value; OnPropertyChanged("PresecutionId"); }
            get { return _PresecutionId; }
        }

        private int _PersonId;
        public int PersonId
        {
            set { _PersonId = value; OnPropertyChanged("PersonId"); }
            get { return _PersonId; }
        }

        public override string GetTableName()
        {
            return "PersonProsecutions";
        }

        public override string GetIdColumn()
        {
            return "OBJID";
        }

        internal int Insert()
        {
            try
            {
                using (PersonProsecutionsDL _personprosecutionsdlDL = new PersonProsecutionsDL())
                {
                    return _personprosecutionsdlDL.Insert(this);
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
                using (PersonProsecutionsDL _personprosecutionsdlDL = new PersonProsecutionsDL())
                {
                    return _personprosecutionsdlDL.InsertAndGetId(this);
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
                using (PersonProsecutionsDL _personprosecutionsdlDL = new PersonProsecutionsDL())
                {
                    return _personprosecutionsdlDL.Update(this);
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
                using (PersonProsecutionsDL _personprosecutionsdlDL = new PersonProsecutionsDL())
                {
                    return _personprosecutionsdlDL.Delete(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}