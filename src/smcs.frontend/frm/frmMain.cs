using smcs.backend.biz;
using smcs.frontend.frm;
using System;
using System.Windows.Forms;

namespace smcs.frontend
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = CrntUser.Name;
            lblVersion.Text = Application.ProductVersion.ToString();
            lblStatus.Text = string.Format("کاربر گرامی «{0}»؛ ورود شما ({1}) در سیستم ثبت شد", CrntUser.Name, DateTime.Now);
            //TODO گزارش کلی با رویداد‌ها روزانه نمایش داده شود
        }

        private void signatureDefinitionMenuItem_Click(object sender, EventArgs e)
        {
            new frmSignatureDefinition().ShowDialog();
        }

        private void serchMenuItem_Click(object sender, EventArgs e)
        {
            new frmSearch().ShowDialog();
        }

        private void dataEntryMenuItem_Click(object sender, EventArgs e)
        {
            new frmDataEntry().ShowDialog();
        }

        private void operationMenuItem_Click(object sender, EventArgs e)
        {
            new frmOperation().ShowDialog();
        }

        private void terminateOperationMenuItem_Click(object sender, EventArgs e)
        {
            new frmTerminateMission().ShowDialog();
        }

        private void missionExtensionMenuItem_Click(object sender, EventArgs e)
        {
            new frmMissionExtension().ShowDialog();
        }
        
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            new BizProvider().Logout();

            System.Windows.Forms.Application.Exit();
        }        
    }
}
