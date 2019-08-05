using smcs.backend.biz;
using smcs.backend.data.access;
using smcs.backend.data.model;
using System;
using System.Windows.Forms;

namespace smcs.frontend.frm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            using (var repo = new Repository<User>())
            {
                var users = repo.RetList(a => a.Enbl == true);
                if (users != null)
                {
                    foreach (var usr in users)
                        cmbUserName.Items.Add(usr.UsrName);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var msg = new BizProvider().Login(cmbUserName.Text, txtPass.Text.Trim());
            if (msg.Id == Message.SUCC)
            {
                this.Close();
                //new frmMain().ShowDialog();
            }
            else
                MessageBox.Show(msg.Text);
        }
    }
}
