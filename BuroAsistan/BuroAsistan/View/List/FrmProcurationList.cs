using BuroAsistan.Resources.ExceptionResources;
using BuroAsistan.Source.Management;
using BuroAsistan.Source.Variables;
using BuroAsistan.Util;
using BuroAsistan.View.BaseView;
using BuroAsistan.View.BO;
using Net.LawORM.Log.Error;
using Net.LawORM.Log.Transaction;
using Net.LawORM.Logic.Extensions;
using System;
using System.Data;
using System.Resources;

namespace BuroAsistan.View.List
{
    public partial class FrmProcurationList : FrmBase
    {

        #region [ Private Fields ]

        DataTable dtProcurationList = null;
        DataTable dtSearchProcurationList = null;

        ProcurationManager procurMan = null;

        #endregion


        #region [ FrmProcurationList Ctor ]

        public FrmProcurationList()
        {
            try
            {
                InitializeComponent();
                procurMan = new ProcurationManager();
                formRes = new ResourceManager("BuroAsistan.Resources.ControlResources.WinFormStrings", typeof(FrmProcurationList).Assembly);
                messageRes = new ResourceManager("BuroAsistan.Resources.MessageResources.AppMessages", typeof(FrmProcurationList).Assembly);

                this.Text = formRes.GetString("FrmProcurationList.Caption");
                this.btnAdd.Text = formRes.GetString("btnAdd");
                this.btnUpdate.Text = formRes.GetString("btnUpdate");
                this.btnDelete.Text = formRes.GetString("btnDelete");
                this.btnActivate.Text = formRes.GetString("btnActivate");
                this.btnRefreshList.Text = formRes.GetString("btnRefreshList");

                this.addToolStripMenuItem.Text = formRes.GetString("btnAdd");
                this.updateToolStripMenuItem.Text = formRes.GetString("btnUpdate");
                this.deleteToolStripMenuItem.Text = formRes.GetString("btnDelete");
                this.activateToolStripMenuItem.Text = formRes.GetString("btnActivate");
                this.refreshListToolStripMenuItem.Text = formRes.GetString("btnRefreshList");

                this.grpSearchOptions.Text = formRes.GetString("grpSearchOptions");
                this.rdbtnContains.Text = formRes.GetString("rdbtnContains");
                this.rdbtnExactMatch.Text = formRes.GetString("rdbtnExactMatch");
                this.lblSearchType.Text = formRes.GetString("lblSearchType");
                this.lblSearchText.Text = formRes.GetString("lblSearchText");
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2026"), "2026", AppVariables.CurrentUser.OBJID);

                MessageUtil.Error(
                    messageRes.GetString("FrmProcurationList.Ctor.Error"),
                    messageRes.GetString("Error"));
            }
        }

        #endregion


        #region [ FormLoad method ]

        private void FormLoad(object sender, EventArgs e)
        {
            try
            {
                rdbtnExactMatch.Checked = true;
                cmbxSearchType.SetItemSource(formRes.GetString("FrmProcurationList.cmbxSearchType.ItemSource"), '-', '*');
                cmbxSearchType.SelectedIndex = -1;
                RefreshProcurations();
            }
            catch (FreeException)
            {
                MessageUtil.Error(
                    messageRes.GetString("FrmProcurationList.Load.Error"),
                    messageRes.GetString("Error"));
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2027"), "2027", AppVariables.CurrentUser.OBJID);

                MessageUtil.Error(
                    messageRes.GetString("FrmProcurationList.Load.Error"),
                    messageRes.GetString("Error"));
            }
        }

        #endregion


        #region [ btnAdd_Click method ]

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProcuration();
        }

        #endregion


        #region [ AddProcuration method ]

        private void AddProcuration()
        {
            try
            {
                FrmProcuration frm_procuration = new FrmProcuration();
                frm_procuration.FormClosed += frm_Procuration_FormClosed;
                frm_procuration.ShowDialog();
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2028"), "2028", AppVariables.CurrentUser.OBJID);

                MessageUtil.Error(
                    messageRes.GetString("FrmProcurationList.btnAdd_Click.Error"),
                    messageRes.GetString("Error"));
            }
        }

        #endregion


        #region [ btnUpdate_Click method ]

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProcuration();
        }

        #endregion


        #region [ UpdateProcuration method ]

        private void UpdateProcuration()
        {
            try
            {
                if (grdProcurations.SelectedRows.Count > 0)
                {
                    int procurationId = grdProcurations.SelectedRows[0].Cells["OBJID"].Value.ToInt();
                    FrmProcuration frm_procuration = new FrmProcuration(procurationId);
                    frm_procuration.FormClosed += frm_Procuration_FormClosed;
                    frm_procuration.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2029"), "2029", AppVariables.CurrentUser.OBJID);

                MessageUtil.Error(
                    messageRes.GetString("FrmProcurationList.btnUpdate_Click.Error"),
                    messageRes.GetString("Error"));
            }
        }

        #endregion


        #region [ frm_person_FormClosed method ]

        private void frm_Procuration_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            try
            {
                RefreshProcurations();
            }
            catch (FreeException)
            {
                MessageUtil.Error(
                    messageRes.GetString("FrmProcurationList.frm_Procuration_FormClosed.Error"),
                    messageRes.GetString("Error"));
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2030"), "2030", AppVariables.CurrentUser.OBJID);

                MessageUtil.Error(
                    messageRes.GetString("FrmProcurationList.frm_Procuration_FormClosed.Error"),
                    messageRes.GetString("Error"));
            }
        }

        #endregion


        #region [ btnDelete_Click method ]

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        #endregion


        #region [ Delete method ]

        private void Delete()
        {
            try
            {
                if (grdProcurations.SelectedRows.Count > 0)
                {
                    int activateState = grdProcurations.SelectedRows[0].Cells["IsActive"].Value.ToInt();

                    if (activateState == 0)
                    {
                        MessageUtil.Warn(messageRes.GetString("FrmProcurationList.Delete.PersonAlreadyDeleted"),
                            messageRes.GetString("Warning"));
                        return;
                    }

                    int procurationId = grdProcurations.SelectedRows[0].Cells["OBJID"].Value.ToInt();

                    System.Windows.Forms.DialogResult dr = MessageUtil.ConfirmYesNo(
                        messageRes.GetString("FrmProcurationList.Delete.Confirm"),
                        messageRes.GetString("Confirm"));

                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {
                        procurMan.DeleteProcuration(procurationId);
                        FreeTransactionLog transLogger = new FreeTransactionLog(AppVariables.CurrentUser.OBJID)
                        {
                            FormName = this.Name,
                            TransactionType = TransactionTypes.Delete,
                            ControlName = btnDelete.Name,
                            ControlTag = btnDelete.Tag.ToStr(),
                            LogObject = procurationId
                        };
                        transLogger.Insert();
                        RefreshProcurations();
                        MessageUtil.Info(
                            messageRes.GetString("FrmProcurationList.Delete.Success"),
                            messageRes.GetString("Info"));
                    }
                }
            }
            catch (FreeException)
            {
                MessageUtil.Error(
                    messageRes.GetString("FrmProcurationList.Delete.Error"),
                    messageRes.GetString("Error"));
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2031"), "2031", AppVariables.CurrentUser.OBJID);

                MessageUtil.Error(
                    messageRes.GetString("FrmProcurationList.Delete.Error"),
                    messageRes.GetString("Error"));
            }
        }

        #endregion


        #region [ btnActivate_Click method ]

        private void btnActivate_Click(object sender, EventArgs e)
        {
            ActivateProcuration();
        }

        #endregion


        #region [ Activate method ]

        private void ActivateProcuration()
        {
            try
            {
                if (grdProcurations.SelectedRows.Count > 0)
                {
                    int activateState = grdProcurations.SelectedRows[0].Cells["IsActive"].Value.ToInt();

                    if (activateState == 1)
                    {
                        MessageUtil.Warn(messageRes.GetString("FrmProcurationList.Activate.PersonAlreadyActivated"),
                            messageRes.GetString("Warning"));
                        return;
                    }

                    int personId = grdProcurations.SelectedRows[0].Cells["OBJID"].Value.ToInt();

                    System.Windows.Forms.DialogResult dr = MessageUtil.ConfirmYesNo(
                        messageRes.GetString("FrmProcurationList.Activate.Confirm"),
                        messageRes.GetString("Confirm"));

                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {
                        procurMan.ActivateProcuration(personId);
                        FreeTransactionLog transLogger = new FreeTransactionLog(AppVariables.CurrentUser.OBJID)
                        {
                            FormName = this.Name,
                            TransactionType = TransactionTypes.Update,
                            ControlName = btnActivate.Name,
                            ControlTag = btnActivate.Tag.ToStr(),
                            LogObject = personId
                        };
                        transLogger.Insert();
                        RefreshProcurations();
                        MessageUtil.Info(
                            messageRes.GetString("FrmProcurationList.Activate.Success"),
                            messageRes.GetString("Info"));
                    }
                }
            }
            catch (FreeException)
            {
                MessageUtil.Error(
                    messageRes.GetString("FrmProcurationList.Activate.Error"),
                    messageRes.GetString("Error"));
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2032"), "2032", AppVariables.CurrentUser.OBJID);

                MessageUtil.Error(
                    messageRes.GetString("FrmProcurationList.Activate.Error"),
                    messageRes.GetString("Error"));
            }
        }

        #endregion


        #region [ RefreshPersons method ]

        private void RefreshProcurations()
        {
            try
            {
                dtProcurationList = procurMan.GetProcurationList();
                dtSearchProcurationList = dtProcurationList;
                RefreshGrid();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion


        #region [RefreshGrid method]

        private void RefreshGrid()
        {
            try
            {
                grdProcurations.DataSource = dtSearchProcurationList;
                grdProcurations.ColumnHeaderTextList = formRes.GetString("FrmProcurationList.grdProcurations.ColumnHeaderTextList");
                grdProcurations.Refresh();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion


        #region [ SearchOptionChanged method ]

        private void SearchOptionChanged(object sender, EventArgs e)
        {
            Search();
        }

        #endregion


        #region [ SearchTypeChanged method ]

        private void SearchTypeChanged(object sender, EventArgs e)
        {
            Search();
        }

        #endregion


        #region [ SearchTextChanged method ]

        private void SearchTextChanged(object sender, EventArgs e)
        {
            Search();
        }

        #endregion


        #region [ Search method ]

        private void Search()
        {
            try
            {
                dtSearchProcurationList = dtProcurationList;

                if (txtSearch.Text.NTrim().Length > 0 && cmbxSearchType.SelectedValue.ToStr().NTrim().Length > 0)
                {
                    dtSearchProcurationList = dtProcurationList.Search(cmbxSearchType.SelectedValue.ToStr(), txtSearch.Text, rdbtnExactMatch.Checked);
                }

                RefreshGrid();
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2033"), "2033", AppVariables.CurrentUser.OBJID);

                MessageUtil.Error(
                    messageRes.GetString("FrmProcurationList.Search.Error"),
                    messageRes.GetString("Error"));
            }
        }

        #endregion


        #region [ btnRefreshList_Click method ]

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshProcurations();
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2034"), "2034", AppVariables.CurrentUser.OBJID);

                MessageUtil.Error(
                    messageRes.GetString("FrmProcurationList.btnRefreshList_Click.Error"),
                    messageRes.GetString("Error"));
            }
        }

        #endregion


        #region [ addToolStripMenuItem_Click method ]

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProcuration();
        }

        #endregion


        #region [ updateToolStripMenuItem_Click method ]

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateProcuration();
        }

        #endregion


        #region [ deleteToolStripMenuItem_Click method ]

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        #endregion


        #region [ activateToolStripMenuItem_Click method ]

        private void activateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivateProcuration();
        }

        #endregion


        #region [ refreshListToolStripMenuItem_Click method ]

        private void refreshListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshProcurations();
            }
            catch (FreeException)
            {
                MessageUtil.Error(
                    messageRes.GetString("FrmProcurationList.refreshListToolStripMenuItem_Click.Error"),
                    messageRes.GetString("Error"));
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2041"), "2041", AppVariables.CurrentUser.OBJID);

                MessageUtil.Error(
                    messageRes.GetString("FrmProcurationList.refreshListToolStripMenuItem_Click.Error"),
                    messageRes.GetString("Error"));
            }
        }

        #endregion

    }
}