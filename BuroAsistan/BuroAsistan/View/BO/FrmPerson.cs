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
using System.Resources;
using System.Windows.Forms;

namespace BuroAsistan.View.BO
{
    public partial class FrmPerson : FrmBase
    {

        #region [ Private Fields ]

        private PersonManager personMan;
        private Person person = null;

        private int _personId = -1;
        private bool isFormLoaded = false;

        #endregion


        #region [ FrmPerson Ctors ]

        public FrmPerson()
            : this(-1)
        { }

        public FrmPerson(int personId)
        {
            try
            {
                InitializeComponent();
                personMan = new PersonManager();
                formRes = new ResourceManager("BuroAsistan.Resources.ControlResources.WinFormStrings", typeof(FrmPerson).Assembly);
                messageRes = new ResourceManager("BuroAsistan.Resources.MessageResources.AppMessages", typeof(FrmPerson).Assembly);

                _personId = personId;

                this.Text = formRes.GetString("FrmPerson.Caption");
                this.lblFirstName.Text = formRes.GetString("FrmPerson.lblFirstName");
                this.lblForeName.Text = formRes.GetString("FrmPerson.lblForeName");
                this.lblLastName.Text = formRes.GetString("FrmPerson.lblLastName");
                this.lblIdentity.Text = formRes.GetString("FrmPerson.lblIdentity");
                this.lblAdress.Text = formRes.GetString("FrmPerson.lblAdress");
                this.lblDetails.Text = formRes.GetString("lblDetails");

                this.btnSave.Text = _personId == -1 ? formRes.GetString("btnSave") : formRes.GetString("btnUpdate");
                this.btnCancel.Text = formRes.GetString("btnCancel");
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2002"), "2002");

                MessageUtil.Error(
                    messageRes.GetString("FrmPerson.Ctor.Error"),
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
                person = new Person();

                if (_personId != -1)
                {
                    person = personMan.GetById(_personId);
                    txtFirstName.Text = person.FirstName;
                    txtForeName.Text = person.ForeName;
                    txtLastName.Text = person.LastName;
                    txtIdentity.Text = person.IdentityNo;
                    txtAdress.Text = person.Adress;
                    txtDetails.Text = person.Details;
                }
            }
            catch (FreeException)
            {
                MessageUtil.Error(
                    messageRes.GetString("FrmPerson.Load.Error"),
                    messageRes.GetString("Error"));
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2003"), "2003");

                MessageUtil.Error(
                    messageRes.GetString("FrmPerson.Load.Error"),
                    messageRes.GetString("Error"));
            }
            finally
            {
                isFormLoaded = true;
                if (_personId != -1)
                {
                    person = new Person()
                    {
                        OBJID = _personId
                    };
                }
                else
                {
                    person = new Person()
                    {
                        IsActive = 1
                    };
                }
            }
        }

        #endregion


        #region [ Save method ]

        private void Save()
        {
            try
            {
                int length = txtFirstName.Text.NTrim().Length * txtLastName.Text.NTrim().Length * txtIdentity.Text.NTrim().Length;
                if (length == 0)
                {
                    MessageUtil.Warn(
                        messageRes.GetString("FrmPerson.Save.EmptyFirstNameLastNameIdentity"),
                        messageRes.GetString("Warning"));
                    return;
                }

                int prsnId = -1;
                if (_personId == -1)
                {
                    person.CreationTime = DateTime.Now;
                    prsnId = personMan.SavePerson(person);
                }
                else
                {
                    if (person.ChangeSetCount > 1)
                    {
                        personMan.UpdatePerson(person);
                    }
                }

                FreeTransactionLog transLogger = new FreeTransactionLog(AppVariables.CurrentUser.OBJID)
                {
                    FormName = this.Name,
                    TransactionType = _personId == -1 ? TransactionTypes.Insert : TransactionTypes.Update,
                    ControlName = btnSave.Name,
                    ControlTag = btnSave.Tag.ToStr(),
                    LogObject = _personId == -1 ? prsnId : _personId
                };
                transLogger.Insert();
                MessageUtil.Info(
                    messageRes.GetString(_personId == -1 ? "FrmPerson.Save.Success" : "FrmPerson.Update.Success"),
                    messageRes.GetString("Info"));
                this.Close();
            }
            catch (FreeException)
            {
                MessageUtil.Error(
                    messageRes.GetString("FrmPerson.Save.Error"),
                    messageRes.GetString("Error"));
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2004"), "2004");

                MessageUtil.Error(
                    messageRes.GetString("FrmPerson.Save.Error"),
                    messageRes.GetString("Error"));
            }
        }

        #endregion


        #region [ txtIdentity_KeyPress method ]

        private void txtIdentity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(((int)e.KeyChar >= 47 && (int)e.KeyChar <= 58) || ((int)e.KeyChar == 8));
        }

        #endregion


        #region [ TextChanged Methods ]

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
            {
                person.FirstName = txtFirstName.Text;
            }
        }

        private void txtForeName_TextChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
            {
                person.ForeName = txtForeName.Text;
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
            {
                person.LastName = txtLastName.Text;
            }
        }

        private void txtIdentity_TextChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
            {
                person.IdentityNo = txtIdentity.Text;
            }
        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
            {
                person.Adress = txtAdress.Text;
            }
        }

        private void txtDetails_TextChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
            {
                person.Details = txtDetails.Text;
            }
        }

        #endregion


        #region [ btnSave_Click method ]

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        #endregion


        #region [ btnCancel_Click method ]

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel(sender, e);
        }

        #endregion

    }
}