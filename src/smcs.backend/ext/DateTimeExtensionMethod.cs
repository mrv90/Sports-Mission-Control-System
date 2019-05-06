using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

public static class DateTimeExtensionMethod
{
    [Obsolete("this ext-method no longer needed on win 10", true)]
    public static DateTime ToPersionCalendar(this DateTime date)
    {
        string day;
        string month;
        string year;
            
        if (date.Year < 1000)
        {
            throw new ArgumentOutOfRangeException("the year less than 1000 is illegal");
        }
        else
        {
            PersianCalendar calendar = new PersianCalendar();
            day = calendar.GetDayOfMonth(date).ToString("00");
            month = calendar.GetMonth(date).ToString("00");
            year = calendar.GetYear(date).ToString();
        }

        return new DateTime(year.ToInt32(), month.ToInt32(), day.ToInt32());
    }
    public static DateTime ToLatinCalendar(this DateTime date)
    {
        throw new NotImplementedException();
        
        //string day;
        //string month;
        //string year;

        //if (date.Year < 1000)
        //{
        //    throw new ArgumentOutOfRangeException();
        //}
        //else
        //{
        //    GregorianCalendar calendar = new GregorianCalendar();
        //    day = calendar.GetDayOfMonth(date).ToString("00");
        //    month = calendar.GetMonth(date).ToString("00");
        //    year = calendar.GetYear(date).ToString();
        //}

        //return new DateTime(year.ToInt32(), month.ToInt32(), day.ToInt32());
    }
}
