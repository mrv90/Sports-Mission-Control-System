using System;

public class BizErrCod
{
    public readonly static int DB_UPDT_FAIL = -101;
    public readonly static int DB_INS_FAIL = -100;
                               
    public readonly static int AGNT_ABS_DUTY_CONF = -11;
    public readonly static int AGNT_OFF_DUTY_CONF = -10;
    public readonly static int AGNT_OFF_ABS_CONF = -9;
                               
    public readonly static int SESI_NOT_EXST = -8;
    public readonly static int ONDUTY_NOT_EXST = -7;
    public readonly static int ABS_NOT_EXST = -6;
    public readonly static int OFF_NOT_EXST = -5;
    public readonly static int MIS_NOT_EXST = -4;
    public readonly static int AGNT_NOT_EXST = -3;
    public readonly static int USR_NOT_EXST = -2;
                               
    public readonly static int OPR_FAIL = -1;

    public readonly static int OPR_SUCC = 0;
                               
    public readonly static int AGNT_ALRDY_DISSMSD = 1;
    public readonly static int AGNT_ALRDY_HAS_OFF  = 2;
    public readonly static int AGNT_ALRDY_HAS_ABS  = 3;
    public readonly static int AGNT_ALRDY_HAS_DUTY = 4;
}