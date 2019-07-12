/* UNDONE توجه شود که جزییات بیشتری از کد خطا لازم است..
بدین ترتیب که باید هریک از کدهای خطا ساختاری داشته باشند که بتوان محل ایجاد خطا را به آن‌ها افزود */
using System;

namespace smcs.backend.biz
{
    public class BizErrCod
    {
        public readonly static Exception DB_UPDT_FAIL = new ApplicationException();
        public readonly static Exception DB_INS_FAIL = new ApplicationException();

        //TODO استثنای جنریک مینیمالیستی ایجاد شود که درون تست‌ها قابل استفاده باشد
        public readonly static Exception AGNT_ABS_DUTY_CONF = new ApplicationException();
        public readonly static Exception AGNT_OFF_DUTY_CONF = new ApplicationException();
        public readonly static Exception AGNT_OFF_ABS_CONF = new ApplicationException();

        //TODO استثنای جنریک مینیمالیستی ایجاد شود که درون تست‌ها قابل استفاده باشد
        public readonly static Exception SESI_NOT_EXST = new ApplicationException();
        public readonly static Exception ONDUTY_NOT_EXST = new ApplicationException();
        public readonly static Exception ABS_NOT_EXST = new ApplicationException();
        public readonly static Exception OFF_NOT_EXST = new ApplicationException();
        public readonly static Exception MIS_NOT_EXST = new ApplicationException();
        public readonly static Exception AGNT_NOT_EXST = new ApplicationException();
        public readonly static Exception USR_NOT_EXST = new ApplicationException();

        //TODO میتوان این استثنا را بایک خطا ایجاد کرد
        public readonly static Exception OPR_FAIL = new ApplicationException();

        public readonly static bool OPR_SUCC = true;
                               
        public readonly static Exception AGNT_ALRDY_DISSMSD = new ApplicationException();
        public readonly static Exception AGNT_ALRDY_HAS_OFF  = new ApplicationException();
        public readonly static Exception AGNT_ALRDY_HAS_ABS  = new ApplicationException();
        public readonly static Exception AGNT_ALRDY_HAS_DUTY = new ApplicationException();
    }
}
