using BuroAsistan.View.BaseView;
using BuroAsistan.View.List;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuroAsistan.View.Buro
{
    public partial class FrmMain : FrmBase
    {
        public FrmMain()
        {
            InitializeComponent();
            formRes = new ResourceManager("BuroAsistan.Resources.ControlResources.WinFormStrings", typeof(FrmMain).Assembly);
            messageRes = new ResourceManager("BuroAsistan.Resources.MessageResources.AppMessages", typeof(FrmMain).Assembly);
        }

        private void btnPersonList_Click(object sender, EventArgs e)
        {
            FrmPersonList frmPersonLst = new FrmPersonList();
            frmPersonLst.ShowDialog();
        }

        private void btnProcurations_Click(object sender, EventArgs e)
        {
            FrmProcurationList frmProcList = new FrmProcurationList();
            frmProcList.ShowDialog();
        }
    }
}
