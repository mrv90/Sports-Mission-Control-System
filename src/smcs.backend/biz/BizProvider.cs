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
            }
        }
        
        public Message Login(string usrNam, string pass)
        {
            using (var rOfU = new Repository<User>(csName))
            {
                var usr = rOfU.Ret(a => a.UsrName.Equals(usrNam) && a.Pass.Equals(pass) && a.Enbl == true);
                if (usr != null)
                {
                    CrntUser.UsrId = usr.UsrId;
                    CrntUser.Name = usr.Name;

                    using (var repoOfSessions = new Repository<Session>(csName))
                    {
                        var ses = new Session(usr.UsrId);
                        if (repoOfSessions.AddSingle(ses).Commit())
                        {
                            CrntUser.SesId = ses.SesId;
                            return BizErrCod.LOG_IN_SUCC;
                        }
                        else
                            return BizErrCod.LOG_IN_FAIL;
                    }
                }
                else
                    return BizErrCod.USR_NOT_EXST;
            }
        }

        public Message Logout()
        {
            using (var rOfS = new Repository<Session>(csName))
            {
                var sesi = rOfS.Ret(a => a.SesId.Equals(CrntUser.SesId) && 
                                         a.UsrRef.Equals(CrntUser.UsrId) && 
                                         a.TermDate.Equals(null));
                if (sesi != null)
                {
                    sesi.TermDate = DateTime.Now;
                    if (rOfS.Upd(sesi).Commit())
                        return BizErrCod.LOG_OUT_SUCC;

                    return BizErrCod.LOG_OUT_FAIL;
                }

                return BizErrCod.SESI_NOT_EXST;
            }
        }
        
        public Message RegisterTheAgent(Mission mis, Agent ag)
        {
            //using (var repOfHis = new Repository<History>(csName))
            //    repOfHis.AddSingle(new History(Crud.Create, "Mission", ag.Id));

            using (var rOfA = new Repository<Agent>(csName))
            {
                using (var rOfM = new Repository<Mission>(csName))
                    rOfM.AddSingle(mis);

                ag.MisRef = mis.MisId;
                ag.Mission = mis;

                if (rOfA.AddMultiple(ag).Commit()) // تاریخچه ثبت می‌شود؟
                    return BizErrCod.AG_REG_SUCC;
                else
                    return BizErrCod.AG_REG_FAIL;
            }
        }

        public Message UpdateAgent(Agent ag)
        {
            using (var repOfHis = new Repository<History>(csName))
                repOfHis.AddSingle(new History(Crud.Update, "Mission", ag.Id));

            using (var rOfA = new Repository<Agent>(csName))
                if (rOfA.Upd(ag).Commit()) // تاریخچه ثبت می‌شود؟
                    return BizErrCod.AG_UPDT_SUCC;

            return BizErrCod.AG_UPDT_FAIL;
        }

        public Message UpdateAgentAndMission(Agent ag, Mission mi)
        {
            var rOfH = new Repository<History>(csName);
            rOfH.AddSingle(new History(Crud.Update, "Mission", ag.Id));

            var rOfM = new Repository<Mission>(csName);
            rOfM.Upd(mi);

            var rOfA = new Repository<Agent>(csName);
            if (rOfA.Upd(ag).Commit()) // تاریخچه ثبت می‌شود؟
                return BizErrCod.AG_N_MIS_UPDT_SUCC;

            return BizErrCod.AG_N_MIS_UPDT_FAIL;
        }

        public Message DismissTheAgent(Agent ag, DateTime retToUnt)
        {
            var rOfH = new Repository<History>(csName);
            rOfH.AddSingle(new History(Crud.Delete, "Mission", ag.MisRef));

            var rOfA = new Repository<Agent>(csName);
            var exAg = rOfA.Ret(a => a.Id == ag.Id);
            if (exAg == null)
                return BizErrCod.AGNT_NOT_EXST;
            else if (exAg.Enbl == false)
                return BizErrCod.AGNT_ALRDY_DISM;

            ag.Enbl = false;
            rOfA.Upd(ag);

            using (var rOfM = new Repository<Mission>(csName))
            {
                var exMi = rOfM.Ret(s => s.MisId.Equals(ag.MisRef) && s.Ret2UntDate.Equals(null));
                if (exMi == null)
                    return BizErrCod.MIS_NOT_EXST;

                exMi.Ret2UntDate = retToUnt;
                if (rOfM.Upd(exMi).Commit())
                    return BizErrCod.AG_DISM_SUCC;

                return BizErrCod.AG_DISM_FAIL;
            }
        }

        public Message RegisterTheAgentOnOffice(Agent agnt, Int32 off)
        {
            using (var rOfM = new Repository<Mission>(csName))
            {
                var mis = rOfM.Ret(e => e.MisId == agnt.MisRef && e.Enbl == true);
                mis.OffcRef = -1;
                if (rOfM.Upd(mis).Commit())
                    return BizErrCod.AG_REG_OFC_SUCC;

                return BizErrCod.AG_OFC_REG_FAIL;
            }
        }

        public Message RemoveOfficeOfAgent(Agent agnt)
        {
            using (var rOfM = new Repository<Mission>(csName))
            {
                var mis = rOfM.Ret(e => e.MisId == agnt.MisRef && e.Enbl == true);
                mis.OffcRef = -1;
                if (rOfM.Upd(mis).Commit())
                    return BizErrCod.AG_OFC_REM_SUCC;

                return BizErrCod.AG_OFC_REM_FAIL;
            }
        }

        public Message WriteTheAgentsIteration<T>(Int32 agId, DateTime date) where T: Iterative
        {
            var r = new Repository<Agent>(csName);
            var ag = r.Ret(e => e.Id == agId && e.Enbl == true);

            if (ag != null)
            {
                if (NoOtherOperationShouldExistOnThisDate<OffDay>(ag.MisRef, date) &&
                   NoOtherOperationShouldExistOnThisDate<OnDuty>(ag.MisRef, date) &&
                   NoOtherOperationShouldExistOnThisDate<UndTreat>(ag.MisRef, date) &&
                   NoOtherOperationShouldExistOnThisDate<Absence>(ag.MisRef, date))
                {
                    switch (typeof(T).Name)
                    {
                        case "OffDay":
                            if (!WriteOperation<OffDay>(new OffDay(date, ag.MisRef, CrntUser.SesId)))
                                return BizErrCod.WRT_OFF_FAIL;
                            break;
                        case "OnDuty":
                            if (!WriteOperation<OnDuty>(new OnDuty(date, ag.MisRef, CrntUser.SesId)))
                                return BizErrCod.WRT_ONDUT_FAIL;
                            break;
                        case "UndTreat":
                            if (!WriteOperation<UndTreat>(new UndTreat(date, ag.MisRef, CrntUser.SesId)))
                                return BizErrCod.WRT_UNTRT_FAIL;
                            break;
                        case "Absence":
                            if (!WriteOperation<Absence>(new Absence(date, ag.MisRef, CrntUser.SesId)))
                                return BizErrCod.WRT_ABS_FAIL;
                            break;
                    }

                    return BizErrCod.WRT_AG_ITER_SUCC;
                }
                else
                    return BizErrCod.OFF_UNDT_ABS_UNTRT_CONF;
            }
            else
                return BizErrCod.AGNT_NOT_EXST;
        }

        public Message RemoveTheAgentsIteration<T>(Int32 agId, DateTime date) where T: Iterative
        {
            var r = new Repository<Agent>(csName);
            var mis = r.Ret(e => e.Id == agId && e.Enbl == true);

            if (mis != null)
            {
                switch (typeof(T).Name)
                {
                    case "OffDay":
                        if (!RemoveOperation<OffDay>(mis.MisRef, date))
                            return BizErrCod.RMV_OFF_FAIL;
                        break;
                    case "OnDuty":
                        if (!RemoveOperation<OnDuty>(mis.MisRef, date))
                            return BizErrCod.RMV_ONDUT_FAIL;
                        break;
                    case "UndTreat":
                        if (!RemoveOperation<UndTreat>(mis.MisRef, date))
                            return BizErrCod.RMV_UNTR_FAIL;
                        break;
                    case "Absence":
                        if (!RemoveOperation<Absence>(mis.MisRef, date))
                            return BizErrCod.RMV_ABS_FAIL;
                        break;
                }

                return BizErrCod.AG_REM_ITER_SUCC;
            }
            else
                return BizErrCod.AGNT_NOT_EXST;
        }

        public Message UpdateSignature(Signature sign)
        {
            using (var r = new Repository<Signature>())
                if (r.Upd(sign).Commit())
                    return BizErrCod.UPDT_SIGN_SUCC;

            return BizErrCod.SIGN_UPDT_FAIL;
        }

        public Message ExtendMission(Int32 mi, DateTime extDt)
        {
            using (var r = new Repository<Mission>())
            {
                var mis = r.Ret(m => m.MisId == mi);
                if (mis != null)
                {
                    mis.DeadLine = extDt;
                    if (r.Upd(mis).Commit())
                        return BizErrCod.EXTN_MIS_SUCC;

                    return BizErrCod.EXTN_MIS_FAIL;
                }
                else
                    return BizErrCod.MIS_NOT_EXST;
            }
        }

        /* ------------------ private merhod(es) ------------------ */

        private bool WriteOperation<T>(T t) where T: Iterative
        {
            using (var rOfH = new Repository<History>(csName))
                rOfH.AddSingle(new History(Crud.Create, typeof(T).Name, t.Id));

            using (var rOfT = new Repository<T>(csName))
                if (rOfT.AddSingle(t).Commit()) // تاریخ‌چه هم ثبت می‌شود؟
                    return true;

            return false;
        }

        private bool NoOtherOperationShouldExistOnThisDate<T>(int misId, DateTime date) where T: Iterative
        {
            // در این تاریخ نباید هیچ گردش‌کاری برای فرد ثبت شده باشد
            using (var repo = new Repository<T>(csName))
                if (null == repo.Ret(o => o.MisRef.Equals(misId) && (o.Date == date) && o.Enbl == true))
                    return true;

            return false;
        }

        private bool RemoveOperation<T>(int misId, DateTime date) where T : Iterative
        {
            using (var rOfT = new Repository<T>(csName))
            {
                var iter = rOfT.Ret(o => o.MisRef.Equals(misId) && o.Date == date && o.Enbl == true);
                if (iter == null)
                    return false;

                iter.Enbl = false;
                rOfT.Upd(iter);

                var rOfH = new Repository<History>(csName);
                if (rOfH.AddSingle(new History(Crud.Delete, typeof(T).Name, iter.Id)).Commit()) // تاریخچه ثبت و عملیات لغو شده؟
                    return true;

                return true;
            }
        }
    }
}
