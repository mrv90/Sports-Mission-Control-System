using System;

[Obsolete("به صورت مستقیم از کلاس پیغام استفاده شود", true)]
public class BizErrCod
{
    public Message UPDT_SIGN_SUCC = Message.Succ("بروزرسانی امضا");

    public Message EXTN_MIS_SUCC  = Message.Succ("تمدید ماموریت");
    public Message SIGN_UPDT_FAIL= Message.Fail("بروزرسانی امضا");
    public Message EXTN_MIS_FAIL = Message.Fail("تمدید ماموریت");
           
    public Message OFF_UNDT_ABS_UNTRT_CONF = Message.AlreadyExist("گردش‌گار دیگری");
    public Message OPR_FAIL = Message.Fail("ثبت گردش‌کار");
           
    public Message SESI_NOT_EXST = Message.AlreadyRemoved("نشست انتخاب شده");
           
    public Message AG_REM_ITER_SUCC = Message.Succ("حذف گردشکار");
    public Message WRT_AG_ITER_SUCC = Message.Succ("ثبت گردشکار");
           
    public Message RMV_UNTR_FAIL = Message.Fail("حذف اعزام‌به‌بهداری");
    public Message WRT_UNTRT_FAIL= Message.Fail("ثبت اعزام‌به‌بهداری");
           
    public Message RMV_ABS_FAIL = Message.Fail("حذف نهست");
    public Message WRT_ABS_FAIL = Message.Fail("ثبت نهست");
    public Message ABS_NOT_EXST = Message.AlreadyRemoved("نهست انتخاب شده");
           
    public Message RMV_ONDUT_FAIL = Message.Fail("حذف امورخدمتی");
    public Message WRT_ONDUT_FAIL = Message.Fail("ثبت امورخدمتی");
    public Message ONDUT_NOT_EXST = Message.AlreadyRemoved("امورخدمتی انتخاب شده");
           
    public Message RMV_OFF_FAIL = Message.Fail("حذف مرخصی");
    public Message WRT_OFF_FAIL = Message.Fail("ثبت مرخصی");
    public Message OFF_NOT_EXST = Message.AlreadyRemoved("مرخصی انتخاب شده قبل‌تر از سیستم حذف شده");
           
    public Message AG_OFC_REM_SUCC = Message.Succ("ثبت قسمت مامور");
    public Message AG_REG_OFC_SUCC = Message.Succ("حذف قسمت مامور");
    public Message AG_OFC_REM_FAIL = Message.Fail("حذف قسمت مامور");
    public Message AG_OFC_REG_FAIL = Message.Fail("ثبت قسمت مامور");
           
    public Message AG_DISM_SUCC = Message.Succ("ثبت پایان ماموریت");
    public Message AG_DISM_FAIL = Message.Fail("ثبت پایان ماموریت");
    public Message MIS_NOT_EXST = Message.AlreadyRemoved("ماموریت");
           
    public Message AG_N_MIS_UPDT_SUCC = Message.Succ("بروزرسانی مامور و ماموریت او");
    public Message AG_N_MIS_UPDT_FAIL = Message.Fail("بروزرسانی مامور و ماموریت او");

    public Message AG_UPDT_SUCC = Message.Succ("بروزرسانی مشخصات مامور");
    public Message AG_UPDT_FAIL = Message.Fail("بروزرسانی مشخصات مامور");
    public Message AG_REG_SUCC = Message.Succ("پذیرش مامور");
    public Message AG_REG_FAIL = Message.Fail("پذیرش مامور");
    public Message AGNT_ALRDY_DISM = Message.AlreadyExist("پایان کاربر یادشده");
    public Message AGNT_NOT_EXST = Message.AlreadyRemoved("کاربر انتخاب شده");
           
    public Message LOG_OUT_FAIL = Message.Fail("خروج از سیستم");
    public Message LOG_OUT_SUCC = Message.Succ("خروج از سیستم");
    public Message LOG_IN_FAIL = Message.LogInFail("ورود به سیستم امکان‌پذیر نیست؛ احتمالا رمز عبور نامعتبر است");
    public Message LOG_IN_SUCC = Message.Succ("خروج از سیستم");
           
    public Message USR_NOT_EXST = Message.AlreadyRemoved("کاربر انتخاب شده");
}