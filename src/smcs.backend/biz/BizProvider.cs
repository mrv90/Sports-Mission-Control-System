using smcs.backend.data.access;
using smcs.backend.data.model;
using smcs.backend.data.model.basic;
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
                            return Message.Succ("ورودبه‌سیستم", " نام " , usr.Name, " شنا.کار " , usr.UsrId);
                        }
                        else
                            return Message.Fail("ورودبه‌سیستم", " نام " , usr.Name, " شنا.کار " , usr.UsrId);
                    }
                }
                else
                    return Message.NotExist("ورودبه‌سیستم", " شنا.کار " , usrNam);
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
                        return Message.Succ("خروج‌ازسیستم", " شنا.کار " , sesi.UsrRef);

                    return Message.Fail("خروج‌ازسیستم", " شنا.کار " , sesi.UsrRef);
                }

                return Message.NotExist("خروج‌ازسیستم", " شنا.نِش " , sesi.SesId);
            }
        }

        public Message RegisterTheAgent(Mission mis, Agent ag)
        {
            using (var rOfA = new Repository<Agent>(csName))
            {
                using (var rOfM = new Repository<Mission>(csName))
                    rOfM.AddSingle(mis);

                ag.MisRef = mis.MisId;
                ag.Mission = mis;

                if (rOfA.AddMultiple(ag).Commit()) 
                    return Message.Succ("پذیرش", " شنا.مام " , ag.Id, " شنا.مات " , mis.MisId);
                else
                    return Message.Fail("پذیرش", " شنا.مام ", ag.Id, " شنا.مات ", mis.MisId);
            }
        }

        public Message UpdateAgentAndMission(Agent ag, Mission mi)
        {
            var rOfM = new Repository<Mission>(csName);
            rOfM.Upd(mi);

            var rOfA = new Repository<Agent>(csName);
            if (rOfA.Upd(ag).Commit()) 
                return Message.Succ("بروزرسانی‌مامور و مشخصات‌ماموریت", " شنا.مام " , ag.Id, " شنا.مات " , mi.MisId);

            return Message.Fail("بروزرسانی‌مامور و مشخصات‌ماموریت", " شنا.مام ", ag.Id, " شنا.مات ", mi.MisId);
        }

        public Message DismissTheAgent(Agent ag, DateTime retToUnt)
        {
            using (var rOfA = new Repository<Agent>(csName))
            {
                var exAg = rOfA.Ret(a => a.Id == ag.Id);
                if (exAg == null)
                    return Message.NotExist("پایان‌مامور", " شنا.مام ", ag.Id, " م.ب.ی " , retToUnt.ToShortDateString());
                else if (exAg.Enbl == false)
                    return Message.NotExist("پایان‌مامور", " شنا.مام ", ag.Id, " غیرفعال ", " م.ب.ی " , retToUnt.ToShortDateString());

                ag.Enbl = false;
                rOfA.Upd(ag);

                using (var rOfM = new Repository<Mission>(csName))
                {
                    var exMi = rOfM.Ret(s => s.MisId.Equals(ag.MisRef) && s.Ret2UntDate.Equals(null));
                    if (exMi == null)
                        return Message.NotExist("پایان‌ماموریت", " شنا.مات " , exMi.MisId);

                    exMi.Ret2UntDate = retToUnt;
                    if (rOfM.Upd(exMi).Commit())
                        return Message.Succ("پایان‌ماموریت", " شنا.مات " , exMi.MisId);

                    return Message.Fail("پایان‌ماموریت", " شنا.مات " , exMi.MisId);
                }
            }
        }

        public Message AddNewMission(Agent ag, DateTime recp, int offcId, int sprtId, string ordr, int sesi)
        {
            using (var rOfM = new Repository<Mission>(csName))
            {
                var previous = rOfM.Ret(m => m.MisId == ag.MisRef);
                previous.Last = false; // ماموریت قبلی، دیگر آخرین ماموریت نیست

                rOfM.Upd(previous);
                rOfM.AddSingle(new Mission(recp, sprtId, offcId, ordr, sesi));

                using (var rOfA = new Repository<Agent>(csName))
                    if (rOfA.Upd(ag).Commit()) 
                        return Message.Succ("بروزرسانی مامور", " شنا.مام " + ag.Id);
            }

            return Message.Fail("بروزرسانی مامور", " شنا.مام " + ag.Id);
        }

        public Message RegisterTheAgentOnOffice(Agent ag, Int32 ofc)
        {
            using (var rOfM = new Repository<Mission>(csName))
            {
                var mis = rOfM.Ret(e => e.MisId == ag.MisRef && e.Last == true);
                mis.OffcRef = -1;
                if (rOfM.Upd(mis).Commit())
                    return Message.Succ("ثبت‌قسمت", " شنا.مام " , ag.Id, " شنا.قِس ", ofc);

                return Message.Fail("ثبت‌قسمت", " شنا.مام ", ag.Id, " شنا.قِس ", ofc);
            }
        }

        public Message RemoveOfficeOfAgent(Agent ag)
        {
            using (var rOfM = new Repository<Mission>(csName))
            {
                var mis = rOfM.Ret(e => e.MisId == ag.MisRef && e.Last == true);
                mis.OffcRef = -1;
                if (rOfM.Upd(mis).Commit())
                    return Message.Succ("حذف ثبت‌قسمت", " شنا.مام " , ag.Id);

                return Message.Fail("حذف ثبت‌قسمت", " شنا.مام " , ag.Id);
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
                                return Message.Fail("ثبت مرخصی", " شنا.مات ", ag.MisRef, " در " , date.ToString("yyyy/MM/dd"));
                            break;
                        case "OnDuty":
                            if (!WriteOperation<OnDuty>(new OnDuty(date, ag.MisRef, CrntUser.SesId)))
                                return Message.Fail("ثبت امورخدمتی", " شنا.مات ", ag.MisRef, " در ", date.ToString("yyyy/MM/dd"));
                            break;
                        case "UndTreat":
                            if (!WriteOperation<UndTreat>(new UndTreat(date, ag.MisRef, CrntUser.SesId)))
                                return Message.Fail("ثبت اعزام‌به‌بهداری", " شنا.مات ", ag.MisRef, " در ", date.ToString("yyyy/MM/dd"));
                            break;
                        case "Absence":
                            if (!WriteOperation<Absence>(new Absence(date, ag.MisRef, CrntUser.SesId)))
                                return Message.Fail("ثبت نهست", " شنا.مات ", ag.MisRef, " در ", date.ToString("yyyy/MM/dd"));
                            break;
                    }

                    return Message.Succ("ثبت گردشکار", " شنا.مات ", ag.MisRef, " در ", date.ToString("yyyy/MM/dd"));
                }
                else
                    return Message.Conflict("ثبت گردشکار", " شنا.مات ", ag.MisRef, " در ", date.ToString("yyyy/MM/dd"));
            }
            else
                return Message.NotExist("ثبت گردشکار", " شنا.مام ", ag.Id);
        }

        public Message UpdateSignature(Signature sign)
        {
            using (var r = new Repository<Signature>())
                if (r.Upd(sign).Commit())
                    return Message.Succ("بروزرسانی‌امضا", " متصدی " , sign.Person);

            return Message.Fail("بروزرسانی‌امضا", " متصدی ", sign.Person, " جایگزین " , sign.Name);
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
                        return Message.Succ("تمدید‌ماموریت", " شنا.مات ", mi, " تا تاریخ ", extDt.ToString("yyyy/MM/dd"));

                    return Message.Fail("تمدید‌ماموریت", " شنا.مات ", mi, " تا تاریخ ", extDt.ToString("yyyy/MM/dd"));
                }
                else
                    return Message.NotExist("تمدید‌ماموریت", " شنا.مات ", mi, " تا تاریخ ", extDt.ToString("yyyy/MM/dd"));
            }
        }

        public Message RemoveIteration<T>(int id) where T: Iterative
        {
            using (var r = new Repository<T>(csName))
            {
                if (r.RemCond(x => x.Id == id && x.Enbl == true).Commit())
                    return Message.Succ("لغو‌عملیات", "شنا.عملیات", id.ToString());

                return Message.Fail("لغو‌عملیات", "شنا.عملیات", id.ToString());
            }
        }

        public Message ResumeMission(int misId)
        {
            using (var rOfA = new Repository<Agent>(csName))
            {
                var ag = rOfA.Ret(a => a.MisRef == misId && a.Enbl == false);
                if (ag == null)
                    return Message.NotExist("لغوعملیات پایان", "شنا.ماتِ.ما", misId.ToString());
                else
                {
                    ag.Enbl = true;
                    rOfA.Upd(ag);
                }

                using (var rOfM = new Repository<Mission>(csName))
                {
                    var mis = rOfM.Ret(m => m.MisId == misId && m.Last == true);
                    if (mis != null)
                    {
                        mis.Ret2UntDate = null;
                        if (rOfM.Upd(mis).Commit())
                            return Message.Succ("لغوعملیات پایان", "شنا.مات", misId.ToString());
                    }
                    else
                        return Message.NotExist("لغوعملیات پایان", "شنا.مات", misId.ToString());

                    return Message.Fail("لغوعملیات پایان", "شنا.مات", misId.ToString());
                }
            }
        }

        /* ------------------ private merhod(es) ------------------ */

        private bool WriteOperation<T>(T t) where T: Iterative
        {
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
    }
}
