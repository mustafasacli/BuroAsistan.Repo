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
    public partial class FrmPersonList : FrmBase
    {

        #region [ Private Fields ]

        DataTable dtPersonList = null;
        DataTable dtSearchPersonList = null;

        PersonManager personMan = null;

        #endregion


        #region [ FrmPersonList Ctor ]

        public FrmPersonList()
        {
            try
            {
                InitializeComponent();
                personMan = new PersonManager();
                formRes = new ResourceManager("BuroAsistan.Resources.ControlResources.WinFormStrings", typeof(FrmPersonList).Assembly);
                messageRes = new ResourceManager("BuroAsistan.Resources.MessageResources.AppMessages", typeof(FrmPersonList).Assembly);

                this.Text = formRes.GetString("FrmPersonList.Caption");
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
                FreeLogger.LogException(ex, Rc.GetString("2011"), "2011", AppVariables.CurrentUser.OBJID);

                MessageUtil.Error(
                    messageRes.GetString("FrmPersonList.Ctor.Error"),
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
                cmbxSearchType.SetItemSource(formRes.GetString("FrmPersonList.cmbxSearchType.ItemSource"), '-', '*');
                cmbxSearchType.SelectedIndex = -1;
                RefreshPersons();
            }
            catch (FreeException)
            {
                MessageUtil.Error(
                    messageRes.GetString("FrmPersonList.Load.Error"),
                    messageRes.GetString("Error"));
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2012"), "2012", AppVariables.CurrentUser.OBJID);

                MessageUtil.Error(
                    messageRes.GetString("FrmPersonList.Load.Error"),
                    messageRes.GetString("Error"));
            }
        }

        #endregion


        #region [ btnAdd_Click method ]

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPerson();
        }

        #endregion


        #region [ AddPerson method ]

        private void AddPerson()
        {
            try
            {
                FrmPerson frm_person = new FrmPerson();
                frm_person.FormClosed += frm_person_FormClosed;
                frm_person.ShowDialog();
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2013"), "2013", AppVariables.CurrentUser.OBJID);

                MessageUtil.Error(
                    messageRes.GetString("FrmPersonList.btnAdd_Click.Error"),
                    messageRes.GetString("Error"));
            }
        }

        #endregion


        #region [ btnUpdate_Click method ]

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatePerson();
        }

        #endregion


        #region [ UpdatePerson method ]

        private void UpdatePerson()
        {
            try
            {
                if (grdPersons.SelectedRows.Count > 0)
                {
                    int personId = grdPersons.SelectedRows[0].Cells["OBJID"].Value.ToInt();
                    FrmPerson frm_person = new FrmPerson(personId);
                    frm_person.FormClosed += frm_person_FormClosed;
                    frm_person.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2014"), "2014", AppVariables.CurrentUser.OBJID);

                MessageUtil.Error(
                    messageRes.GetString("FrmPersonList.btnUpdate_Click.Error"),
                    messageRes.GetString("Error"));
            }
        }

        #endregion


        #region [ frm_person_FormClosed method ]

        void frm_person_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            try
            {
                RefreshPersons();
            }
            catch (FreeException)
            {
                MessageUtil.Error(
                    messageRes.GetString("FrmPersonList.frm_person_FormClosed.Error"),
                    messageRes.GetString("Error"));
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2015"), "2015", AppVariables.CurrentUser.OBJID);

                MessageUtil.Error(
                    messageRes.GetString("FrmPersonList.frm_person_FormClosed.Error"),
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
                if (grdPersons.SelectedRows.Count > 0)
                {
                    int activateState = grdPersons.SelectedRows[0].Cells["IsActive"].Value.ToInt();

                    if (activateState == 0)
                    {
                        MessageUtil.Warn(messageRes.GetString("FrmPersonList.Delete.PersonAlreadyDeleted"),
                            messageRes.GetString("Warning"));
                        return;
                    }

                    int personId = grdPersons.SelectedRows[0].Cells["OBJID"].Value.ToInt();

                    System.Windows.Forms.DialogResult dr = MessageUtil.ConfirmYesNo(
                        messageRes.GetString("FrmPersonList.Delete.Confirm"),
                        messageRes.GetString("Confirm"));

                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {
                        personMan.DeletePerson(personId);
                        FreeTransactionLog transLogger = new FreeTransactionLog(AppVariables.CurrentUser.OBJID)
                        {
                            FormName = this.Name,
                            TransactionType = TransactionTypes.Delete,
                            ControlName = btnDelete.Name,
                            ControlTag = btnDelete.Tag.ToStr(),
                            LogObject = personId
                        };
                        transLogger.Insert();
                        RefreshPersons();
                        MessageUtil.Info(
                            messageRes.GetString("FrmPersonList.Delete.Success"),
                            messageRes.GetString("Info"));
                    }
                }
            }
            catch (FreeException)
            {
                MessageUtil.Error(
                    messageRes.GetString("FrmPersonList.Delete.Error"),
                    messageRes.GetString("Error"));
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2016"), "2016", AppVariables.CurrentUser.OBJID);

                MessageUtil.Error(
                    messageRes.GetString("FrmPersonList.Delete.Error"),
                    messageRes.GetString("Error"));
            }
        }

        #endregion


        #region [ btnActivate_Click method ]

        private void btnActivate_Click(object sender, EventArgs e)
        {
            ActivatePerson();
        }

        #endregion


        #region [ Activate method ]

        private void ActivatePerson()
        {
            try
            {
                if (grdPersons.SelectedRows.Count > 0)
                {
                    int activateState = grdPersons.SelectedRows[0].Cells["IsActive"].Value.ToInt();

                    if (activateState == 1)
                    {
                        MessageUtil.Warn(messageRes.GetString("FrmPersonList.Activate.PersonAlreadyActivated"),
                            messageRes.GetString("Warning"));
                        return;
                    }

                    int personId = grdPersons.SelectedRows[0].Cells["OBJID"].Value.ToInt();

                    System.Windows.Forms.DialogResult dr = MessageUtil.ConfirmYesNo(
                        messageRes.GetString("FrmPersonList.Activate.Confirm"),
                        messageRes.GetString("Confirm"));

                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {
                        personMan.ActivatePerson(personId);
                        FreeTransactionLog transLogger = new FreeTransactionLog(AppVariables.CurrentUser.OBJID)
                        {
                            FormName = this.Name,
                            TransactionType = TransactionTypes.Update,
                            ControlName = btnActivate.Name,
                            ControlTag = btnActivate.Tag.ToStr(),
                            LogObject = personId
                        };
                        transLogger.Insert();
                        RefreshPersons();
                        MessageUtil.Info(
                            messageRes.GetString("FrmPersonList.Activate.Success"),
                            messageRes.GetString("Info"));
                    }
                }
            }
            catch (FreeException)
            {
                MessageUtil.Error(
                    messageRes.GetString("FrmPersonList.Activate.Error"),
                    messageRes.GetString("Error"));
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2012"), "2012", AppVariables.CurrentUser.OBJID);

                MessageUtil.Error(
                    messageRes.GetString("FrmPersonList.Activate.Error"),
                    messageRes.GetString("Error"));
            }
        }

        #endregion


        #region [ RefreshPersons method ]

        private void RefreshPersons()
        {
            try
            {
                dtPersonList = personMan.GetPersonList();
                dtPersonList = dtPersonList.MergeSomeColumns("FullName", new string[] { "FirstName", "ForeName", "LastName" });
                dtSearchPersonList = dtPersonList;
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
                grdPersons.DataSource = dtSearchPersonList;
                grdPersons.ColumnHeaderTextList = formRes.GetString("FrmPersonList.grdPersonList.ColumnHeaderTextList");
                grdPersons.Refresh();
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
                dtSearchPersonList = dtPersonList;

                if (txtSearch.Text.NTrim().Length > 0 && cmbxSearchType.SelectedValue.ToStr().NTrim().Length > 0)
                {
                    dtSearchPersonList = dtPersonList.Search(cmbxSearchType.SelectedValue.ToStr(), txtSearch.Text, rdbtnExactMatch.Checked);
                }

                RefreshGrid();
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2018"), "2018", AppVariables.CurrentUser.OBJID);

                MessageUtil.Error(
                    messageRes.GetString("FrmPersonList.Search.Error"),
                    messageRes.GetString("Error"));
            }
        }

        #endregion


        #region [ btnRefreshList_Click method ]

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshPersons();
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2019"), "2019", AppVariables.CurrentUser.OBJID);

                MessageUtil.Error(
                    messageRes.GetString("FrmPersonList.btnRefreshList_Click.Error"),
                    messageRes.GetString("Error"));
            }
        }

        #endregion


        #region [ addToolStripMenuItem_Click method ]

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPerson();
        }

        #endregion


        #region [ updateToolStripMenuItem_Click method ]

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePerson();
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
            ActivatePerson();
        }

        #endregion


        #region [ refreshListToolStripMenuItem_Click method ]

        private void refreshListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshPersons();
            }
            catch (FreeException)
            {
                MessageUtil.Error(
                    messageRes.GetString("FrmPersonList.RefreshPersons.Error"),
                    messageRes.GetString("Error"));
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2040"), "2040", AppVariables.CurrentUser.OBJID);

                MessageUtil.Error(
                    messageRes.GetString("FrmPersonList.RefreshPersons.Error"),
                    messageRes.GetString("Error"));
            }
        }

        #endregion

    }
}