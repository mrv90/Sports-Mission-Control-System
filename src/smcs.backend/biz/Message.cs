using smcs.backend.biz;
using System;
using System.Drawing;

public class Message
{
    public static readonly int NOT_EXST = -2;
    public static readonly int FAIL = -1;
    public static readonly int SUCC = 0;
    public static readonly int ALDY_EXST = 1;
    public static readonly int CONFLICT = 2;

    public int Id { get; private set; }

    public string Text { get; private set; }

    public Color Color { get; private set; }

    private Message(int id, string txt, Color clr)
    {
        this.Id = id;
        this.Text = txt;
        this.Color = clr;
    }

    public static Message Fail(string opr, params string[] args)
    {
        var msg = new Message(FAIL, DateTime.Now.ToShortTimeString() + " - " + " شکست" + opr + "؛ " + args, Color.Red);
        MessageObserver.Notify(msg);
        return msg;
    }

    public static Message Succ(string opr, params string[] args)
    {
        var msg = new Message(SUCC, DateTime.Now.ToShortTimeString() + " - " + " عملیات موفق" + opr + "؛ " + args, Color.Green);
        MessageObserver.Notify(msg);
        // ثبت عملیات موفق در کارکرد روزانه
        return msg;
    }

    public static Message AlreadyExist(string opr, params string[] args)
    {
        var msg = new Message(ALDY_EXST, DateTime.Now.ToShortTimeString() + " - " + " عملیات" + opr + " به علت تکراری بودن مقادیر " + args + ".لغو شد ", Color.Black);
        MessageObserver.Notify(msg);
        return msg;
    }

    public static Message NotExist(string opr, params string[] args)
    {
        var msg = new Message(NOT_EXST, DateTime.Now.ToShortTimeString() + " - " + " عملیات" + opr + " به علت عدم وجود مقادیر " + args + ".لغو شد ", Color.Black);
        MessageObserver.Notify(msg);
        return msg;
    }

    internal static Message Conflict(string opr, params string[] args)
    {
        var msg = new Message(CONFLICT, DateTime.Now.ToShortTimeString() + " - " + " عملیات" + opr + " به علت مغایرت و همپوشانی مقادیر " + args + ".لغو شد ", Color.Black);
        MessageObserver.Notify(msg);
        return msg;
    }
}