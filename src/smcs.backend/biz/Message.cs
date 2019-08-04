using smcs.backend.biz;
using System.Drawing;

public class Message
{
    public static readonly int LOG_IN_FAIL = -2;
    public static readonly int FAIL = -1;
    public static readonly int SUCC = 0;
    public static readonly int ALDY_EXST = 1;
    public static readonly int ALDY_REMV = 2;

    public int Id { get; private set; }

    public string Text { get; private set; }

    public Color Color { get; private set; }

    private Message(int id, string txt, Color clr)
    {
        this.Id = id;
        this.Text = txt;
        this.Color = clr;
    }

    public static Message LogInFail(string txt)
    {
        var msg = new Message(-2, txt, Color.Red);
        MessageObserver.Notify(msg);
        return msg;
    }

    public static Message Fail(string opr)
    {
        var msg = new Message(-1, "عملیات " + opr + "با شکست مواجه شد ", Color.Red);
        MessageObserver.Notify(msg);
        return msg;
    }

    public static Message Succ(string opr)
    {
        var msg = new Message(0, "عملیات " + opr + "با موفقیت انجام شد ", Color.Green);
        MessageObserver.Notify(msg);
        return msg;
    }

    public static Message AlreadyExist(string target)
    {
        var msg = new Message(1, target + "قبل‌تر در سیستم ثبت شده ", Color.LightGray);
        MessageObserver.Notify(msg);
        return msg;
    }

    public static Message AlreadyRemoved(string target)
    {
        var msg = new Message(2, target + "قبل‌تر از سیستم حذف شده ", Color.LightGray);
        MessageObserver.Notify(msg);
        return msg;
    }
}