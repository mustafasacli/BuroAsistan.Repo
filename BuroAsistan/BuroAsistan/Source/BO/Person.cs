using Net.LawORM.Entity.Base;
using System;

namespace BuroAsistan.Source.BO
{
    internal class Person : BaseBO
    {
        private int _OBJID;

        public int OBJID
        {
            set { _OBJID = value; OnPropertyChanged("OBJID"); }
            get { return _OBJID; }
        }

        private string _FirstName;

        public string FirstName
        {
            set { _FirstName = value; OnPropertyChanged("FirstName"); }
            get { return _FirstName; }
        }

        private string _ForeName;

        public string ForeName
        {
            set { _ForeName = value; OnPropertyChanged("ForeName"); }
            get { return _ForeName; }
        }

        private string _LastName;

        public string LastName
        {
            set { _LastName = value; OnPropertyChanged("LastName"); }
            get { return _LastName; }
        }

        private string _IdentityNo;

        public string IdentityNo
        {
            set { _IdentityNo = value; OnPropertyChanged("IdentityNo"); }
            get { return _IdentityNo; }
        }

        private DateTime _CreationTime;

        public DateTime CreationTime
        {
            set { _CreationTime = value; OnPropertyChanged("CreationTime"); }
            get { return _CreationTime; }
        }

        private string _Adress;

        public string Adress
        {
            set { _Adress = value; OnPropertyChanged("Adress"); }
            get { return _Adress; }
        }

        private string _Details;

        public string Details
        {
            set { _Details = value; OnPropertyChanged("Details"); }
            get { return _Details; }
        }

        private int _IsActive;

        public int IsActive
        {
            set { _IsActive = value; OnPropertyChanged("IsActive"); }
            get { return _IsActive; }
        }

        public override string GetTableName()
        {
            return "Person";
        }

        public override string GetIdColumn()
        {
            return "OBJID";
        }
    }
}