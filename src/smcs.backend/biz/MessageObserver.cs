using System.Collections.Generic;

namespace smcs.backend.biz
{
    public class MessageObserver
    {
        static List<IMessageListener> listeners = new List<IMessageListener>();

        public static void Attach(IMessageListener listener)
        {
            if (!listeners.Contains(listener))
                listeners.Add(listener);
        }

        public static void Detach(IMessageListener listener)
        {
            if (listeners.Contains(listener))
                listeners.Remove(listener);
        }

        internal static void Notify(Message msg)
        {
            // TODO به منظور ایجاد کارکرد روزانه، باید در اینجا پیغام مورد نظر در دیتابیس ثبت شود

            foreach (var l in listeners)
                l.update(msg);
        }
    }
}