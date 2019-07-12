public class Message
{
    public static readonly int LOG_IN_FAIL = -2;
    public static readonly int FAIL = -1;
    public static readonly int SUCC = 0;
    public static readonly int ALDY_EXST = 1;
    public static readonly int ALDY_REMV = 2;

    public int Id { get; private set; }

    public string Text { get; private set; }

    private Message(int id, string txt)
    {
        this.Id = id;
        this.Text = txt;
    }

    public static Message LogInFail(string txt)
    {
        return new Message(-2, txt);
    }

    public static Message Fail(string opr)
    {
        return new Message(-1, "عملیات " + opr + "با شکست مواجه شد ");
    }

    public static Message Succ(string opr)
    {
        return new Message(0, "عملیات " + opr + "با موفقیت انجام شد ");
    }

    public static Message AlreadyExist(string target)
    {
        return new Message(1, target + "قبل‌تر در سیستم ثبت شده ");
    }

    public static Message AlreadyRemoved(string target)
    {
        return new Message(2, target + "قبل‌تر از سیستم حذف شده ");
    }
}