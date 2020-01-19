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
            using (var rep = new Repository(csName))
            {
                var usr = rep.Ret<User>(a => a.UsrName.Equals(usrNam) && a.Pass.Equals(pass) && a.Enbl == true);
                if (usr != null)
                {
                    CrntUser.UsrId = usr.Id;
                    CrntUser.Name = usr.Name;

                    var ses = new Session(usr.Id);
                    if (rep.Add(ses).Commit())
                    {
                        CrntUser.SesId = ses.Id;
                        return Message.Succ("ورودبه‌سیستم", " نام " , usr.Name, " شنا.کار " , usr.Id);
                    }
                    else
                        return Message.Fail("ورودبه‌سیستم", " نام " , usr.Name, " شنا.کار " , usr.Id);
                }
                else
                    return Message.NotExist("ورودبه‌سیستم", " شنا.کار " , usrNam);
            }
        }

        public Message Logout()
        {
            using (var rep = new Repository(csName))
            {
                var sesi = rep.Ret<Session>(a => a.Id.Equals(CrntUser.SesId) && 
                                            a.UsrRef.Equals(CrntUser.UsrId) && 
                                            a.TermDate.Equals(null));
                if (sesi != null)
                {
                    sesi.TermDate = DateTime.Now;
                    if (rep.Upd(sesi).Commit())
                        return Message.Succ("خروج‌ازسیستم", " شنا.کار " , sesi.UsrRef);

                    return Message.Fail("خروج‌ازسیستم", " شنا.کار " , sesi.UsrRef);
                }

                return Message.NotExist("خروج‌ازسیستم", " شنا.نِش " , sesi.Id);
            }
        }

        public Message RegisterTheAgent(Mission mis, Agent ag)
        {
            using (var rep = new Repository(csName))
            {
                ag.MisRef = mis.Id;
                ag.Mission = mis;

                if (rep.Add(mis).Add(ag).Commit())
                    return Message.Succ("پذیرش", " شنا.مام " , ag.Id, " شنا.مات " , mis.Id);
                else
                    return Message.Fail("پذیرش", " شنا.مام ", ag.Id, " شنا.مات ", mis.Id);
            }
        }

        public Message UpdateAgentAndMission(Agent ag, Mission mi)
        {
            using (var rep = new Repository(csName))
            {
                if (rep.Upd(mi).Upd(ag).Commit())
                    return Message.Succ("بروزرسانی‌مامور و مشخصات‌ماموریت", " شنا.مام ", ag.Id, " شنا.مات ", mi.Id);
            }

            return Message.Fail("بروزرسانی‌مامور و مشخصات‌ماموریت", " شنا.مام ", ag.Id, " شنا.مات ", mi.Id);
        }

        public Message DismissTheAgent(Agent ag, DateTime retToUnt)
        {
            using (var rep = new Repository(csName))
            {
                var exAg = rep.Ret<Agent>(a => a.Id == ag.Id);
                if (exAg == null)
                    return Message.NotExist("پایان‌مامور", " شنا.مام ", ag.Id, " م.ب.ی " , retToUnt.ToShortDateString());
                else if (exAg.Enbl == false)
                    return Message.NotExist("پایان‌مامور", " شنا.مام ", ag.Id, " غیرفعال ", " م.ب.ی " , retToUnt.ToShortDateString());

                ag.Enbl = false;
                
                var exMi = rep.Ret<Mission>(s => s.Id.Equals(ag.MisRef) && s.Ret2UntDate.Equals(null));
                if (exMi == null)
                    return Message.NotExist("پایان‌ماموریت", " شنا.مات " , exMi.Id);

                exMi.Ret2UntDate = retToUnt;

                if (rep.Upd(ag).Upd(exMi).Commit())
                    return Message.Succ("پایان‌ماموریت", " شنا.مات " , exMi.Id);

                return Message.Fail("پایان‌ماموریت", " شنا.مات " , exMi.Id);
            }
        }

        public Message AddNewMission(Agent ag, DateTime recp, int offcId, int sprtId, string ordr, int sesi)
        {
            using (var rep = new Repository(csName))
            {
                var prev = rep.Ret<Mission>(m => m.Id == ag.MisRef);
                prev.Last = false; // ماموریت قبلی، دیگر آخرین ماموریت نیست

                if (rep.Upd(prev).Add(new Mission(recp, sprtId, offcId, ordr, sesi)).Upd(ag).Commit())
                    return Message.Succ("بروزرسانی مامور", " شنا.مام " + ag.Id);
            }

            return Message.Fail("بروزرسانی مامور", " شنا.مام " + ag.Id);
        }

        public Message RegisterTheAgentOnOffice(Agent ag, Int32 ofc)
        {
            using (var rep = new Repository(csName))
            {
                var mis = rep.Ret<Mission>(e => e.Id == ag.MisRef && e.Last == true);
                mis.OffcRef = -1;
                if (rep.Upd(mis).Commit())
                    return Message.Succ("ثبت‌قسمت", " شنا.مام " , ag.Id, " شنا.قِس ", ofc);

                return Message.Fail("ثبت‌قسمت", " شنا.مام ", ag.Id, " شنا.قِس ", ofc);
            }
        }

        public Message RemoveOfficeOfAgent(Agent ag)
        {
            using (var rep = new Repository(csName))
            {
                var mis = rep.Ret<Mission>(e => e.Id == ag.MisRef && e.Last == true);
                mis.OffcRef = -1;
                if (rep.Upd(mis).Commit()) //UpdSingle
                    return Message.Succ("حذف ثبت‌قسمت", " شنا.مام " , ag.Id);

                return Message.Fail("حذف ثبت‌قسمت", " شنا.مام " , ag.Id);
            }
        }

        public Message WriteTheAgentsIteration<T>(Int32 agId, DateTime date) where T: Iterative
        {
            var ag = new Repository(csName).Ret<Agent>(e => e.Id == agId && e.Enbl == true);

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
            using (var r = new Repository())
                if (r.Upd(sign).Commit())
                    return Message.Succ("بروزرسانی‌امضا", " متصدی " , sign.Person);

            return Message.Fail("بروزرسانی‌امضا", " متصدی ", sign.Person, " جایگزین " , sign.Name);
        }

        public Message ExtendMission(Int32 mi, DateTime extDt)
        {
            using (var r = new Repository())
            {
                var mis = r.Ret<Mission>(m => m.Id == mi);
                if (mis != null)
                {
                    mis.DeadLine = extDt;
                    if (r.Upd(mis).Commit()) //UpdSingle
                        return Message.Succ("تمدید‌ماموریت", " شنا.مات ", mi, " تا تاریخ ", extDt.ToString("yyyy/MM/dd"));

                    return Message.Fail("تمدید‌ماموریت", " شنا.مات ", mi, " تا تاریخ ", extDt.ToString("yyyy/MM/dd"));
                }
                else
                    return Message.NotExist("تمدید‌ماموریت", " شنا.مات ", mi, " تا تاریخ ", extDt.ToString("yyyy/MM/dd"));
            }
        }

        public Message RemoveIteration<T>(int id) where T: Iterative
        {
            using (var r = new Repository(csName))
            {
                if (r.Rem<Iterative>(x => x.Id == id && x.Enbl == true).Commit())
                    return Message.Succ("لغو‌عملیات", "شنا.عملیات", id.ToString());

                return Message.Fail("لغو‌عملیات", "شنا.عملیات", id.ToString());
            }
        }

        public Message ResumeMission(int Id)
        {
            using (var rep = new Repository(csName))
            {
                var ag = rep.Ret<Agent>(a => a.MisRef == Id && a.Enbl == false);
                if (ag == null)
                    return Message.NotExist("لغوعملیات پایان", "شنا.ماتِ.ما", Id.ToString());
                else
                    ag.Enbl = true;

                var mis = rep.Ret<Mission>(m => m.Id == Id && m.Last == true);
                if (mis != null)
                {
                    mis.Ret2UntDate = null;
                    if (rep.Upd(mis).Upd(ag).Commit())
                        return Message.Succ("لغوعملیات پایان", "شنا.مات", Id.ToString());
                }
                else
                    return Message.NotExist("لغوعملیات پایان", "شنا.مات", Id.ToString());

                return Message.Fail("لغوعملیات پایان", "شنا.مات", Id.ToString());
            }
        }

        /* ------------------ private merhod(es) ------------------ */

        private bool WriteOperation<T>(T t) where T: Iterative
        {
            using (var rOfT = new Repository(csName))
                if (rOfT.Add(t).Commit()) // AddSingle
                    return true;

            return false;
        }

        private bool NoOtherOperationShouldExistOnThisDate<T>(int Id, DateTime date) where T: Iterative
        {
            // در این تاریخ نباید هیچ گردش‌کاری برای فرد ثبت شده باشد
            using (var repo = new Repository(csName))
                if (null == repo.Ret<Iterative>(o => o.MisRef.Equals(Id) && (o.Date == date) && o.Enbl == true))
                    return true;

            return false;
        }
    }
}
