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

                /* Note هم به فعال نیاز داریم و هم غیرفعال؛ شاید نیاز باشد غیرفعال را دوباره فعال کنیم */
                var ag = new Repository<Agent>().Ret(i => i.MisRef == ((PairDataItem)cmbSearch.SelectedItem).Id);
                var mis = new Repository<Mission>().Ret(m => m.MisId == ((PairDataItem)cmbSearch.SelectedItem).Id); 
                var ofc = new Repository<Office>().Ret(o => o.Id == mis.OffcRef); 

                MessageBox.Show("نام: " + ag.Name + "\n" + "قسمت: " + ofc.Name + "\n" + "تاریخ اعزام: " + ag.DateOfDisp.ToString("yyyy/MM/dd") + "\n" + 
                                "تاریخ پذیرش: " + mis.InitDate.ToString("yyyy/MM/dd") + "\n" + "تاریخ معرفی‌به‌یگان: " + 
                                (mis.Ret2UntDate.HasValue ? mis.Ret2UntDate.Value.ToString("yyyy/MM/dd") : string.Empty), "مشخصات مامور انتخابی", MessageBoxButtons.OK);
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

            var lst_of_proposed = new Repository<Agent>().RetList(a => a.NtioCode.Contains(filt));
            foreach (var ag in lst_of_proposed)
                items.Add(new PairDataItem(ag.MisRef, ag.NtioCode));

            cmbSearch.Items.Clear();
            cmbSearch.Items.AddRange(items.ToArray());
        }

        private List<ListViewItem> generateListOfLVI(int misId)
        {
            var mis = new Repository<Mission>().Ret(m => m.MisId == misId && m.Enbl == true);
            var lst_of_off = new Repository<OffDay>().RetList(i => i.MisRef == misId && i.Enbl == true);
            var lst_of_duty = new Repository<OnDuty>().RetList(i => i.MisRef == misId && i.Enbl == true);
            var lst_of_treat = new Repository<UndTreat>().RetList(i => i.MisRef == misId && i.Enbl == true);
            var lst_of_abs = new Repository<Absence>().RetList(i => i.MisRef == misId && i.Enbl == true);

            var lst_of_lvi = new List<ListViewItem>();

            generateLVIForEachIteration(ref lst_of_lvi, lst_of_off.Cast<Iterative>().ToList(), "مرخصی");
            generateLVIForEachIteration(ref lst_of_lvi, lst_of_duty.Cast<Iterative>().ToList(), "امورخدمتی");
            generateLVIForEachIteration(ref lst_of_lvi, lst_of_treat.Cast<Iterative>().ToList(), "اعزام‌به‌بهداری");
            generateLVIForEachIteration(ref lst_of_lvi, lst_of_abs.Cast<Iterative>().ToList(), "نهست");
            if (mis.Ret2UntDate.HasValue)
            {
                var lvi = new ListViewItem(new string[6] { (lst_of_lvi.Count+1).ToString(), mis.TimeStmp.ToString("hh:mm:ss yyyy/MM/dd"),
                    mis.GetType().ToPersianName() , mis.Ret2UntDate.Value.ToString("yyyy/MM/dd"), extractUser(mis.SesRef), mis.TermDesc });
                lvi.Tag = mis.MisId;
                lst_of_lvi.Add(lvi);
            }

            return lst_of_lvi;
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
            var rOfS = new Repository<Session>();
            var rOfU = new Repository<User>();
            var session = rOfS.Ret(s => s.SesId == sesId);
            return rOfU.Ret(u => u.UsrId == session.UsrRef).Name;
        }
    }
}