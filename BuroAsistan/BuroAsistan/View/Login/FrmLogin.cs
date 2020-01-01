using BA.UserManagement;
using BA.UserManagement.Source.BO;
using BuroAsistan.Resources.ExceptionResources;
using BuroAsistan.Source.Variables;
using BuroAsistan.Util;
using BuroAsistan.View.BaseView;
using Net.LawORM.Log.Error;
using System;
using System.Resources;
using System.Windows.Forms;

namespace BuroAsistan.View.Login
{
    public partial class FrmLogin : FrmBase
    {

        #region [ Private Fields ]

        private UserManager userMan;

        #endregion


        #region [ FrmLogin Ctor ]

        public FrmLogin()
        {
            try
            {
                InitializeComponent();
                userMan = new UserManager();
                formRes = new ResourceManager("BuroAsistan.Resources.ControlResources.WinFormStrings", typeof(FrmLogin).Assembly);
                messageRes = new ResourceManager("BuroAsistan.Resources.MessageResources.AppMessages", typeof(FrmLogin).Assembly);

                lblUserName.Text = formRes.GetString("FrmLogin.lblUserName");
                lblPass.Text = formRes.GetString("FrmLogin.lblPass");
                lblError.Text = formRes.GetString("FrmLogin.lblError");
                btnLogin.Text = formRes.GetString("FrmLogin.btnLogin");
                btnCancel.Text = formRes.GetString("btnCancel");
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, Rc.GetString("2000"), "2000");

                MessageUtil.Error(
                    messageRes.GetString("FrmLogin.Ctor.Error"),
                    messageRes.GetString("Error"));
            }
        }

        #endregion


        #region [ Login method ]

        private void Login(object sender, EventArgs e)
        {
            try
            {
                if ((txtUserName.Text.Length * txtPass.Text.Length) == 0)
                {
                    MessageUtil.Warn(
                        messageRes.GetString("FrmLogin.Login.EmptyUserNameAndPass"),
                        messageRes.GetString("Warning")
                        );
                    return;
                }

                if ((txtUserName.Text.Length * txtPass.Text.Length) > 0)
                {
                    Users usr = userMan.GetUser(txtUserName.Text, txtPass.Text);
                    AppVariables.CurrentUser = usr;

                    Program.isLogin = true;
                    this.Close();
                }
            }
            catch
            {
                lblError.Visible = true;
            }
        }

        #endregion


        #region [ Cancel method ]

        private void CancelClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}