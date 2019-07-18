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

        //UNDONE نیاز به بازتولید بسیار احساس می‌شود
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (rbtnNewAgnt.Checked)
            {
                var biz = new BizProvider();
                var mis = new Mission(dPickDteOfRecp.Value.Date, ((PairDataItem)cmbSprt.SelectedItem).Id, ((PairDataItem)cmbOffc.SelectedItem).Id,
                    txtOrdrBy.Text.Trim(), CrntUser.SesId);
                mis.InitDesc = txtDesc.Text.Trim();
                var agnt = new Agent(txtName.Text.Trim(), ((PairDataItem)cmbRank.SelectedItem).Id, txtFthrName.Text.Trim(), mtxtNtioSearch.Text.Replace("-", ""),
                    dPickDteOfDisp.Value.Date, txtCntcNum.Text.Trim(), txtEmgNum.Text.Trim(), ((PairDataItem)cmbUnit.SelectedItem).Id, mis.MisId);
                agnt.Addr = txtAddr.Text.Trim();
                agnt.PersCode = mtxtPersCode.Text.Replace("-", "");
                mis.InitDesc = txtDesc.Text;

                //TODO مکانزیم موفق و شکست نوار وضعیت، با متن فارسی، رنگ متناسب و تاریخ و ساعت
                try
                {
                    biz.RegisterTheAgent(mis, agnt);
                    tslblStatus.Text = string.Format("ثبت مامور جدید {0} با کدملی {1} انجام شد", txtName.Text.Trim(), mtxtNtioSearch.Text.Trim());
                }
                catch (ApplicationException)
                {
                    tslblStatus.Text = "خطا"; // TODO نوع خطا از کجا آورده شود؟؟
                }
            }

            else if (rbtnModfAgnt.Checked)
            {
                var biz = new BizProvider();

                Agent ag;
                using (var repOfAgnt = new Repository<Agent>())
                    ag = notCommitedAgentUpdate(repOfAgnt, true);

                Mission mi;
                using (var rep = new Repository<Mission>())
                    mi = rep.Ret(m => m.MisId == ag.MisRef);

                mi.InitDate = dPickDteOfRecp.Value.Date;
                mi.SprtRef = ((PairDataItem)cmbSprt.SelectedItem).Id;
                mi.OffcRef = ((PairDataItem)cmbOffc.SelectedItem).Id;
                mi.OrdrBy = txtOrdrBy.Text.Trim();
                mi.InitDesc = txtDesc.Text.Trim();
                mi.TimeStmp = DateTime.Now;

                try
                {
                    biz.UpdateAgentAndMission(ag, mi);
                    tslblStatus.Text = string.Format("بروزرسانی مامور {0} با کدملی {1} انجام شد", txtName.Text.Trim(), mtxtNtioSearch.Text.Trim());
                }
                catch (Exception)
                {
                    tslblStatus.Text = "خطا"; // TODO نوع خطا از کجا آورده شود؟؟
                }
            }

            else if (rbtnOldAgnt.Checked)
            {
                using (var repOfAgnt = new Repository<Agent>())
                {
                    Agent ag = notCommitedAgentUpdate(repOfAgnt, true);

                    using (var rep = new Repository<Mission>())
                        rep.AddSingle(new Mission(dPickDteOfRecp.Value, ((PairDataItem)cmbOffc.SelectedItem).Id, 
                            ((PairDataItem)cmbSprt.SelectedItem).Id, txtOrdrBy.Text.Trim(), CrntUser.SesId));

                    try
                    {
                        var biz = new BizProvider();
                        biz.UpdateAgent(ag);
                        tslblStatus.Text = string.Format("پذیرش مجدد مامور {0} با کدملی {1} انجام شد", txtName.Text.Trim(), mtxtNtioSearch.Text.Trim());
                    }
                    catch (Exception)
                    {
                        tslblStatus.Text = "خطا"; // TODO نوع خطا از کجا آورده شود؟؟
                    }
                }
            }

            /*UNDONE توجه شود که بعد از اعمال عملیات، باید خلاصه‌ای از کارکرد درون دیتابیس ذخیره شده و در صفحه اصلی نمایش داده شود*/
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

            using (var repo = new Repository<T>())
            {
                var all = repo.RetList(e => e.Enbl == true);
                foreach (var ins in all)
                    cmb.Items.Add(new PairDataItem(ins.Id, ins.Name));
            }
        }

        public void fillControls(string ntio, bool already_exist)
        {
            Agent ag;
            Mission mis;
            using (var enbleRepo = new Repository<Agent>())
                ag = enbleRepo.Ret(a => a.NtioCode == ntio && a.Enbl == already_exist);
            using (var repOfMis = new Repository<Mission>())
                mis = repOfMis.Ret(m => m.MisId == ag.MisRef && m.Enbl == already_exist);

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

        public void fillControls(int id, bool already_exist)
        {
            Agent ag;
            Mission mis;
            using (var enbleRepo = new Repository<Agent>())
                ag = enbleRepo.Ret(a => a.Id == id && a.Enbl == already_exist);
            using (var repOfMis = new Repository<Mission>())
                mis = repOfMis.Ret(m => m.MisId == ag.MisRef && m.Enbl == already_exist);

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

        private Agent notCommitedAgentUpdate(Repository<Agent> repOfAgnt, bool currentAgent)
        {
            //UNDONE کل این متد باید حذف شده و به بیزنس‌پرووایدر انتقال یابد
            var agnt = repOfAgnt.Ret(a => a.NtioCode.ToString() == mtxtNtioSearch.Text && a.Enbl == currentAgent);
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
 