using smcs.backend.data.access;
using smcs.backend.data.model;
using smcs.backend.data.model.basic;
using System;
using System.Collections.Generic;

namespace smcs.frontend.frm
{
    public partial class frmMissionExtension : frmBase
    {
        public frmMissionExtension()
        {
            InitializeComponent();
        }

        private void frmMissionExtension_Load(object sender, System.EventArgs e)
        {
            loadNotExtendedAgents(DateTime.Now, null);
            updateUI();
        }

        private void dPickUntil_ValueChanged(object sender, System.EventArgs e)
        {
            if (rbtnSingleAgent.Checked)
                loadNotExtendedAgents(dPickUntil.Value, null);

            updateUI();
        }

        private void rbtnSingleAgent_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbtnSingleAgent.Checked)
                loadNotExtendedAgents(dPickUntil.Value, null);
        }

        private void rbtnWholeOffice_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbtnWholeOffice.Checked)
                loadAllOffices();
        }

        private void btnSelectAll_Click(object sender, System.EventArgs e)
        {
            selectAllAgents();
        }

        private void btnSelectAgent_Click(object sender, System.EventArgs e)
        {
            lstMarkedAgnts.Items.Add(cmbSearch.SelectedItem);
        }

        private void btnApply_Click(object sender, System.EventArgs e)
        {
            //UNDONE افزودن بیزنس مناسب برای بروز کردن مامورین

            updateUI();

            //if (chkGenRpt.Checked)
                //UNDONE چاپ گزارش تمدید با امضاها مورد نیاز
        }

        /* ------------------ private method(es) ------------------ */

        private void loadNotExtendedAgents(DateTime extDt, int? ofc)
        {
            List<Mission> ls_of_mi;
            using (var repOfMi = new Repository<Mission>())
            {
                if (ofc is null)
                    ls_of_mi = repOfMi.RetList(m => m.Enbl == true && m.DeadLine < extDt);
                else
                    ls_of_mi = repOfMi.RetList(m => m.Enbl == true && m.DeadLine < extDt && m.OffcRef == ofc);
            }

            using (var repOfAg = new Repository<Agent>())
            {
                foreach (Mission mi in ls_of_mi)
                {
                    var ag = repOfAg.Ret(a => a.Enbl == true && a.MisRef == mi.MisId);
                    cmbSearch.Items.Add(new PairDataItem(ag.Id, ag.Name));
                }
            }
        }

        private void loadAllOffices()
        {
            using (var rep = new Repository<Office>())
            {
                foreach (var o in rep.RetList(e => e.Enbl == true))
                    cmbSearch.Items.Add(new PairDataItem(o.Id, o.Name));
            }
        }

        private void selectAllAgents()
        {
            List<Mission> ls_of_mi;
            using (var repOfMi = new Repository<Mission>())
                ls_of_mi = repOfMi.RetList(m => m.Enbl == true && m.DeadLine < dPickUntil.Value);

            using (var repOfAg = new Repository<Agent>())
            {
                foreach (Mission mi in ls_of_mi)
                {
                    var ag = repOfAg.Ret(a => a.Enbl == true && a.MisRef == mi.MisId);
                    lstMarkedAgnts.Items.Add(new PairDataItem(ag.Id, ag.Name));
                }
            }
        }

        private void updateUI()
        {
            lstMarkedAgnts.ValueMember = cmbSearch.ValueMember = "Id";
            lstMarkedAgnts.DisplayMember = cmbSearch.DisplayMember = "Name";

            lblAgentCount.Text = lstMarkedAgnts.Items.Count.ToString();
            
            using (var rep = new Repository<Mission>())
            {
                lblLastExtDate.Text = rep.RetMax(m => m.Enbl == true && 
                    m.DeadLine < dPickUntil.Value).DeadLine.ToShortDateString();
                lblNotExtendedCount.Text = rep.RetList(m => m.Enbl == true &&
                    m.DeadLine < dPickUntil.Value).Count.ToString();
            }
        }
    }
}
