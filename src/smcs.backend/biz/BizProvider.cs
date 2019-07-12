using smcs.backend.data.access;
using smcs.backend.data.model;
using smcs.backend.data.model.iterative;
using smcs.backend.data.model.parent;
using System;

namespace smcs.backend.biz
{
    public class BizProvider
    {
        readonly string csName = "end-user";

        public BizProvider() { }

        public BizProvider(string name) : this()
        {
            switch (name)
            {
                case "lab":
                    csName = "lab";
                    break;
                case "end-user":
                    break;
                default:
                    throw new ApplicationException("Invalid ConStr on BizProvider ..");
            }
        }
        
        public void Login(string usrNam, string pass)
        {
            using (var usrRepo = new Repository<User>(csName))
            {
                var usr = usrRepo.Ret(a => a.UsrName.Equals(usrNam) && a.Pass.Equals(pass));
                if (usr == null)
                    throw BizErrCod.USR_NOT_EXST;
                
                CrntUser.UsrId = usr.UsrId;
                CrntUser.Name = usr.Name;

                var sesRepo = new Session(usr.UsrId);
                using (var repoOfSessions = new Repository<Session>(csName))
                {
                    CrntUser.SesId = sesRepo.SesId;
                    if (!repoOfSessions.AddSingle(sesRepo))
                        throw BizErrCod.DB_INS_FAIL;
                }
            }
        }

        public void Logout()
        {
            using (var repo = new Repository<Session>(csName))
            {
                var sesi = repo.Ret(a => a.SesId.Equals(CrntUser.SesId) && 
                                         a.UsrRef.Equals(CrntUser.UsrId) && 
                                         a.TermDate.Equals(null));
                if (sesi == null) 
                    throw BizErrCod.SESI_NOT_EXST; /*UNDONE System.ApplicationException: 'Error in the application.'*/

                sesi.TermDate = DateTime.Now;
                if (!repo.Upd(sesi))
                    throw BizErrCod.DB_UPDT_FAIL;
            }
        }
        
        public void RegisterTheAgent(Mission mis, Agent ag)
        {
            using (var repOfMis = new Repository<Mission>(csName))
                if (!repOfMis.AddSingle(mis))
                    throw BizErrCod.DB_INS_FAIL;

            ag.MisRef = mis.MisId;

            using (var repOfAgnts = new Repository<Agent>(csName))
                if (!repOfAgnts.AddSingle(ag)) //TODO smoketest: System.Data.Entity.Validation.DbEntityValidationException: 'Validation failed for one or more entities. See 'EntityValidationErrors' property for more details.'
                    throw BizErrCod.DB_INS_FAIL;

            using (var repOfHis = new Repository<History>(csName))
                repOfHis.AddSingle(new History(Crud.Create, "Mission", ag.Id));
        }

        //UNDONE بروزرسانی ها باید internal باشند
        /*TODO متد ایجاد ماموریت باید ایجاد شده و جایگزین بروزرسانی ماموریت باشد؛ در صورتی که ماموریت فعلی خاتمه نیافته باشد، باید از ایجاد ماموریت جدید جلوگیری شود*/
        /*UNDONE از آنجا که این کلاس برای ارائه خدمات بیزنسی است، کلاس پایین تری وظیفه تغییرات دیتا را انجام می‌دهد*/
        public void UpdateAgent(Agent ag)
        {
            using (var repo = new Repository<Agent>(csName))
                if (!repo.Upd(ag))
                    throw BizErrCod.DB_UPDT_FAIL;

            using (var repOfHis = new Repository<History>(csName))
                repOfHis.AddSingle(new History(Crud.Update, "Mission", ag.Id));
        }

        //UNDONE بروزرسانی ها باید internal باشند
        /*TODO متد ایجاد ماموریت باید ایجاد شده و جایگزین بروزرسانی ماموریت باشد؛ در صورتی که ماموریت فعلی خاتمه نیافته باشد، باید از ایجاد ماموریت جدید جلوگیری شود*/
        /*UNDONE از آنجا که این کلاس برای ارائه خدمات بیزنسی است، کلاس پایین تری وظیفه تغییرات دیتا را انجام می‌دهد*/
        public void UpdateAgent(Agent ag, Mission mi)
        {
            using (var repo = new Repository<Mission>(csName))
                if (!repo.Upd(mi))
                    throw BizErrCod.DB_UPDT_FAIL;

            using (var repo = new Repository<Agent>(csName))
                if (!repo.Upd(ag))
                    throw BizErrCod.DB_UPDT_FAIL;

            using (var repOfHis = new Repository<History>(csName))
                repOfHis.AddSingle(new History(Crud.Update, "Mission", ag.Id));
        }

        public void DismissTheAgent(Agent ag, DateTime retToUnt)
        {
            using (var repOfAg = new Repository<Agent>(csName))
            {
                var exAg = repOfAg.Ret(a => a.Id == ag.Id);

                if (exAg == null)
                    throw BizErrCod.AGNT_NOT_EXST;

                else if (exAg.Enbl == false)
                    throw BizErrCod.AGNT_ALRDY_DISSMSD;

                ag.Enbl = false;
                if (!repOfAg.Upd(ag))
                    throw BizErrCod.DB_UPDT_FAIL;
            }

            using (var repOfMis = new Repository<Mission>(csName))
            {
                var exMi = repOfMis.Ret(s => s.MisId.Equals(ag.MisRef) && s.Ret2UntDate.Equals(null));
                if (exMi == null)
                    throw BizErrCod.SESI_NOT_EXST;

                exMi.Ret2UntDate = retToUnt;
                if (!repOfMis.Upd(exMi))
                    throw BizErrCod.DB_UPDT_FAIL;
            }

            using (var repOfHis = new Repository<History>(csName))
                repOfHis.AddSingle(new History(Crud.Delete, "Mission", ag.MisRef));
        }

        public void RegisterTheAgentOnOffice(Agent agnt, Int32 off)
        {
            // بهتر نیست که ثبت‌قسمت صرفا با شناسه مامور صورت بگیرد
            using (var repOfMis = new Repository<Mission>(csName))
            {
                var mis = repOfMis.Ret(e => e.MisId == agnt.MisRef && e.Enbl == true);
                mis.OffcRef = -1;
                if (!repOfMis.Upd(mis))
                    throw BizErrCod.DB_UPDT_FAIL;
            }
        }

        public void RemoveOfficeOfAgent(Agent agnt)
        {
            // بهتر نیست که ثبت‌قسمت صرفا با شناسه مامور صورت بگیرد
            using (var repOfMiss = new Repository<Mission>(csName))
            {
                var mis = repOfMiss.Ret(e => e.MisId == agnt.MisRef && e.Enbl == true);
                mis.OffcRef = -1;
                if (!repOfMiss.Upd(mis))
                    throw BizErrCod.DB_UPDT_FAIL;
            }
        }

        public void WriteTheAgentsIteration<T>(Int32 agId, DateTime date) where T: Iterative
        {
            int misId = -1;
            using (var rep = new Repository<Agent>(csName))
                misId = rep.Ret(e => e.Id == agId && e.Enbl == true).MisRef;
            
            // در این تاریخ نباید هیچ گردش‌کاری برای فرد ثبت شده باشد
            NoOtherOperationShouldExistOnThisDate<OffDay>(misId, date);
            NoOtherOperationShouldExistOnThisDate<OnDuty>(misId, date);
            NoOtherOperationShouldExistOnThisDate<UndTreat>(misId, date);
            NoOtherOperationShouldExistOnThisDate<Absence>(misId, date);

            switch (typeof(T).Name)
            {
                case "OffDay":
                    WriteOperation<OffDay>(new OffDay(date, misId, CrntUser.SesId));
                    break;
                case "OnDuty":
                    WriteOperation<OnDuty>(new OnDuty(date, misId, CrntUser.SesId));
                    break;
                case "UndTreat":
                    WriteOperation<UndTreat>(new UndTreat(date, misId, CrntUser.SesId));
                    break;
                case "Absence":
                    WriteOperation<Absence>(new Absence(date, misId, CrntUser.SesId));
                    break;
            }

            // UNDONE نمایش انجام به کاربر
        }

        public void RemoveTheAgentsIteration<T>(Int32 agId, DateTime date) where T: Iterative
        {
            int misId = -1;
            using (var rep = new Repository<Agent>(csName))
                misId = rep.Ret(e => e.Id == agId && e.Enbl == true).MisRef;

            switch (typeof(T).Name)
            {
                case "OffDay":
                    RemoveOperation<OffDay>(misId, date);
                    break;
                case "OnDuty":
                    RemoveOperation<OnDuty>(misId, date);
                    break;
                case "UndTreat":
                    RemoveOperation<UndTreat>(misId, date);
                    break;
                case "Absence":
                    RemoveOperation<Absence>(misId, date);
                    break;
            }
            
            // UNDONE نمایش انجام به کاربر
        }

        public void UpdateSignature(Signature sign)
        {
            using (var rep = new Repository<Signature>())
                if (!rep.Upd(sign))
                    throw BizErrCod.DB_UPDT_FAIL;
        }

        public void ExtendMission(Int32 mi, DateTime extDt)
        {
            using (var repOfMis = new Repository<Mission>())
            {
                var mis = repOfMis.Ret(m => m.MisId == mi);
                mis.DeadLine = extDt;
                repOfMis.Upd(mis);
            }
        }

        /* ------------------ private merhod(es) ------------------ */

        private void WriteOperation<T>(T t) where T: Iterative
        {
            using (var rep = new Repository<T>(csName))
                if (!rep.AddSingle(t))
                    throw BizErrCod.DB_INS_FAIL;

            using (var repOfHis = new Repository<History>(csName))
                repOfHis.AddSingle(new History(Crud.Create, typeof(T).Name, t.Id));
        }

        private void NoOtherOperationShouldExistOnThisDate<T>(int misId, DateTime date) where T: Iterative
        {
            using (var repo = new Repository<T>(csName))
                if (null != repo.Ret(o => o.MisRef.Equals(misId) && (o.Date == date) && o.Enbl == true))
                    throw BizErrCod.OPR_FAIL;
        }

        private void RemoveOperation<T>(int misId, DateTime date) where T : Iterative
        {
            using (var repo = new Repository<T>(csName))
            {
                var iter = repo.Ret(o => o.MisRef.Equals(misId) && o.Date == date && o.Enbl == true);
                if (iter == null)
                    throw BizErrCod.OPR_FAIL;

                iter.Enbl = false;
                if (!repo.Upd(iter))
                    throw BizErrCod.DB_UPDT_FAIL;

                using (var repOfHis = new Repository<History>(csName))
                    repOfHis.AddSingle(new History(Crud.Delete, typeof(T).Name, iter.Id));
            }
        }
    }
}
