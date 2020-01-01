using BuroAsistan.Resources.ExceptionResources;
using BuroAsistan.Source.BO;
using BuroAsistan.Source.DL;
using BuroAsistan.Source.QO;
using Net.LawORM.Log.Error;
using System;
using System.Data;

namespace BuroAsistan.Source.Management
{
    /// <summary>
    /// Kisi Islemleri için kullanılan Manager sınıfı.
    /// </summary>
    internal class PersonManager
    {

        #region [ GetById method ]

        internal Person GetById(int personId)
        {
            Person p = null;
            try
            {
                using (PersonDL _persondlDL = new PersonDL())
                {
                    p = _persondlDL.GetObjectById<Person>(personId);
                }
            }
            catch (Exception ex)
            {
                FreeLogger log = new FreeLogger()
                {
                    LogCode = "2005",
                    Title = Rc.GetString("2005"),
                    LogType = LogTypes.Error
                };
                throw new FreeException(ex, log);
            }
            return p;
        }

        #endregion


        #region [ SavePerson method ]

        internal int SavePerson(Person p)
        {
            int insertResult = -1;
            try
            {
                using (PersonDL _persondlDL = new PersonDL())
                {
                    insertResult = _persondlDL.InsertAndGetId(p);
                }
            }
            catch (Exception ex)
            {
                FreeLogger log = new FreeLogger()
                {
                    LogCode = "2006",
                    Title = Rc.GetString("2006"),
                    LogType = LogTypes.Error
                };
                throw new FreeException(ex, log);
            }
            return insertResult;
        }

        #endregion


        #region [ UpdatePerson method ]

        internal int UpdatePerson(Person p)
        {
            int updateResult = -1;
            try
            {
                using (PersonDL _persondlDL = new PersonDL())
                {
                    updateResult = _persondlDL.Update(p);
                }
            }
            catch (Exception ex)
            {
                FreeLogger log = new FreeLogger()
                {
                    LogCode = "2007",
                    Title = Rc.GetString("2007"),
                    LogType = LogTypes.Error
                };
                throw new FreeException(ex, log);
            }
            return updateResult;
        }

        #endregion


        #region [ DeletePerson method ]

        internal int DeletePerson(int personId)
        {
            int deleteResult = -1;
            try
            {
                Person p = new Person()
                {
                    OBJID = personId,
                    IsActive = 0
                };
                using (PersonDL _persondlDL = new PersonDL())
                {
                    deleteResult = _persondlDL.Update(p);
                }
            }
            catch (Exception ex)
            {
                FreeLogger log = new FreeLogger()
                {
                    LogCode = "2008",
                    Title = Rc.GetString("2008"),
                    LogType = LogTypes.Error
                };
                throw new FreeException(ex, log);
            }
            return deleteResult;
        }

        #endregion


        #region [ ActivatePerson method ]

        internal int ActivatePerson(int personId)
        {
            int activateResult = -1;
            try
            {
                Person p = new Person()
                {
                    OBJID = personId,
                    IsActive = 1
                };
                using (PersonDL _persondlDL = new PersonDL())
                {
                    activateResult = _persondlDL.Update(p);
                }
            }
            catch (Exception ex)
            {
                FreeLogger log = new FreeLogger()
                {
                    LogCode = "2009",
                    Title = Rc.GetString("2009"),
                    LogType = LogTypes.Error
                };
                throw new FreeException(ex, log);
            }
            return activateResult;
        }

        #endregion


        #region [ GetPersonList method ]

        internal DataTable GetPersonList()
        {
            DataTable dtPersons = null;
            try
            {
                using (PersonDL _persondlDL = new PersonDL())
                {
                    dtPersons = _persondlDL.GetResultSetOfQuery(Crud.GetPersonList()).Tables[0];
                }
            }
            catch (Exception ex)
            {
                FreeLogger log = new FreeLogger()
                {
                    LogCode = "2010",
                    Title = Rc.GetString("2010"),
                    LogType = LogTypes.Error
                };
                throw new FreeException(ex, log);
            }
            return dtPersons;
        }

        #endregion


        #region [ GetPersonByActivation method ]

        public DataTable GetPersonByActivation(bool isActive)
        {
            DataTable dtPersons = null;
            try
            {
                using (PersonDL _persondlDL = new PersonDL())
                {
                    if (isActive)
                    {
                        dtPersons = _persondlDL.GetResultSetOfQuery(Crud.GetPersonByActivation()).Tables[0];
                    }
                    else
                    {
                        dtPersons = _persondlDL.GetResultSetOfQuery(Crud.GetPersonList()).Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                FreeLogger log = new FreeLogger()
                {
                    LogCode = "2039",
                    Title = Rc.GetString("2039"),
                    LogType = LogTypes.Error
                };
                throw new FreeException(ex, log);
            }
            return dtPersons;
        }

        #endregion

    }
}