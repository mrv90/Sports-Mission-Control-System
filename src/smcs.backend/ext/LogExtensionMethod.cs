using System;

public static class LogExtensionMethod
{
    private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    public static void Log(this Exception e)
    {
        log.Fatal(e.Message, e);
    }

    public static void Log(this string s)
    {
        log.Error(s);
    }
}