﻿using smcs.backend.data.access;
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
            cmbMisPerd.ValueMember = "Id";
            cmbMisPerd.DisplayMember = "InitDate";

            cmbSearch.ValueMember = "Id";
            cmbSearch.DisplayMember = "Value";

            loadSearchBox("Name", cmbSearch.Text);
        }

        private void rbtnSrchByName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSrchByName.Checked)
                loadSearchBox("Name", cmbSearch.Text);
        }

        private void rbtnSrchByNtioCode_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSrchByNtioCode.Checked)
                loadSearchBox("NtioCode", cmbSearch.Text);
        }

        private void rbtnSrchByPersCode_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSrchByPersCode.Checked)
                loadSearchBox("PersCode", cmbSearch.Text);
        }

        private void rbtnSrchByCntcNum_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSrchByCntcNum.Checked)
                loadSearchBox("CntcNum", cmbSearch.Text);
        }

        private void rbtnSrchByECntcNum_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSrchByECntcNum.Checked)
                loadSearchBox("ECntcNum", cmbSearch.Text);
        }

        private void cmbMisPerd_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO  اعتبارسنجی افزوده شود

            Agent ag;
            Mission mis;

            using (var rep = new Repository())
            {
                ag = rep.Ret<Agent>(a => a.Id == ((PairDataItem)cmbSearch.SelectedItem).Id);
                mis = rep.Ret<Mission>(m => m.Id == ((PairDataItem)cmbMisPerd.SelectedItem).Id);
            }

            RefreshData(ag, mis);
        }

        private void cmbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(cmbSearch.Text) || cmbSearch.SelectedIndex == -1) // TODO این خط باید با اعتبارسنجی و خطای مناسب جایگزین شود
                    return;

                Agent ag;
                List<Mission> lst_of_mis;
                int act = -1; // اندیس ماموریت فعال مامور مورد پرسش

                using (var rep = new Repository())
                {
                    ag = rep.Ret<Agent>(a => a.Id == ((PairDataItem)cmbSearch.SelectedItem).Id);
                    lst_of_mis = rep.RetList<Mission>(m => m.Id == ag.MisRef);
                }

                foreach (Mission mis in lst_of_mis)
                {
                    cmbMisPerd.Items.Add(new PairDataItem(mis.Id, mis.InitDate.ToString("yyyy/MM/dd")));

                    if (mis.Last == true)
                    {
                        act = lst_of_mis.IndexOf(mis);
                        cmbMisPerd.SelectedIndex = act;
                    }
                }

                lblMissCont.Text = lst_of_mis.Count.ToString();
                RefreshData(ag, lst_of_mis[act]);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                clearAll();
            }
        }

        private void cmbSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbSearch.Text.Length >= 3)
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

                cmbSearch.DroppedDown = true;
                cmbSearch.SelectionStart = cmbSearch.Text.Length;
                cmbSearch.SelectionLength = 0;
            }
            else 
                cmbSearch.DroppedDown = false;
        }

        private void tsmItemApplyOpr_Click(object sender, EventArgs e)
        {
            // TODO اعتبارسنجی افزوده شود
            // TODO درصورتی که کاربر وجود داشت باید این گزینه فعال شود
            // NOTE  گردش کار فقط با اسم یا دیگر مشخصات نیز امکان پذیر باشد؟

            var frm = new frmOperation();
            frm.lstMarkedAgnts.Items.Add(cmbSearch.SelectedItem as PairDataItem);
            frm.ShowDialog();
        }

        private void tsmItemExtdMiss_Click(object sender, EventArgs e)
        {
            // TODO اعتبارسنجی افزوده شود
            // TODO درصورتی که کاربر وجود داشت باید این گزینه فعال شود
            // NOTE  گردش کار فقط با اسم یا دیگر مشخصات نیز امکان پذیر باشد؟

            var frm = new frmExtendMission();
            frm.lstMarkedAgnts.Items.Add(cmbSearch.SelectedItem as PairDataItem);
            frm.ShowDialog();
        }

        private void tsmItemRecpAgnt_Click(object sender, EventArgs e)
        {
            // TODO اعتبارسنجی افزوده شود
            // TODO درصورتی که کاربر وجود نداشته باشد این گزینه فعال شود
            // NOTE  گردش کار فقط با اسم یا دیگر مشخصات نیز امکان پذیر باشد؟

            //NOTE پذیرش از سوابق یا پذیرش جدید
        }

        private void tsmItemModfAgnt_Click(object sender, EventArgs e)
        {
            // TODO اعتبارسنجی افزوده شود
            // TODO درصورتی که کاربر وجود داشت باید این گزینه فعال شود
            // NOTE  گردش کار فقط با اسم یا دیگر مشخصات نیز امکان پذیر باشد؟

            var frm = new frmDataEntry();
            frm.rbtnModfAgnt.Checked = true;
            frm.fillControls(((PairDataItem)cmbSearch.SelectedItem).Id, true);
            frm.ShowDialog();
        }

        private void tsmItemTermMiss_Click(object sender, EventArgs e)
        {
            // TODO اعتبارسنجی افزوده شود
            // TODO درصورتی که کاربر وجود داشت باید این گزینه فعال شود
            // NOTE  گردش کار فقط با اسم یا دیگر مشخصات نیز امکان پذیر باشد؟

            var frm = new frmTerminateMission();
            frm.updateUI(((PairDataItem)cmbSearch.SelectedItem).Id);
            frm.ShowDialog();
        }

        /* ------------------ private method(es) ------------------ */

        private void loadSearchBox(string prop, string filt)
        {
            var items = new List<PairDataItem>();
            List<Agent> lst_of_ags;
            
            using (var repo = new Repository())
            {
                switch (prop)
                {
                    case "Name":
                        lst_of_ags = repo.RetList<Agent>(a => a.Name.Contains(filt));
                        if (lst_of_ags != null) {
                            foreach (Agent ag in lst_of_ags)
                                items.Add(new PairDataItem(ag.Id, ag.Name));
                        }
                        break;
                    case "NtioCode":
                        lst_of_ags = repo.RetList<Agent>(a => a.NtioCode.Contains(filt));
                        if (lst_of_ags != null) {
                            foreach (Agent ag in lst_of_ags)
                                items.Add(new PairDataItem(ag.Id, ag.NtioCode));
                        }
                        break;
                    case "PersCode":
                        lst_of_ags = repo.RetList<Agent>(a => a.PersCode.Contains(filt));
                        if (lst_of_ags != null) {
                            foreach (Agent ag in lst_of_ags)
                                items.Add(new PairDataItem(ag.Id, ag.PersCode));
                        }
                        break;
                    case "Cntc":
                        lst_of_ags = repo.RetList<Agent>(a => a.Cntc.Contains(filt));
                        if (lst_of_ags != null) {
                            foreach (Agent ag in lst_of_ags)
                                items.Add(new PairDataItem(ag.Id, ag.Cntc));
                        }
                        break;
                    case "ECntc":
                        lst_of_ags = repo.RetList<Agent>(a => a.ECntc.Contains(filt));
                        if (lst_of_ags != null) {
                            foreach (Agent ag in lst_of_ags)
                                items.Add(new PairDataItem(ag.Id, ag.ECntc));
                        }
                        break;
                }
            }

            cmbSearch.Items.Clear();
            cmbSearch.Items.AddRange(items.ToArray());
        }

        private string extNameFromBasicEntity<T>(Int32 id) where T: Base
        {
            using (var rep = new Repository())
                return rep.Ret<T>(e => e.Id == id && e.Enbl == true).Name;
        }

        private int extTotalDaysFromPeriodEntity<T>(Int32 mis) where T : Iterative
        {
            using (var rep = new Repository())
            {
                var iter = rep.RetList<T>(e => e.MisRef == mis && e.Enbl == true);
                if (iter != null)
                    return iter.Count;

                return 0;
            }
        }

        private void RefreshData(Agent ag, Mission mis)
        {
            lblRnk.Text = extNameFromBasicEntity<Rank>(ag.RnkRef);
            lblName.Text = ag.Name;
            lblFthrName.Text = ag.FthrName;
            lblUnit.Text = extNameFromBasicEntity<Unit>(ag.UntRef);
            lblDteOfDisp.Text = ag.DateOfDisp.ToString("yyyy/MM/dd");
            lblRcptDte.Text = mis.InitDate.ToString("yyyy/MM/dd");
            lblTermDte.Text = mis.Ret2UntDate != null ? mis.Ret2UntDate.Value.ToString("yyyy/MM/dd") : "-";
            lblSprt.Text = extNameFromBasicEntity<Sports>(mis.SprtRef);
            lblOffc.Text = extNameFromBasicEntity<Office>(mis.OffcRef);
            lblNtioCode.Text = ag.NtioCode.ToString();
            lblPersCode.Text = ag.PersCode.ToString();
            lblOrdrBy.Text = mis.OrdrBy;
            lblCntcNum.Text = ag.Cntc;
            lblEmgNum.Text = ag.ECntc;
            lblRegDt.Text = ag.TimeStmp.ToString("hh:mm:ss yyyy/MM/dd"); // NOTE نمایش تاریخ‌وزمان قابل قبول است؟
            lblExtDt.Text = mis.DeadLine.ToString("yyyy/MM/dd");
            lblAddr.Text = ag.Addr;

            lblOffDatCont.Text = extTotalDaysFromPeriodEntity<OffDay>(mis.Id).ToString();
            lblAbsCont.Text = extTotalDaysFromPeriodEntity<Absence>(mis.Id).ToString();
            lblOnDutyCont.Text = extTotalDaysFromPeriodEntity<OnDuty>(mis.Id).ToString();
        }
    }
}
