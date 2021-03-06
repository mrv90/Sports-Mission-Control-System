﻿using smcs.backend.biz;
using smcs.backend.data.access;
using smcs.backend.data.model;
using smcs.backend.data.model.basic;
using smcs.backend.data.model.iterative;
using smcs.backend.data.model.parent;
using System;
using System.Linq;
using System.Windows.Forms;

namespace smcs.frontend.frm
{
    public partial class frmOperation : frmBase
    {
        public frmOperation()
        {
            InitializeComponent();
        }

        private void frmOperation_Load(object sender, EventArgs e)
        {
            /*UNDONE نام مامور را باید بتوان جستجو کرد*/
            loadSearchBox<Agent>();
            btnSelectAgent.Enabled = btnApply.Enabled = false;
            cmbOprType.Items.AddRange(new PairDataItem[] {
                new PairDataItem(1, "مرخصی"),
                new PairDataItem(2, "امورخدمتی"),
                new PairDataItem(3, "اعزام‌به‌بهداری"),
                new PairDataItem(4, "نهست"),
                /*TODO مکانیزم مستثنی از آمار، افزوده شود*/
            });
        }

        private void cmbOprType_SelectedIndexChanged(object sender, EventArgs e)
        {
            regulateControlsOnDemand();
        }

        private void rbtnSingleAgent_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSingleAgent.Checked)
            {
                cmbSearchAgnts.Items.Clear();
                loadSearchBox<Agent>();
            }

            regulateControlsOnDemand();
        }

        private void rbtnWholeOffice_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnWholeOffice.Checked)
            {
                cmbSearchAgnts.Items.Clear();
                loadSearchBox<Office>();
            }

            regulateControlsOnDemand();
        }

        private void cmbSearchAgnts_SelectedIndexChanged(object sender, EventArgs e)
        {
            regulateControlsOnDemand();
        }

        private void btnSelectAgent_Click(object sender, EventArgs e)
        {
            // TODO نمایش اطلاعات منحصر به اسم نیست؛ برای جلوگیری از اشتباه باید نام قسمت و کدملی افزوده شود
            var one_ag = cmbSearchAgnts.SelectedItem;

            if (rbtnSingleAgent.Checked && !lstMarkedAgnts.Items.Contains(one_ag))
                lstMarkedAgnts.Items.Add(one_ag);

            else if (rbtnWholeOffice.Checked)
            {
                using (var rep = new Repository())
                {
                    foreach (Mission mi in rep.RetList<Mission>(m => m.OffcRef == ((PairDataItem)cmbSearchAgnts.SelectedItem).Id && m.Last == true))
                    {
                        var ag = rep.Ret<Agent>(a => a.MisRef == mi.Id && a.Enbl == true);
                        var pair_data_ag = new PairDataItem(ag.Id, ag.Name);

                        if (!lstMarkedAgnts.Items.Contains(pair_data_ag))
                            lstMarkedAgnts.Items.Add(pair_data_ag);
                    }
                }
            }

            else
                return;

            regulateControlsOnDemand();
        }

        private void rbtnSingleDay_CheckedChanged(object sender, EventArgs e)
        {
            regulateControlsOnDemand();
        }

        private void rbtnTimespan_CheckedChanged(object sender, EventArgs e)
        {
            regulateControlsOnDemand();
        }

        private void btnSelectDate_Click(object sender, EventArgs e)
        {
            string one_d = dPickFrom.Value.ToShortDateString();

            // TODO باید یک هشدار یا نمایش کوچک برای امکان‌پذیر بودن/نبودن عملیات به کاربر ایجاد شود
            if (rbtnSingleDay.Checked && !lstMarkedDates.Items.Contains(one_d))
                lstMarkedDates.Items.Add(dPickFrom.Value.ToShortDateString());

            else if (rbtnTimespan.Checked)
            {
                for (DateTime d = dPickFrom.Value.Date; d <= dPickUntil.Value.Date; d = d.AddDays(1))
                {
                    if (!lstMarkedDates.Items.Contains(d))
                        lstMarkedDates.Items.Add(d);
                }
            }

            else
                return;

            regulateControlsOnDemand();
        }

        private void lstMarkedAgnts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMarkedAgnts.SelectedIndex != ListBox.NoMatches)
                cmuWholeForm.Show(Cursor.Position);
        }

        private void lstMarkedDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMarkedDates.SelectedIndex != ListBox.NoMatches)
                cmuWholeForm.Show(Cursor.Position);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            int flag = 0;
            switch (((PairDataItem)cmbOprType.SelectedItem).Value)
            {
                case "مرخصی":
                    flag = 1;
                    break;
                case "امورخدمتی":
                    flag = 2;
                    break;
                case "اعزام‌به‌بهداری":
                    flag = 3;
                    break;
                case "نهست":
                    flag = 4;
                    break;
            }

            var biz = new BizProvider();
            foreach (PairDataItem ag in lstMarkedAgnts.Items)
            {
                foreach (var date in lstMarkedDates.Items)
                {
                    switch (flag) {
                        case 1:
                            biz.WriteTheAgentsIteration<OffDay>(ag.Id, DateTime.Parse(date.ToString()));
                            break;
                        case 2:
                            biz.WriteTheAgentsIteration<OnDuty>(ag.Id, DateTime.Parse(date.ToString()));
                            break;
                        case 3:
                            biz.WriteTheAgentsIteration<UndTreat>(ag.Id, DateTime.Parse(date.ToString()));
                            break;
                        case 4:
                            biz.WriteTheAgentsIteration<Absence>(ag.Id, DateTime.Parse(date.ToString()));
                            break;
                        default:
                            break;
                    }
                }
            }

            /*NOTE شاید بهتر باشد یک فرم ثالث برمبنای نوع عملیات انتخاب شده،
             * باز شده و نام شهر مرخصی، نوع آسیب‌دیدگی بهداری و... در آن درج شود*/

            //if (chkGenRpt.Checked)
            //UNDONE چاپ گزارش به تعداد و کیفیت موردنیاز
        }
        
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void tspRem_Click(object sender, EventArgs e)
        {
            if (lstMarkedAgnts.Focused)
                lstMarkedAgnts.Items.Remove(lstMarkedAgnts.SelectedItem);
                
            else if (lstMarkedDates.Focused)
                lstMarkedDates.Items.Remove(lstMarkedDates.SelectedItem);
                
            regulateControlsOnDemand();
        }

        /* ------------------ private method(es) ------------------ */

        private void loadSearchBox<T>() where T: Base
        {
            using (var rep = new Repository())
            {
                var list = rep.RetList<T>(e => e.Enbl == true);
                if (list != null)
                {
                    foreach (var e in list)
                        cmbSearchAgnts.Items.Add(new PairDataItem(e.Id, e.Name));
                }
            }
        }

        private Office[] loadAllAgentsOfSingleOffice(string office) {
            using (var repo = new Repository())
                return repo.RetList<Office>(e => e.Name == office && e.Enbl == true).ToArray();
        }

        private void regulateControlsOnDemand()
        {
            lblAgentCount.Text = lstMarkedAgnts.Items.Count.ToString();
            lblDaysCount.Text = lstMarkedDates.Items.Count.ToString();

            btnApply.Enabled = true ? (cmbOprType.SelectedIndex != -1 && 
                                       lstMarkedDates.Items.Count > 0 && 
                                       lstMarkedAgnts.Items.Count > 0) : false;

            btnSelectAgent.Enabled = true ? cmbSearchAgnts.SelectedIndex != -1 : false;

            lblPickUntil.Enabled = dPickUntil.Enabled = true ? rbtnTimespan.Checked : false;
        }

        protected override void clearAll()
        {
            base.clearAll();

            lblAgentCount.Text = "0";
            lstMarkedAgnts.Items.Clear();
            lblDaysCount.Text = "0";
            lstMarkedDates.Items.Clear();
        }        
    }
}