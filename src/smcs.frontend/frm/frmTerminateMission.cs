using smcs.backend.biz;
using smcs.backend.data.access;
using smcs.backend.data.model;
using smcs.backend.data.model.basic;
using smcs.backend.data.model.iterative;
using System;
using System.Windows.Forms;

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
                if (Message.SUCC == biz.DismissTheAgent(ag, dPickUntil.Value.Date).Id)
                    clearAll();

                //if (chkGenRpt.Checked)
                /*UNDONE چاپ گزارش پایان با تعداد مرخصی|نهست انتخاب شده*/

                /*UNDONE اطلاع به کاربر در صورت موفق بودن*/
            }
        }

        /* ------------------ method(es) ------------------ */

        public void updateUI(string ntio)
        {
            using (var rep = new Repository())
            {
                ag = rep.Ret<Agent>(a => a.NtioCode == ntio && a.Enbl == true);
                if (ag != null)
                {
                    lblAgNam.Text = ag.Name;
                    lblCntc.Text = ag.Cntc;
                    lblECntc.Text = ag.ECntc;

                    var mi = rep.Ret<Mission>(m => m.Id == ag.MisRef && ag.Enbl == true && m.Ret2UntDate == null);

                    if (mi != null )
                    {
                        lblRcpDat.Text = mi.InitDate.ToShortDateString();
                        lblOfc.Text = rep.Ret<Office>(f => f.Id == mi.OffcRef && f.Enbl == true).Name;

                        var off = rep.RetList<OffDay>(o => o.MisRef == ag.MisRef && o.Enbl == true);
                        NumOffDay.Value = (off != null) ? off.Count : 0;

                        var abs = rep.RetList<Absence>(b => b.MisRef == ag.MisRef && b.Enbl == true);
                        NumAbs.Value = (abs != null) ? abs.Count : 0;
                    }
                    else
                        MessageBox.Show("ماموریت مامور انتخاب شده قبل‌تر پایان پذیرفته");
                }
            }
        }

        public void updateUI(int id)
        {
            using (var rep = new Repository())
            {
                ag = rep.Ret<Agent>(a => a.Id == id && a.Enbl == true);
                if (ag != null)
                {
                    mtxtNtioSearch.Text = ag.NtioCode;
                    lblAgNam.Text = ag.Name;
                    lblCntc.Text = ag.Cntc;
                    lblECntc.Text = ag.ECntc;

                    var mi = rep.Ret<Mission>(m => m.Id == ag.MisRef && ag.Enbl == true && m.Ret2UntDate == null);
                    lblRcpDat.Text = mi.InitDate.ToShortDateString();

                    lblOfc.Text = rep.Ret<Office>(f => f.Id == mi.OffcRef && f.Enbl == true).Name;

                    var off = rep.RetList<OffDay>(o => o.MisRef == ag.MisRef && o.Enbl == true);
                    NumOffDay.Value = (off != null) ? off.Count : 0;

                    var abs = rep.RetList<Absence>(b => b.MisRef == ag.MisRef && b.Enbl == true);
                    NumAbs.Value = (abs != null) ? abs.Count : 0;
                }
            }
        }
    }
}
