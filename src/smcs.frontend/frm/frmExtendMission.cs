using smcs.backend.biz;
using smcs.backend.data.access;
using smcs.backend.data.model;
using smcs.backend.data.model.basic;
using System;
using System.Collections.Generic;

namespace smcs.frontend.frm
{
    public partial class frmExtendMission : frmBase
    {
        public frmExtendMission()
        {
            InitializeComponent();
        }

        private void frmMissionExtension_Load(object sender, System.EventArgs e)
        {
            loadNotExtAgOnCmb(DateTime.Now, null);
            updateUI();
        }

        private void dPickUntil_ValueChanged(object sender, System.EventArgs e)
        {
            if (rbtnSingleAgent.Checked)
                loadNotExtAgOnCmb(dPickUntil.Value, null);

            updateUI();
        }

        private void rbtnSingleAgent_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbtnSingleAgent.Checked)
            {
                cmbSearch.Items.Clear();
                loadNotExtAgOnCmb(dPickUntil.Value, null);
            }
        }

        private void rbtnWholeOffice_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbtnWholeOffice.Checked)
            {
                cmbSearch.Items.Clear();
                loadAllOffices();
            }
        }

        private void btnSelAllNotExt_Click(object sender, System.EventArgs e)
        {
            addNotExtAgToLst(null);

            updateUI();
        }

        private void btnSelAgOrWhlOfc_Click(object sender, System.EventArgs e)
        {
            if (cmbSearch.SelectedItem != null)
            {
                if (rbtnSingleAgent.Checked)
                    lstMarkedAgnts.Items.Add(cmbSearch.SelectedItem);
                else if (rbtnWholeOffice.Checked)
                    addNotExtAgToLst(((PairDataItem)cmbSearch.SelectedItem).Id); //UNDONE نباید مامور تکراری افزوده شود
            }

            updateUI();
        }

        private void btnApply_Click(object sender, System.EventArgs e)
        {
            if (lstMarkedAgnts.Items.Count > 0)
            {
                var biz = new BizProvider();
                foreach (PairDataItem it in lstMarkedAgnts.Items)
                {
                    using (var rep = new Repository())
                    {
                        var mi = rep.Ret<Mission>(a => a.Id == it.Id);
                        biz.ExtendMission(mi.Id, dPickUntil.Value);
                    }
                }

                updateUI();

                //if (chkGenRpt.Checked)
                    //UNDONE چاپ گزارش تمدید با امضاها مورد نیاز

                //UNDONE نتیجه عملیات به کاربر اطلاع داده شود
            }
        }

        private void tspRem_Click(object sender, EventArgs e)
        {
            if (lstMarkedAgnts.Items.Count > 0 && lstMarkedAgnts.Focused)
                lstMarkedAgnts.Items.Remove(lstMarkedAgnts.SelectedItem);

            updateUI();
        }

        /* ------------------ private method(es) ------------------ */

        private void loadNotExtAgOnCmb(DateTime extDt, int? ofc)
        {
            List<Mission> ls_of_mi;
            using (var repOfMi = new Repository())
            {
                if (ofc is null)
                    ls_of_mi = repOfMi.RetList<Mission>(m => m.Last == true && m.DeadLine < extDt.Date);
                else
                    ls_of_mi = repOfMi.RetList<Mission>(m => m.Last == true && m.DeadLine < extDt.Date && m.OffcRef == ofc);
            }

            if (ls_of_mi != null)
            {
                using (var rep = new Repository())
                {
                    foreach (Mission mi in ls_of_mi)
                    {
                        var ag = rep.Ret<Agent>(a => a.Enbl == true && a.MisRef == mi.Id);
                        if (ag != null)
                            cmbSearch.Items.Add(new PairDataItem(ag.Id, ag.Name));
                    }
                }
            }
        }

        private void loadAllOffices()
        {
            using (var rep = new Repository())
            {
                foreach (var o in rep.RetList<Office>(e => e.Enbl == true))
                    cmbSearch.Items.Add(new PairDataItem(o.Id, o.Name));
            }
        }

        private void addNotExtAgToLst(int? ofc)
        {
            List<Mission> ls_of_mi;
            using (var rep = new Repository())
            {
                if (ofc is null)
                    ls_of_mi = rep.RetList<Mission>(m => m.Last == true && m.DeadLine < dPickUntil.Value.Date);
                else
                    ls_of_mi = rep.RetList<Mission>(m => m.Last == true && m.DeadLine < dPickUntil.Value.Date && m.OffcRef == ofc);
            
                foreach (Mission mi in ls_of_mi)
                {
                    var ag = rep.Ret<Agent>(a => a.Enbl == true && a.MisRef == mi.Id);
                    lstMarkedAgnts.Items.Add(new PairDataItem(ag.Id, ag.Name));
                }
            }
        }

        private void updateUI()
        {
            lstMarkedAgnts.ValueMember = cmbSearch.ValueMember = "Id";
            lstMarkedAgnts.DisplayMember = cmbSearch.DisplayMember = "Name";

            lblAgentCount.Text = lstMarkedAgnts.Items.Count.ToString();
            
            using (var rep = new Repository())
            {
                var ls_of_not_ext = rep.RetList<Mission>(m => m.Last == true &&
                    m.DeadLine < dPickUntil.Value.Date);

                if (ls_of_not_ext != null)
                {
                    lblNotExtendedCount.Text = ls_of_not_ext.Count.ToString();
                    //lblLastExtDate.Text = rep.RetEnum(m => m.Enbl == true && m.DeadLine < dPickUntil.Value)
                    //    .Max(m => m.DeadLine).ToShortDateString();
                    lblLastExtDate.Text = rep.RetMax<Mission>(m => m.Last == true && m.DeadLine < dPickUntil.Value).DeadLine.ToString("yyyy/MM/dd");
                }
            }
        }
    }
}
