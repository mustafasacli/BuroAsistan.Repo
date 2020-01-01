using Net.LawORM.Entity.Base;
using System;

namespace BuroAsistan.Source.BO
{
    internal class Procurations : BaseBO
    {
        private int _OBJID;

        public int OBJID
        {
            set { _OBJID = value; OnPropertyChanged("OBJID"); }
            get { return _OBJID; }
        }

        private int _ProcurationId;

        public int ProcurationId
        {
            set { _ProcurationId = value; OnPropertyChanged("ProcurationId"); }
            get { return _ProcurationId; }
        }

        private string _NotaryId;

        public string NotaryId
        {
            set { _NotaryId = value; OnPropertyChanged("NotaryId"); }
            get { return _NotaryId; }
        }

        private int _RemunerationId;

        public int RemunerationId
        {
            set { _RemunerationId = value; OnPropertyChanged("RemunerationId"); }
            get { return _RemunerationId; }
        }

        private string _Details;

        public string Details
        {
            set { _Details = value; OnPropertyChanged("Details"); }
            get { return _Details; }
        }

        private DateTime _ProcurationTime;

        public DateTime ProcurationTime
        {
            set { _ProcurationTime = value; OnPropertyChanged("ProcurationTime"); }
            get { return _ProcurationTime; }
        }


        private DateTime _CreationTime;

        public DateTime CreationTime
        {
            set { _CreationTime = value; OnPropertyChanged("CreationTime"); }
            get { return _CreationTime; }
        }

        private int _IsActive;

        public int IsActive
        {
            set { _IsActive = value; OnPropertyChanged("IsActive"); }
            get { return _IsActive; }
        }

        public override string GetTableName()
        {
            return "Procurations";
        }

        public override string GetIdColumn()
        {
            return "OBJID";
        }
    }
}