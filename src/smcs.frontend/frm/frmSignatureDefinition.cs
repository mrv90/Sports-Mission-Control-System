using smcs.backend.biz;
using smcs.backend.data.access;
using smcs.backend.data.model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace smcs.frontend.frm
{
    public partial class frmSignatureDefinition : frmBase
    {
        List<Signature> all_signs;

        public frmSignatureDefinition()
        {
            InitializeComponent();
        }

        private void frmSignatureDefinition_Load(object sender, System.EventArgs e)
        {
            updateUI();
        }

        private void btnApply_Click(object sender, System.EventArgs e)
        {
            var biz = new BizProvider();
            foreach (var sign in all_signs)
            {
                if (sign.Name == lblManager.Text && sign.Person != txtManager.Text)
                    sign.Person = txtManager.Text;
                else if (sign.Name == lblBoss.Text && sign.Person != txtBoss.Text)
                    sign.Person = txtBoss.Text;
                else if (sign.Name == lblJouniorBoss.Text && sign.Person != txtJouniorBoss.Text)
                    sign.Person = txtJouniorBoss.Text;
                else
                    continue;

                var msg = biz.UpdateSignature(sign);
                if (msg.Id != Message.SUCC)
                    MessageBox.Show(msg.Text);
            }

            updateUI();
        }

        /* ------------------ private method(es) ------------------ */

        private void updateUI()
        {
            using (var rOfS = new Repository<Signature>())
                all_signs = rOfS.RetList(r => r.Enbl == true);

            lblManager.Text = all_signs[0].Name;
            txtManager.Text = all_signs[0].Person;

            lblBoss.Text = all_signs[1].Name;
            txtBoss.Text = all_signs[1].Person;

            lblJouniorBoss.Text = all_signs[2].Name;
            txtJouniorBoss.Text = all_signs[2].Person;
        }
    }
}
