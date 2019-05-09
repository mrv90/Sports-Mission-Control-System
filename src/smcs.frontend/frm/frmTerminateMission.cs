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
            if (mtxtNtioSearch.Text.Length == 10)
            {
                /*UNDONE درصورت اشتباه بودن کدملی، استثنا ایجاد می‌شود*/

                using (var repOfAg = new Repository<Agent>())
                    ag = repOfAg.Ret(a => a.NtioCode == mtxtNtioSearch.Text.Trim() && a.Enbl == true);
                lblAgntName.Text = ag.Name;
                lblCntc.Text = ag.Cntc;
                lblECntc.Text = ag.ECntc;

                Mission mi;
                using (var repOfMis = new Repository<Mission>())
                    mi = repOfMis.Ret(m => m.MisId == ag.MisRef && ag.Enbl == true && m.Ret2UntDate == null);
                lblRecpDate.Text = mi.InitDate.ToShortDateString();

                using (var repOfOfc = new Repository<Office>())
                    lblOffc.Text = repOfOfc.Ret(f => f.Id == mi.OffcRef && f.Enbl == true).Name;

                using (var repOfOff = new Repository<OffDay>())
                    offDayNum.Value = repOfOff.Ret(o => o.MisRef == ag.MisRef && o.Enbl == true).TotalDays;

                using (var repOfAbs = new Repository<Absence>())
                    AbsNum.Value = repOfAbs.Ret(b => b.MisRef == ag.MisRef && b.Enbl == true).TotalDays;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (ag != null)
            {
                var biz = new BizProvider();
                biz.DismissTheAgent(ag, dPickUntil.Value);

                //if (chkGenRpt.Checked)
                    /*UNDONE چاپ گزارش پایان*/

                /*UNDONE اطلاع به کاربر در صورت موفق بودن*/
            }
        }
    }
}
