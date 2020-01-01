using System;
using BuroAsistan.Source.DL;
using Net.LawORM.Entity.Base;

namespace BuroAsistan.Source.BO
{
    public class Prosecutions : BaseBO
    {
        private int _OBJID;
        public int OBJID
        {
            set { _OBJID = value; OnPropertyChanged("OBJID"); }
            get { return _OBJID; }
        }

        private string _MasterNo;
        public string MasterNo
        {
            set { _MasterNo = value; OnPropertyChanged("MasterNo"); }
            get { return _MasterNo; }
        }

        private string _DecisionNo;
        public string DecisionNo
        {
            set { _DecisionNo = value; OnPropertyChanged("DecisionNo"); }
            get { return _DecisionNo; }
        }

        private byte _IsDefendant;
        public byte IsDefendant
        {
            set { _IsDefendant = value; OnPropertyChanged("IsDefendant"); }
            get { return _IsDefendant; }
        }

        private byte _ProsecutionType;
        public byte ProsecutionType
        {
            set { _ProsecutionType = value; OnPropertyChanged("ProsecutionType"); }
            get { return _ProsecutionType; }
        }

        private string _Details;
        public string Details
        {
            set { _Details = value; OnPropertyChanged("Details"); }
            get { return _Details; }
        }

        private byte _IsActive;
        public byte IsActive
        {
            set { _IsActive = value; OnPropertyChanged("IsActive"); }
            get { return _IsActive; }
        }

        public override string GetTableName()
        {
            return "Prosecutions";
        }

        public override string GetIdColumn()
        {
            return "OBJID";
        }

        internal int Insert()
        {
            try
            {
                using (ProsecutionsDL _prosecutionsdlDL = new ProsecutionsDL())
                {
                    return _prosecutionsdlDL.Insert(this);
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
                using (ProsecutionsDL _prosecutionsdlDL = new ProsecutionsDL())
                {
                    return _prosecutionsdlDL.InsertAndGetId(this);
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
                using (ProsecutionsDL _prosecutionsdlDL = new ProsecutionsDL())
                {
                    return _prosecutionsdlDL.Update(this);
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
                using (ProsecutionsDL _prosecutionsdlDL = new ProsecutionsDL())
                {
                    return _prosecutionsdlDL.Delete(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}