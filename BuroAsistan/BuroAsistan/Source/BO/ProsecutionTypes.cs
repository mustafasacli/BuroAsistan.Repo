using System;
using BuroAsistan.Source.DL;
using Net.LawORM.Entity.Base;

namespace BuroAsistan.Source.BO
{
    public class ProsecutionTypes : BaseBO
    {
        private byte _OBJID;
        public byte OBJID
        {
            set { _OBJID = value; OnPropertyChanged("OBJID"); }
            get { return _OBJID; }
        }

        private string _ProsecutionTypeName;
        public string ProsecutionTypeName
        {
            set { _ProsecutionTypeName = value; OnPropertyChanged("ProsecutionTypeName"); }
            get { return _ProsecutionTypeName; }
        }

        public override string GetTableName()
        {
            return "ProsecutionTypes";
        }

        public override string GetIdColumn()
        {
            return "OBJID";
        }

        internal int Insert()
        {
            try
            {
                using (ProsecutionTypesDL _prosecutiontypesdlDL = new ProsecutionTypesDL())
                {
                    return _prosecutiontypesdlDL.Insert(this);
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
                using (ProsecutionTypesDL _prosecutiontypesdlDL = new ProsecutionTypesDL())
                {
                    return _prosecutiontypesdlDL.InsertAndGetId(this);
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
                using (ProsecutionTypesDL _prosecutiontypesdlDL = new ProsecutionTypesDL())
                {
                    return _prosecutiontypesdlDL.Update(this);
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
                using (ProsecutionTypesDL _prosecutiontypesdlDL = new ProsecutionTypesDL())
                {
                    return _prosecutiontypesdlDL.Delete(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}