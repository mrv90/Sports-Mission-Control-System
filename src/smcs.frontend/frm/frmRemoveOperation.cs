using smcs.backend.biz;
using smcs.backend.data.access;
using smcs.backend.data.model;
using smcs.backend.data.model.iterative;
using smcs.backend.data.model.parent;
using System.Collections.Generic;
using System.Windows.Forms;

namespace smcs.frontend.frm
{
    public partial class frmRemoveOperation : frmBase
    {
        private void frmRemoveOperation_Load(object sender, System.EventArgs e)
        {
            updateUI();
        }

        public frmRemoveOperation()
        {
            InitializeComponent();
        }

        private void btnUpd_Click(object sender, System.EventArgs e)
        {
            updateUI();
        }

        private void tspRemHistItm_Click(object sender, System.EventArgs e)
        {

        }

        /* ------------------ private method(es) ------------------ */

        private void updateUI()
        {
            List<History> ls_of_his;
            using (var rep = new Repository<History>())
                ls_of_his = rep.RetList(h => h.Type == Crud.Create); // NOTE نیازی به عملیات‌هایی که بروزرسانی هستند، نیست؟

            if (ls_of_his.Count > 0)
                foreach (History hi in ls_of_his)
                {
                    if (hi.Entity == "Mission")
                        lstOpr.Items.Add(generateLVIFromMission(hi));
                    else
                        lstOpr.Items.Add(generateLVIFromIterative(hi));
                }
        }

        private ListViewItem generateLVIFromMission(History hi)
        {
            Mission mi; 
            using (var rep = new Repository<Mission>())
                mi = rep.Ret(a => a.MisId == hi.entId);

            Agent ag; 
            using (var rep = new Repository<Agent>())
                ag = rep.Ret(a => a.MisRef == mi.MisId);

            return new ListViewItem(new string[6]
            {
                hi.Id.ToString(),
                hi.TimeStmp.ToString(),
                hi.Entity, /*UNDONE نوع موجودیت باید فارسی و مناسب کاربر باشد*/
                ag.Name,
                mi.InitDate.ToShortDateString(),
                mi.InitDesc
            });
        }

        private ListViewItem generateLVIFromIterative(History hi)
        {
            Iterative it;
            if (hi.Entity == "Absence")
                using (var rep = new Repository<Absence>())
                    it = rep.Ret(a => a.Id == hi.entId);
            else if (hi.Entity == "OffDay")
                using (var rep = new Repository<OffDay>())
                    it = rep.Ret(a => a.Id == hi.entId);
            else if (hi.Entity == "OnDuty")
                using (var rep = new Repository<OnDuty>())
                    it = rep.Ret(a => a.Id == hi.entId);
            else if (hi.Entity == "UndTreat")
                using (var rep = new Repository<UndTreat>())
                        it = rep.Ret(a => a.Id == hi.entId);
            else
                throw BizErrCod.OPR_FAIL; /*TODO استثنای مناسب ایجاد شود*/

            Agent ag; /*UNDONE اگر که پیمانه بالا تهی باشد، مامور نیز تهی می‌شود‌*/
            using (var rep = new Repository<Agent>())
                ag = rep.Ret(a => a.MisRef == it.MisRef);

            return new ListViewItem(new string[6]
            {
                hi.Id.ToString(),
                hi.TimeStmp.ToString(),
                hi.Entity, /*UNDONE نوع موجودیت باید فارسی و مناسب کاربر باشد*/
                ag.Name,
                it.Date.ToShortDateString(),
                it.Desc
            });
        }
    }
}
