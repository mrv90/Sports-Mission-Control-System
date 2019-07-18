using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace smcs.frontend.frm
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }
        
        protected virtual void clearAll() 
        {
            foreach (Control c in Controls) // UNDONE نوع کنترل‌هایی که باید پاک شوند باید به صورت جنریک ارسال شود
            {
                if (c.GetType() == typeof(TextBox) || c.GetType() == typeof(MaskedTextBox))
                    c.Text = "";
                else if (c.GetType() == typeof(ComboBox))
                    ((ComboBox)c).SelectedIndex = -1;
                else if (c.GetType() == typeof(DateTimePicker))
                    ((DateTimePicker)c).Value = DateTime.Now.Date;
            }
        }

        protected void validateTextBox(ref ErrorProvider errorProvider, Control crtl, string err, ref CancelEventArgs e)
        {
            if (crtl.Enabled && String.IsNullOrWhiteSpace(crtl.Text.Replace("_", "").Replace("/", "").Replace("-","").Replace("(","").Replace(")","")))
            {
                e.Cancel = true;
                //crtl.Focus();
                errorProvider.SetError(crtl, err);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(crtl, null);
            }
        }

        protected void validateComboBox(ref ErrorProvider errorProvider, ComboBox cmb, string err, ref CancelEventArgs e)
        {
            if (cmb.Enabled && cmb.SelectedIndex == -1)
            {
                e.Cancel = true;
                //cmb.Focus();
                errorProvider.SetError(cmb, err);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmb, null);
            }
        }

        protected void validateDateTimePicker(ref ErrorProvider errorProvider, DateTimePicker dtp, string err, ref CancelEventArgs e)
        {
            if (dtp.Enabled && dtp.Value.Date == DateTime.Now.Date)
            {
                e.Cancel = true;
                //cmb.Focus();
                errorProvider.SetError(dtp, err);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(dtp, null);
            }
        }
    }
}
