using smcs.backend.biz;
using smcs.backend.data.access;
using smcs.backend.data.model;
using System;
using System.Windows.Forms;

namespace smcs.frontend.frm
{
    public partial class frmLogin : Form
    {
        frmMain frmMain;

        public frmLogin()
        {
            InitializeComponent();

            frmMain = new frmMain();
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
                clearInputs();

                this.Hide();
                frmMain.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show(msg.Text);
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /* ------------------ private merhod(es) ------------------ */

        private void clearInputs()
        {
            cmbUserName.SelectedIndex = -1;
            txtPass.Text = string.Empty;
        }
    }
}
