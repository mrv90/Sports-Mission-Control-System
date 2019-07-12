public class BizErrCod
{
    public readonly static Message UPDT_SIGN_SUCC = Message.Succ("بروزرسانی امضا");
    public readonly static Message EXTN_MIS_SUCC  = Message.Succ("تمدید ماوریت");
    public readonly static Message SIGN_UPDT_FAIL= Message.Fail("بروزرسانی امضا");
    public readonly static Message EXTN_MIS_FAIL = Message.Fail("تمدید ماموریت");
                           
    public readonly static Message OFF_UNDT_ABS_UNTRT_CONF = Message.AlreadyExist("گردش‌گار دیگری");
    public readonly static Message OPR_FAIL = Message.Fail("ثبت گردش‌کار");
                           
    public readonly static Message SESI_NOT_EXST = Message.AlreadyRemoved("نشست انتخاب شده");
                           
    public readonly static Message AG_REM_ITER_SUCC = Message.Succ("حذف گردشکار");
    public readonly static Message WRT_AG_ITER_SUCC = Message.Succ("ثبت گردشکار");
                           
    public readonly static Message RMV_UNTR_FAIL = Message.Fail("حذف اعزام‌به‌بهداری");
    public readonly static Message WRT_UNTRT_FAIL= Message.Fail("ثبت اعزام‌به‌بهداری");
                           
    public readonly static Message RMV_ABS_FAIL = Message.Fail("حذف نهست");
    public readonly static Message WRT_ABS_FAIL = Message.Fail("ثبت نهست");
    public readonly static Message ABS_NOT_EXST = Message.AlreadyRemoved("نهست انتخاب شده");
                           
    public readonly static Message RMV_ONDUT_FAIL = Message.Fail("حذف امورخدمتی");
    public readonly static Message WRT_ONDUT_FAIL = Message.Fail("ثبت امورخدمتی");
    public readonly static Message ONDUT_NOT_EXST = Message.AlreadyRemoved("امورخدمتی انتخاب شده");
                           
    public readonly static Message RMV_OFF_FAIL = Message.Fail("حذف مرخصی");
    public readonly static Message WRT_OFF_FAIL = Message.Fail("ثبت مرخصی");
    public readonly static Message OFF_NOT_EXST = Message.AlreadyRemoved("مرخصی انتخاب شده قبل‌تر از سیستم حذف شده");
                           
    public readonly static Message AG_OFC_REM_SUCC = Message.Succ("ثبت قسمت مامور");
    public readonly static Message AG_REG_OFC_SUCC = Message.Succ("حذف قسمت مامور");
    public readonly static Message AG_OFC_REM_FAIL = Message.Fail("حذف قسمت مامور");
    public readonly static Message AG_OFC_REG_FAIL = Message.Fail("ثبت قسمت مامور");
                           
    public readonly static Message AG_DISM_SUCC = Message.Succ("ثبت پایان ماموریت");
    public readonly static Message AG_DISM_FAIL = Message.Fail("ثبت پایان ماموریت");
    public readonly static Message MIS_NOT_EXST = Message.AlreadyRemoved("ماموریت");
                           
    public readonly static Message AG_N_MIS_UPDT_SUCC = Message.Succ("بروزرسانی مامور و ماوریت او");
    public readonly static Message AG_N_MIS_UPDT_FAIL = Message.Fail("بروزرسانی مامور و ماوریت او");

    public readonly static Message AG_UPDT_SUCC = Message.Succ("بروزرسانی مشخصات مامور");
    public readonly static Message AG_UPDT_FAIL = Message.Fail("بروزرسانی مشخصات مامور");
    public readonly static Message AG_REG_SUCC = Message.Succ("پذیرش مامور");
    public readonly static Message AG_REG_FAIL = Message.Fail("پذیرش مامور");
    public readonly static Message AGNT_ALRDY_DISM = Message.AlreadyExist("پایان کاربر یادشده");
    public readonly static Message AGNT_NOT_EXST = Message.AlreadyRemoved("کاربر انتخاب شده");
                           
    public readonly static Message LOG_OUT_FAIL = Message.Fail("خروج از سیستم");
    public readonly static Message LOG_OUT_SUCC = Message.Succ("خروج از سیستم");
    public readonly static Message LOG_IN_FAIL = Message.LogInFail("ورود به سیستم امکان‌پذیر نیست؛ احتمالا رمز عبور نامعتبر است");
    public readonly static Message LOG_IN_SUCC = Message.Succ("خروج از سیستم");
                           
    public readonly static Message USR_NOT_EXST = Message.AlreadyRemoved("کاربر انتخاب شده");

}