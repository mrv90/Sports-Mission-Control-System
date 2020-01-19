using smcs.backend.biz;
using smcs.backend.data.access;
using smcs.backend.data.model;
using smcs.backend.data.model.basic;
using smcs.backend.data.model.parent;
using System;
using System.Windows.Forms;

namespace smcs.frontend.frm
{
    public partial class frmDataEntry : frmBase
    {
        public frmDataEntry()
        {
            InitializeComponent();

            loadItemsInCmb<Rank>(cmbRank);
            loadItemsInCmb<Unit>(cmbUnit);
            loadItemsInCmb<Sports>(cmbSprt);
            loadItemsInCmb<Office>(cmbOffc);
        }

        private void mtNtioSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (!rbtnNewAgnt.Checked && e.KeyData == Keys.Enter)
            {
                bool already_exist = true ? rbtnModfAgnt.Checked : false;
                fillControls(mtxtNtioSearch.Text.Replace("-", ""), already_exist);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (rbtnNewAgnt.Checked)
            {
                var mis = new Mission(dPickDteOfRecp.Value.Date, ((PairDataItem)cmbSprt.SelectedItem).Id, ((PairDataItem)cmbOffc.SelectedItem).Id,
                    txtOrdrBy.Text.Trim(), CrntUser.SesId);
                mis.InitDesc = txtDesc.Text.Trim();
                var agnt = new Agent(txtName.Text.Trim(), ((PairDataItem)cmbRank.SelectedItem).Id, txtFthrName.Text.Trim(), mtxtNtioSearch.Text.Replace("-", ""),
                    dPickDteOfDisp.Value.Date, txtCntcNum.Text.Trim(), txtEmgNum.Text.Trim(), ((PairDataItem)cmbUnit.SelectedItem).Id, mis.Id);
                agnt.Addr = txtAddr.Text.Trim();
                agnt.PersCode = mtxtPersCode.Text.Replace("-", "");
                mis.InitDesc = txtDesc.Text;

                new BizProvider().RegisterTheAgent(mis, agnt);
            }

            else if (rbtnModfAgnt.Checked)
            {
                var rep = new Repository();
                var ag = modifyAgentProperties(true);
                var mi = rep.Ret<Mission>(m => m.Id == ag.MisRef);

                mi.InitDate = dPickDteOfRecp.Value.Date;
                mi.SprtRef = ((PairDataItem)cmbSprt.SelectedItem).Id;
                mi.OffcRef = ((PairDataItem)cmbOffc.SelectedItem).Id;
                mi.OrdrBy = txtOrdrBy.Text.Trim();
                mi.InitDesc = txtDesc.Text.Trim();
                mi.TimeStmp = DateTime.Now;

                new BizProvider().UpdateAgentAndMission(ag, mi);
            }

            else if (rbtnOldAgnt.Checked)
            {
                var rep = new Repository();
                var ag = modifyAgentProperties(true);

                new BizProvider().AddNewMission(ag, dPickDteOfRecp.Value, ((PairDataItem)cmbOffc.SelectedItem).Id,
                    ((PairDataItem)cmbSprt.SelectedItem).Id, txtOrdrBy.Text.Trim(), CrntUser.SesId);
            }
        }

        private void btnGenRpt_Click(object sender, EventArgs e)
        {
            //if (rbtnNewAgnt.Checked || rbtnOldAgnt.Checked)
                //TODO گزارش پذیرش مامور افزوده شود.
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.clearAll();
        }

        private void ckhKeepOpenWindow_CheckedChanged(object sender, EventArgs e)
        {
            //TODO مکانیزم بازماندن پنجره
        }

        /************************* private *************************/

        protected override void clearAll()
        {
            base.clearAll();
            mtxtNtioSearch.Text = tslblStatus.Text = "";
        }

        private void loadItemsInCmb<T>(ComboBox cmb) where T : Base
        {
            cmb.DisplayMember = "Name";            
            cmb.ValueMember = "Id";

            using (var rep = new Repository())
            {
                var all = rep.RetList<T>(e => e.Enbl == true);
                foreach (var ins in all)
                    cmb.Items.Add(new PairDataItem(ins.Id, ins.Name));
            }
        }

        public void fillControls(string ntio, bool already_exist)
        {
            var rep = new Repository();
            var ag = rep.Ret<Agent>(a => a.NtioCode == ntio && a.Enbl == already_exist);
            var mis = rep.Ret<Mission>(m => m.Id == ag.MisRef && m.Last == already_exist);

            if (ag != null && mis != null)
            {
                extrCmbItem(cmbRank, ag.RnkRef);
                txtName.Text = ag.Name;
                txtFthrName.Text = ag.FthrName;
                extrCmbItem(cmbUnit, ag.UntRef);
                dPickDteOfDisp.Value = ag.DateOfDisp.Date;
                dPickDteOfRecp.Value = mis.InitDate.Date;
                extrCmbItem(cmbSprt, mis.SprtRef);
                extrCmbItem(cmbOffc, mis.OffcRef);
                mtxtNtioSearch.Text = ag.NtioCode.ToString();
                mtxtPersCode.Text = ag.PersCode.ToString();
                txtOrdrBy.Text = mis.OrdrBy;
                txtCntcNum.Text = ag.Cntc;
                txtEmgNum.Text = ag.ECntc;
                txtAddr.Text = ag.Addr;
                txtDesc.Text = mis.InitDesc;
            }
            else
                MessageBox.Show("مطابق با مشخصات وارد شده، موردی یافت نشد");
        }

        public void fillControls(int id, bool already_exist)
        {
            var rep = new Repository();
            var ag = rep.Ret<Agent>(a => a.Id == id && a.Enbl == already_exist);
            var mi = rep.Ret<Mission>(m => m.Id == ag.MisRef && m.Last == already_exist);

            if (ag != null && mi != null)
            {
                extrCmbItem(cmbRank, ag.RnkRef);
                txtName.Text = ag.Name;
                txtFthrName.Text = ag.FthrName;
                extrCmbItem(cmbUnit, ag.UntRef);
                dPickDteOfDisp.Value = ag.DateOfDisp.Date;
                dPickDteOfRecp.Value = mi.InitDate.Date;
                extrCmbItem(cmbSprt, mi.SprtRef);
                extrCmbItem(cmbOffc, mi.OffcRef);
                mtxtNtioSearch.Text = ag.NtioCode.ToString();
                mtxtPersCode.Text = ag.PersCode.ToString();
                txtOrdrBy.Text = mi.OrdrBy;
                txtCntcNum.Text = ag.Cntc;
                txtEmgNum.Text = ag.ECntc;
                txtAddr.Text = ag.Addr;
                txtDesc.Text = mi.InitDesc;
            }
            else
                MessageBox.Show("مطابق با مشخصات وارد شده، موردی یافت نشد");
        }

        private void extrCmbItem(ComboBox cmb, Int32 id)
        {
            foreach (PairDataItem item in cmb.Items)
            {
                if (item.Id == id)
                {
                    cmb.SelectedItem = item;
                    break;
                }
            }
        }

        private Agent modifyAgentProperties(bool currentAgent)
        {
            var agnt = new Repository().Ret<Agent>(a => a.NtioCode.ToString() == mtxtNtioSearch.Text && a.Enbl == currentAgent);
            agnt.RnkRef = ((PairDataItem)cmbRank.SelectedItem).Id;
            agnt.Name = txtName.Text.Trim();
            agnt.FthrName = txtFthrName.Text.Trim();
            agnt.UntRef = ((PairDataItem)cmbUnit.SelectedItem).Id;
            agnt.DateOfDisp = dPickDteOfDisp.Value.Date;
            agnt.PersCode = mtxtPersCode.Text.Replace("-", "");
            agnt.Cntc = txtCntcNum.Text.Trim();
            agnt.ECntc = txtEmgNum.Text.Trim();
            agnt.Addr = txtAddr.Text.Trim();
            agnt.Enbl = true; // مامور می‌تواند از سوابق پذیرش شود

            return agnt;
        }

        private void cmbRank_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            base.validateComboBox(ref errorProvider, cmbRank, "درجه مامور انتخاب نشده", ref e);
        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            base.validateTextBox(ref errorProvider, txtName, "نام مامور ثبت نشده", ref e);
        }

        private void txtFthrName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            base.validateTextBox(ref errorProvider, txtFthrName, "نام پدر مامور باید ثبت شود", ref e);
        }

        private void cmbUnit_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            base.validateComboBox(ref errorProvider, cmbUnit, "یگان مامور باید ثبت شود", ref e);
        }

        private void dPickDteOfDisp_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            base.validateDateTimePicker(ref errorProvider, dPickDteOfDisp, "تاریخ اعزام نمی‌تواند تاریخ امروز باشد", ref e);
        }

        private void cmbSprt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            base.validateComboBox(ref errorProvider, cmbSprt, "رشته ورزشی مامور باید ثبت شود", ref e);
        }

        private void cmbOffc_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            base.validateComboBox(ref errorProvider, cmbOffc, "قسمت مامور باید ثبت شود", ref e);
        }

        private void mtxtPersCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            base.validateTextBox(ref errorProvider, mtxtPersCode, "شماره پرسنلی مامور باید ثبت شود", ref e);
        }

        private void txtOrdrBy_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            base.validateTextBox(ref errorProvider, txtOrdrBy, "دستور صادر شده برای پذیرش مامور باید ثبت شود", ref e);
        }

        private void txtCntcNum_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            base.validateTextBox(ref errorProvider, txtCntcNum, "شماره تماس مامور باید ثبت شود", ref e);
        }

        private void txtEmgNum_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            base.validateTextBox(ref errorProvider, txtEmgNum, "شماره تماس اضطراری مامور باید ثبت شود", ref e);
        }

        private void txtAddr_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            base.validateTextBox(ref errorProvider, txtAddr, "آدرس مامور باید ثبت شود", ref e);
        }
    }
}
 