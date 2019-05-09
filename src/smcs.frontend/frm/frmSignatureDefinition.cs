using smcs.backend.biz;
using smcs.backend.data.access;
using smcs.backend.data.model;
using System.Collections.Generic;

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
            using (var rep = new Repository<Signature>())
            {
                all_signs = rep.RetList(r => r.Enbl == true);
                updateUI(all_signs);
            }
        }

        private void btnApply_Click(object sender, System.EventArgs e)
        {
            all_signs[0].Name = lblManager.Text;
            all_signs[0].Person = txtManager.Text;
            all_signs[1].Name = lblBigBoss.Text;
            all_signs[1].Person = txtBigBoss.Text;
            all_signs[2].Name = lblJouniorBoss.Text;
            all_signs[2].Person = txtJouniorBoss.Text;

            var biz = new BizProvider();
            foreach (var sign in all_signs)
                biz.UpdateSignature(sign);

            //UNDONE مکانیزم اطلاع به کاربر
            updateUI(all_signs);
        }

        /* ------------------ private method(es) ------------------ */

        private void updateUI(List<Signature> all)
        {
            lblManager.Text = all[0].Name;
            txtManager.Text = all[0].Person;

            lblBigBoss.Text = all[1].Name;
            txtBigBoss.Text = all[1].Person;

            lblJouniorBoss.Text = all[2].Name;
            txtJouniorBoss.Text = all[2].Person;
        }
    }
}
