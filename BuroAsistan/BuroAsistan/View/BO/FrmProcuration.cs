using BuroAsistan.Resources.ExceptionResources;
using BuroAsistan.Source.BO;
using BuroAsistan.Source.Management;
using BuroAsistan.Source.Variables;
using BuroAsistan.Util;
using BuroAsistan.View.BaseView;
using Net.LawORM.Log.Error;
using Net.LawORM.Log.Transaction;
using Net.LawORM.Logic.Extensions;
using System;
using System.Globalization;
using System.Resources;
using System.Threading;


namespace BuroAsistan.View.BO
{
    public partial class FrmProcuration : FrmBase
    {

        #region [ Private Fields ]

        private Procurations procuration = null;
        private ProcurationManager procurMan = null;
        private bool isFormLoaded = false;
        private int _ObjId = -1;

        #endregion


        #region [ FrmProcuration Ctors ]

        public FrmProcuration()
            : this(-1)
        { }

        public FrmProcuration(int procurationObjId)
        {
            try
            {
                InitializeComponent();
                _ObjId = procurationObjId;
                procurMan = new ProcurationManager();
                formRes = new ResourceManager("BuroAsistan.Resources.ControlResources.WinFormStrings", typeof(FrmProcuration).Assembly);
                messageRes = new ResourceManager("BuroAsistan.Resources.MessageResources.AppMessages", typeof(FrmProcuration).Assembly);

                this.lblProcurationId.Text = formRes.GetString("FrmProcuration.Caption");
                this.lblProcurationId.Text = formRes.GetString("FrmProcuration.lblProcurationId");
                this.lblNotaryId.Text = formRes.GetString("FrmProcuration.lblNotaryId");
                this.lblRemunerationId.Text = formRes.GetString("FrmProcuration.lblRemunerationId");
                this.lblDetails.Text = formRes.GetString("lblDetails");
                this.lblProcurationTime.Text = formRes.GetString("FrmProcuration.lblProcurationTime");
                this.btnSave.Text = _ObjId == -1 ? formRes.GetString("btnSave") : formRes.GetString("btnUpdate");
                this.btnCancel.Text = formRes.GetString("btnCancel");

            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2002"), "2002");

                MessageUtil.Error(
                    messageRes.GetString("FrmProcuration.Ctor.Error"),
                    messageRes.GetString("Error"));
            }
        }

        #endregion


        #region [ FormLoad method ]

        private void FormLoad(object sender, EventArgs e)
        {

            isFormLoaded = false;
            try
            {

                procuration = new Procurations();
                dtpProcurationTime.Value = DateTime.Now;
                if (_ObjId != -1)
                {
                    procuration = procurMan.GetById(_ObjId);
                    txtProcurationId.Text = procuration.ProcurationId.ToStr();
                    txtNotaryId.Text = procuration.NotaryId;
                    txtRemunerationId.Text = procuration.RemunerationId.ToStr();
                    txtDetails.Text = procuration.Details;
                    if (procuration.ProcurationTime != (new DateTime()))
                    {
                        dtpProcurationTime.Value = procuration.ProcurationTime;
                    }
                }
            }
            catch (FreeException)
            {
                MessageUtil.Error(
                    messageRes.GetString("FrmProcuration.Load.Error"),
                    messageRes.GetString("Error"));
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2003"), "2003");

                MessageUtil.Error(
                    messageRes.GetString("FrmProcuration.Load.Error"),
                    messageRes.GetString("Error"));
            }
            finally
            {
                isFormLoaded = true;
                procuration = new Procurations();
                if (_ObjId == -1)
                {
                    procuration.IsActive = 1;
                }
                else
                {
                    procuration.OBJID = _ObjId;
                }
            }
        }

        #endregion


        #region [ btnSave_Click method ]

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        #endregion


        #region [ Save method ]

        private void Save()
        {
            try
            {
                if (procuration.ProcurationId == 0 && txtProcurationId.Text.ToStr().NTrim().Length == 0)
                {
                    MessageUtil.Warn(
                        messageRes.GetString("FrmProcuration.Save.NoProcurationId"),
                        messageRes.GetString("Warning"));
                    return;
                }

                if (procuration.NotaryId.ToStr().NTrim().Length == 0 && txtNotaryId.Text.ToStr().NTrim().Length == 0)
                {
                    MessageUtil.Warn(
                        messageRes.GetString("FrmProcuration.Save.NoNotaryId"),
                        messageRes.GetString("Warning"));
                    return;
                }

                if (procuration.RemunerationId == 0 && txtRemunerationId.Text.ToStr().NTrim().Length == 0)
                {
                    MessageUtil.Warn(
                        messageRes.GetString("FrmProcuration.Save.NoRemunerationId"),
                        messageRes.GetString("Warning"));
                    return;
                }

                int _Id = -1;
                if (_ObjId == -1)
                {
                    procuration.CreationTime = DateTime.Now;
                    _Id = procurMan.SaveProcuration(procuration);
                }
                else
                {
                    if (procuration.ChangeSetCount > 1)
                    {
                        procurMan.UpdateProcuration(procuration);
                    }
                }

                FreeTransactionLog transLogger = new FreeTransactionLog(AppVariables.CurrentUser.OBJID)
                {
                    FormName = this.Name,
                    TransactionType = _ObjId == -1 ? TransactionTypes.Insert : TransactionTypes.Update,
                    ControlName = btnSave.Name,
                    ControlTag = btnSave.Tag.ToStr(),
                    LogObject = _ObjId == -1 ? _Id : _ObjId
                };
                transLogger.Insert();

                MessageUtil.Info(
                    messageRes.GetString(_ObjId == -1 ? "FrmProcuration.Save.Success" : "FrmProcuration.Update.Success"),
                    messageRes.GetString("Info"));

                this.Close();
            }
            catch (FreeException)
            {
                MessageUtil.Error(
                    messageRes.GetString("FrmProcuration.Save.Error"),
                    messageRes.GetString("Error"));
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2002"), "2002");

                MessageUtil.Error(
                    messageRes.GetString("FrmProcuration.Save.Error"),
                    messageRes.GetString("Error"));
            }
        }

        #endregion


        #region [ btnCancel_Click method ]

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region [ Text Changed methods ]

        private void txtProcurationId_TextChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
            {
                procuration.ProcurationId = txtProcurationId.Text.ToInt();
            }
        }

        private void txtNotaryId_TextChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
            {
                procuration.NotaryId = txtNotaryId.Text;
            }
        }

        private void txtRemunerationId_TextChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
            {
                procuration.RemunerationId = txtRemunerationId.Text.ToInt();
            }
        }

        private void txtDetails_TextChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
            {
                procuration.Details = txtDetails.Text;
            }
        }

        #endregion


        #region [ Numeric KeyPress methods ]

        private void txtProcurationId_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = !(((int)e.KeyChar >= 47 && (int)e.KeyChar <= 58) || ((int)e.KeyChar == 8));
        }

        private void txtRemunerationId_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = !(((int)e.KeyChar >= 47 && (int)e.KeyChar <= 58) || ((int)e.KeyChar == 8));
        }

        #endregion

        private void dtpProcurationTime_ValueChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
            {
                procuration.ProcurationTime = dtpProcurationTime.Value;
            }
        }

    }
}