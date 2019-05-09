using smcs.backend.biz;
using smcs.backend.data.access;
using smcs.backend.data.model;
using smcs.backend.data.model.basic;
using smcs.backend.data.model.iterative;
using System;

namespace smcs.frontend.frm
{
    public partial class frmTerminateMission : frmBase
    {
        Agent ag;        

        public frmTerminateMission()
        {
            InitializeComponent();
        }

        private void mtxtNtioSearch_TextChanged(object sender, EventArgs e)
        {
            string ntio = mtxtNtioSearch.Text.Replace("-", "");

            if (ntio.Length == 10)
                updateUI(ntio);
            else
            {
                lblAgNam.Text = lblRcpDat.Text = lblOfc.Text = lblCntc.Text = lblECntc.Text = string.Empty;
                NumOffDay.Value = NumAbs.Value = 0;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (ag != null)
            {
                var biz = new BizProvider();
                biz.DismissTheAgent(ag, dPickUntil.Value.Date);

                //if (chkGenRpt.Checked)
                    /*UNDONE چاپ گزارش پایان با تعداد مرخصی|نهست انتخاب شده*/

                /*UNDONE اطلاع به کاربر در صورت موفق بودن*/
            }
        }

        /* ------------------ private method(es) ------------------ */

        private void updateUI(string ntio)
        {
            using (var repOfAg = new Repository<Agent>())
                ag = repOfAg.Ret(a => a.NtioCode == ntio && a.Enbl == true);

            if (ag != null)
            {
                lblAgNam.Text = ag.Name;
                lblCntc.Text = ag.Cntc;
                lblECntc.Text = ag.ECntc;

                Mission mi;
                using (var repOfMis = new Repository<Mission>())
                    mi = repOfMis.Ret(m => m.MisId == ag.MisRef && ag.Enbl == true && m.Ret2UntDate == null);
                lblRcpDat.Text = mi.InitDate.ToShortDateString();

                using (var repOfOfc = new Repository<Office>())
                    lblOfc.Text = repOfOfc.Ret(f => f.Id == mi.OffcRef && f.Enbl == true).Name;

                using (var repOfOff = new Repository<OffDay>())
                {
                    var off = repOfOff.Ret(o => o.MisRef == ag.MisRef && o.Enbl == true);
                    NumOffDay.Value = (off != null) ? off.TotalDays : 0;
                }

                using (var repOfAbs = new Repository<Absence>())
                {
                    var abs = repOfAbs.Ret(b => b.MisRef == ag.MisRef && b.Enbl == true);
                    NumAbs.Value = (abs != null) ? abs.TotalDays : 0;
                }
            }
        }
    }
}
