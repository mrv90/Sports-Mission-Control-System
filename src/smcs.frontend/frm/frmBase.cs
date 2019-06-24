using System;
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
    }
}
