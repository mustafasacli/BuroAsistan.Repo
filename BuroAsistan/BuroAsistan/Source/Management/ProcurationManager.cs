using BuroAsistan.Resources.ExceptionResources;
using BuroAsistan.Source.BO;
using BuroAsistan.Source.DL;
using Net.LawORM.Log.Error;
using System;
using System.Data;

namespace BuroAsistan.Source.Management
{
    /// <summary>
    /// Vekalet İşlemleri için kullanılan sınıf.
    /// </summary>
    class ProcurationManager
    {

        #region [ GetById method ]

        public Procurations GetById(int objId)
        {
            Procurations procur = null;
            try
            {
                using (ProcurationsDL procsDL = new ProcurationsDL())
                {
                    procur = procsDL.GetObjectById<Procurations>(objId);
                }
            }
            catch (Exception ex)
            {
                procur = null;
                FreeLogger log = new FreeLogger()
                {
                    LogCode = "2020",
                    Title = Rc.GetString("2020"),
                    LogType = LogTypes.Error
                };
                throw new FreeException(ex, log);
            }
            return procur;
        }

        #endregion


        #region [ SaveProcuration method ]

        internal int SaveProcuration(Procurations procuration)
        {
            int insertResult = -1;
            try
            {
                using (ProcurationsDL _procurationsdlDL = new ProcurationsDL())
                {
                    insertResult = _procurationsdlDL.InsertAndGetId(procuration);
                }
            }
            catch (Exception ex)
            {
                FreeLogger log = new FreeLogger()
                {
                    LogCode = "2021",
                    Title = Rc.GetString("2021"),
                    LogType = LogTypes.Error
                };
                throw new FreeException(ex, log);
            }
            return insertResult;
        }

        #endregion


        #region [ UpdateProcuration method ]

        internal int UpdateProcuration(Procurations procuration)
        {
            int updateResult = -1;
            try
            {
                using (ProcurationsDL _procurationsdlDL = new ProcurationsDL())
                {
                    updateResult = _procurationsdlDL.Update(procuration);
                }
            }
            catch (Exception ex)
            {
                FreeLogger log = new FreeLogger()
                {
                    LogCode = "2023",
                    Title = Rc.GetString("2023"),
                    LogType = LogTypes.Error
                };
                throw new FreeException(ex, log);
            }
            return updateResult;
        }

        #endregion


        #region [ DeleteProcuration method ]

        internal int DeleteProcuration(int procurationObjId)
        {
            int deleteResult = -1;
            try
            {
                using (ProcurationsDL _procurationsdlDL = new ProcurationsDL())
                {
                    Procurations p = new Procurations() { OBJID = procurationObjId, IsActive = 0 };
                    deleteResult = _procurationsdlDL.Update(p);
                }
            }
            catch (Exception ex)
            {
                FreeLogger log = new FreeLogger()
                {
                    LogCode = "2024",
                    Title = Rc.GetString("2024"),
                    LogType = LogTypes.Error
                };
                throw new FreeException(ex, log);
            }
            return deleteResult;
        }

        #endregion


        #region [ ActivateProcuration method ]

        internal int ActivateProcuration(int procurationObjId)
        {
            int deleteResult = -1;
            try
            {
                using (ProcurationsDL _procurationsdlDL = new ProcurationsDL())
                {
                    Procurations p = new Procurations() { OBJID = procurationObjId, IsActive = 1 };
                    deleteResult = _procurationsdlDL.Update(p);
                }
            }
            catch (Exception ex)
            {
                FreeLogger log = new FreeLogger()
                {
                    LogCode = "2025",
                    Title = Rc.GetString("2025"),
                    LogType = LogTypes.Error
                };
                throw new FreeException(ex, log);
            }
            return deleteResult;
        }

        #endregion


        #region [ GetProcurationList method ]

        internal DataTable GetProcurationList()
        {
            DataTable dtProcurations = null;
            try
            {
                using (ProcurationsDL _proclDL = new ProcurationsDL())
                {
                    dtProcurations = _proclDL.GetTable(new Procurations());
                }
            }
            catch (Exception ex)
            {
                FreeLogger log = new FreeLogger()
                {
                    LogCode = "2025",
                    Title = Rc.GetString("2025"),
                    LogType = LogTypes.Error
                };
                throw new FreeException(ex, log);
            }
            return dtProcurations;
        }

        #endregion

    }
}