using smcs.backend.data.access;
using smcs.backend.data.model;
using smcs.backend.data.model.basic;
using smcs.backend.data.model.iterative;
using smcs.backend.data.model.parent;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Data;
using smcs.backend.biz;

namespace smcs.frontend.frm
{
    public partial class frmRemoveOperation : frmBase
    {
        public frmRemoveOperation()
        {
            InitializeComponent();
        }

        private void cmbSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbSearch.Text.Length >= 3)
            {
                loadSearchBox(cmbSearch.Text);

                cmbSearch.DroppedDown = true;
                cmbSearch.SelectionStart = cmbSearch.Text.Length;
                cmbSearch.SelectionLength = 0;
            }
            else
                cmbSearch.DroppedDown = false;
        }

        private void cmbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lstOpr.Items.AddRange(generateListOfLVI(((PairDataItem)cmbSearch.SelectedItem).Id).ToArray());

                /* NOTE باید آخرین ماموریت را لغو پایان کنیم */
                using (var rep = new Repository())
                {
                    var ag = rep.Ret<Agent>(i => i.MisRef == ((PairDataItem)cmbSearch.SelectedItem).Id);
                    var mis = rep.Ret<Mission>(m => m.Id == ((PairDataItem)cmbSearch.SelectedItem).Id && m.Last == true); 
                    var ofc = rep.Ret<Office>(o => o.Id == mis.OffcRef); 

                    MessageBox.Show("نام: " + ag.Name + "\n" + "قسمت: " + ofc.Name + "\n" + "تاریخ اعزام: " + ag.DateOfDisp.ToString("yyyy/MM/dd") + "\n" + 
                                    "تاریخ پذیرش: " + mis.InitDate.ToString("yyyy/MM/dd") + "\n" + "تاریخ معرفی‌به‌یگان: " + 
                                    (mis.Ret2UntDate.HasValue ? mis.Ret2UntDate.Value.ToString("yyyy/MM/dd") : string.Empty), "مشخصات مامور انتخابی", MessageBoxButtons.OK);
                }
            }
        }

        private void tsmiCancelItem_Click(object sender, EventArgs e)
        {
            if (lstOpr.Focused && lstOpr.SelectedItems[0] != null)
            {
                if (DialogResult.Yes == MessageBox.Show("عملیات انتخاب شده لغو شود؟", "", MessageBoxButtons.YesNo))
                {
                    var type = lstOpr.SelectedItems[0].SubItems[2].Text; // NOTE با اسم ستون کار نکرد
                    var id = lstOpr.SelectedItems[0].Tag.ToString().ToInt32();

                    int result = Message.FAIL;
                    switch (type.ToEnglishName())
                    {
                        case "Absence":
                            result = new BizProvider().RemoveIteration<Absence>(id).Id;
                            break;
                        case "OffDay":
                            result = new BizProvider().RemoveIteration<OffDay>(id).Id;
                            break;
                        case "OnDuty":
                            result = new BizProvider().RemoveIteration<OnDuty>(id).Id;
                            break;
                        case "UndTreat":
                            result = new BizProvider().RemoveIteration<UndTreat>(id).Id;
                            break;
                        case "Mission":
                            result = new BizProvider().ResumeMission(id).Id;
                            break;
                    }

                    if (result == Message.SUCC)
                    {
                        lstOpr.Items.Remove(lstOpr.SelectedItems[0]);
                        lstOpr.Refresh();
                    }
                }
            }
        }

        /* ------------------ private method(es) ------------------ */

        private void loadSearchBox(string filt)
        {
            var items = new List<PairDataItem>();

            List<Agent> lst_of_proposed;
            using (var rep = new Repository())
                lst_of_proposed = rep.RetList<Agent>(a => a.NtioCode.Contains(filt));

            if (lst_of_proposed != null)
            {
                foreach (var ag in lst_of_proposed)
                    items.Add(new PairDataItem(ag.MisRef, ag.NtioCode));

                cmbSearch.Items.Clear();
                cmbSearch.Items.AddRange(items.ToArray());
            }
        }

        private List<ListViewItem> generateListOfLVI(int misId)
        {
            using (var rep = new Repository())
            {
                var mis = rep.Ret<Mission>(m => m.Id == misId && m.Last == true);
                var lst_of_off = rep.RetList<OffDay>(i => i.MisRef == misId && i.Enbl == true);
                var lst_of_duty = rep.RetList<OnDuty>(i => i.MisRef == misId && i.Enbl == true);
                var lst_of_treat = rep.RetList<UndTreat>(i => i.MisRef == misId && i.Enbl == true);
                var lst_of_abs = rep.RetList<Absence>(i => i.MisRef == misId && i.Enbl == true);

                var lst_of_lvi = new List<ListViewItem>();

                if (lst_of_off != null)
                    generateLVIForEachIteration(ref lst_of_lvi, lst_of_off.Cast<Iterative>().ToList(), "مرخصی");

                if (lst_of_duty != null)
                    generateLVIForEachIteration(ref lst_of_lvi, lst_of_duty.Cast<Iterative>().ToList(), "امورخدمتی");

                if (lst_of_treat != null)
                    generateLVIForEachIteration(ref lst_of_lvi, lst_of_treat.Cast<Iterative>().ToList(), "اعزام‌به‌بهداری");

                if (lst_of_abs != null)
                    generateLVIForEachIteration(ref lst_of_lvi, lst_of_abs.Cast<Iterative>().ToList(), "نهست");

                if (mis.Ret2UntDate.HasValue)
                {
                    var lvi = new ListViewItem(new string[6] { (lst_of_lvi.Count+1).ToString(), mis.TimeStmp.ToString("hh:mm:ss yyyy/MM/dd"),
                        mis.GetType().ToPersianName() , mis.Ret2UntDate.Value.ToString("yyyy/MM/dd"), extractUser(mis.SesRef), mis.TermDesc });
                    lvi.Tag = mis.Id;
                    lst_of_lvi.Add(lvi);
                }

                return lst_of_lvi;
            }
        }

        private void generateLVIForEachIteration(ref List<ListViewItem> items, List<Iterative> iterations, string type)
        {
            foreach (var itr in iterations)
            {
                var item = new ListViewItem(new string[6] {
                    (items.Count+1).ToString(),
                    itr.TimeStmp.ToString("hh:mm:ss yyyy/MM/dd"),
                    type,
                    itr.Date.ToString("yyyy/MM/dd"),
                    extractUser(itr.SesRef),
                    itr.Desc
                });

                item.Tag = itr.Id; //NOTE توجه شود که شناسه داده بوسیله تگ استخراج می‌شود
                items.Add(item);
            }
        }

        private string extractUser(int sesId)
        {
            using (var rep = new Repository())
            {
                var session = rep.Ret<Session>(s => s.Id == sesId);
                return rep.Ret<User>(u => u.Id == session.UsrRef).Name;
            }
        }
    }
}