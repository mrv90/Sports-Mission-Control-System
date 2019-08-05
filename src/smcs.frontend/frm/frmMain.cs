using smcs.backend.biz;
using smcs.frontend.crtl;
using smcs.frontend.frm;
using System;
using System.Windows.Forms;

namespace smcs.frontend
{
    public partial class frmMain : Form, IMessageListener
    {
        public frmMain()
        {
            InitializeComponent();

            MessageObserver.Attach(this);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblErrorCount.Text = CrntUser.Name;
            lblVersion.Text = Application.ProductVersion.ToString();
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

        private void removeOperationMenuItem_Click(object sender, EventArgs e)
        {
            new frmRemoveOperation().ShowDialog();
        }

        private void terminateOperationMenuItem_Click(object sender, EventArgs e)
        {
            new frmTerminateMission().ShowDialog();
        }

        private void missionExtensionMenuItem_Click(object sender, EventArgs e)
        {
            new frmExtendMission().ShowDialog();
        }
        
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            new BizProvider().Logout();

            //MessageObserver.Detach(this);

            this.Hide();
        }

        public void update(Message msg)
        {
            mcmbStatus.Items.Add(new ComboBoxItem(msg.Text, 0, msg.Color));
            mcmbStatus.SelectedIndex = 0; // TODO اندیس آخرین پیغام باید نمایش داده شود

            //TODO تعداد خطاها در برچسب موردنظر بروز شود
        }
    }
}
