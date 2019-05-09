using smcs.backend.data.access;
using smcs.backend.data.model;
using smcs.backend.data.model.basic;
using smcs.backend.data.model.iterative;
using smcs.backend.data.model.parent;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace smcs.frontend.frm
{
    public partial class frmSearch : frmBase
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        //UNDONE شماره نامه شروع و توضیحات مربوط به آن
        //UNDONE شماره اتمام ماموریت و توضیحات مربوط به آن

        private void frmSearch_Load(object sender, EventArgs e)
        {
            cmbMisPerd.ValueMember = "MisId";
            cmbMisPerd.DisplayMember = "InitDate";

            
        }

        private void cmbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (rbtnSrchByName.Checked)
                loadSearchBox("Name", cmbSearch.Text);

            else if (rbtnSrchByNtioCode.Checked)
                loadSearchBox("NtioCode", cmbSearch.Text);

            else if (rbtnSrchByPersCode.Checked)
                loadSearchBox("PersCode", cmbSearch.Text);

            else if (rbtnSrchByCntcNum.Checked)
                loadSearchBox("CntcNum", cmbSearch.Text);

            else if (rbtnSrchByECntcNum.Checked)
                loadSearchBox("ECntcNum", cmbSearch.Text);
        }

        private void cmbMisPerd_SelectedIndexChanged(object sender, EventArgs e)
        {
            Agent ag;
            Mission mis;

            using (var repOfAg = new Repository<Agent>())
                ag = repOfAg.Ret(a => a.NtioCode == lblNtioCode.Text);

            using (var repOfMis = new Repository<Mission>())
                mis = repOfMis.Ret(m => m.MisId == ag.MisRef);

            RefreshData(ag, mis);
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbSearch.Text)) // UNDONE بررسی شود که متن وارده یکی از آیتم‌‌های مورد نظر باشد
                return;

            Agent ag;
            List<Mission> lst_of_mis;
            int act = -1; // اندیس ماموریت فعال مامور مورد پرسش

            using (var rep = new Repository<Agent>())
            {
                if (rbtnSrchByName.Checked)
                    ag = rep.Ret(a => a.Name == cmbSearch.Text.Trim()); // هم مامور فعلی وهم مامورسابق
                else if (rbtnSrchByNtioCode.Checked)
                    ag = rep.Ret(a => a.NtioCode == cmbSearch.Text);
                else if (rbtnSrchByPersCode.Checked)
                    ag = rep.Ret(a => a.PersCode == cmbSearch.Text);
                else if (rbtnSrchByCntcNum.Checked)
                    ag = rep.Ret(a => a.Cntc == cmbSearch.Text.Trim());
                else
                    ag = rep.Ret(a => a.ECntc == cmbSearch.Text.Trim());
            }

            using (var repOfMis = new Repository<Mission>())
                lst_of_mis = repOfMis.RetList(m => m.MisId == ag.MisRef);

            foreach (Mission mis in lst_of_mis)
            {
                cmbMisPerd.Items.Add(new PairDataItem(mis.MisId, mis.InitDate.ToShortDateString()));

                if (mis.Enbl == true)
                {
                    act = lst_of_mis.IndexOf(mis);
                    cmbMisPerd.SelectedItem = mis;
                }
            }

            lblMissCont.Text = lst_of_mis.Count.ToString();
            RefreshData(ag, lst_of_mis[act]);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
           clearAll();
        }

        private void btnModfAgnt_Click(object sender, EventArgs e)
        {
            //TODO با فشردن این دکمه، فرم ویرایش مامور با همین کدملی باز شود
        }

        /* ------------------ private method(es) ------------------ */

        private void loadSearchBox(string prop, string filt)
        {
            var source = new AutoCompleteStringCollection();
            List<Agent> lst_of_ags;
            
            using (var repo = new Repository<Agent>())
            {
                switch (prop)
                {
                    case "Name":
                        lst_of_ags = repo.RetList(a => a.Name.Contains(filt));
                        foreach (Agent ag in lst_of_ags)
                            source.Add(ag.Name);
                        break;
                    case "NtioCode":
                        lst_of_ags = repo.RetList(a => a.NtioCode.Contains(filt));
                        foreach (Agent ag in lst_of_ags)
                            source.Add(ag.NtioCode);
                        break;
                    case "PersCode":
                        lst_of_ags = repo.RetList(a => a.PersCode.Contains(filt));
                        foreach (Agent ag in lst_of_ags)
                            source.Add(ag.PersCode);
                        break;
                    case "Cntc":
                        lst_of_ags = repo.RetList(a => a.Cntc.Contains(filt));
                        foreach (Agent ag in lst_of_ags)
                            source.Add(ag.Cntc);
                        break;
                    case "ECntc":
                        lst_of_ags = repo.RetList(a => a.ECntc.Contains(filt));
                        foreach (Agent ag in lst_of_ags)
                            source.Add(ag.ECntc);
                        break;
                }
            }

            cmbSearch.AutoCompleteCustomSource = source;
            cmbSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private string extNameFromBasicEntity<T>(Int32 id) where T: Base
        {
            using (var rep = new Repository<T>())
                return rep.Ret(e => e.Id == id && e.Enbl == true).Name;
        }

        private int extTotalDaysFromPeriodEntity<T>(Int32 id) where T : Iterative
        {
            using (var rep = new Repository<T>())
            {
                var iter = rep.Ret(e => e.Id == id && e.Enbl == true);
                if (iter != null)
                    return iter.TotalDays;

                return 0;
            }
        }

        private void RefreshData(Agent ag, Mission mis)
        {
            lblRnk.Text = extNameFromBasicEntity<Rank>(ag.RnkRef);
            lblName.Text = ag.Name;
            lblFthrName.Text = ag.FthrName;
            lblUnit.Text = extNameFromBasicEntity<Unit>(ag.UntRef);
            lblDteOfDisp.Text = ag.DateOfDisp.ToShortDateString();
            lblRcptDte.Text = mis.InitDate.ToShortDateString();
            lblTermDte.Text = mis.Ret2UntDate != null ? mis.Ret2UntDate.Value.ToShortDateString() : "-";
            lblSprt.Text = extNameFromBasicEntity<Sports>(mis.SprtRef);
            lblOffc.Text = extNameFromBasicEntity<Office>(mis.OffcRef);
            lblNtioCode.Text = ag.NtioCode.ToString();
            lblPersCode.Text = ag.PersCode.ToString();
            lblOrdrBy.Text = mis.OrdrBy;
            lblCntcNum.Text = ag.Cntc;
            lblEmgNum.Text = ag.ECntc;
            lblRegDt.Text = ag.TimeStmp.ToString(); // NOTE نمایش تاریخ‌وزمان قابل قبول است؟
            lblExtDt.Text = mis.DeadLine.ToShortDateString();
            lblAddr.Text = ag.Addr;

            lblOffDatCont.Text = extTotalDaysFromPeriodEntity<OffDay>(mis.MisId).ToString();
            lblAbsCont.Text = extTotalDaysFromPeriodEntity<Absence>(mis.MisId).ToString();
            lblOnDutyCont.Text = extTotalDaysFromPeriodEntity<OnDuty>(mis.MisId).ToString();
        }
    }
}
