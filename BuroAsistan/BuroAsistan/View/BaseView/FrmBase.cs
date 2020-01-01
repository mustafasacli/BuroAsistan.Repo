using System;
using System.Globalization;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace BuroAsistan.View.BaseView
{
    public class FrmBase : Form
    {
        protected ResourceManager formRes;
        protected ResourceManager messageRes;

        public FrmBase()
            : base()
        {
            InitComp();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR");
        }

        protected void InitComp()
        {
            this.SuspendLayout();
            //
            //
            this.StartPosition = FormStartPosition.CenterScreen;
            //
            //
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        protected virtual void Cancel(object sender, EventArgs E)
        {
            this.Close();
        }

    }
}
