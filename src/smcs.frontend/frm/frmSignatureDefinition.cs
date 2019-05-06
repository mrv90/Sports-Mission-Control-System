using smcs.backend.data.access;
using smcs.backend.data.model;

namespace smcs.frontend.frm
{
    public partial class frmSignatureDefinition : frmBase
    {
        public frmSignatureDefinition()
        {
            InitializeComponent();
        }

        private void frmSignatureDefinition_Load(object sender, System.EventArgs e)
        {
            using (var rep = new Repository<Signature>())
            {
                updateUI(rep);
            }
        }

        private void btnApply_Click(object sender, System.EventArgs e)
        {
            using (var rep = new Repository<Signature>())
            {
                var all_signs = rep.RetList(r => r.Enbl == true);

                all_signs[0].Person = txtManager.Text;
                all_signs[1].Person = txtBigBoss.Text;
                all_signs[2].Person = txtJouniorBoss.Text;

                foreach (var sign in all_signs)
                    rep.Upd(sign);

                //UNDONE مکانیزم اطلاع به کاربر
                updateUI(rep);
            }
        }

        private void updateUI(Repository<Signature> rep)
        {
            var all_signs = rep.RetList(r => r.Enbl == true);

            lblManager.Text = all_signs[0].Name;
            txtManager.Text = all_signs[0].Person;

            lblBigBoss.Text = all_signs[1].Name;
            txtBigBoss.Text = all_signs[1].Person;

            lblJouniorBoss.Text = all_signs[2].Name;
            txtJouniorBoss.Text = all_signs[2].Person;
        }
    }
}
