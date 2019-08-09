using System;
using System.Collections.Generic;
using System.Linq;

public static class TypeExtensionMethod
{
    static Dictionary<string, string> dic = new Dictionary<string, string>()
    {
        {"Office", "قسمت"},
        {"Rank", "درجه"},
        {"Signature", "امضا"},
        {"Sports", "رشته"},
        {"Unit", "یگان"},
        {"Absence", "نهست"},
        {"OffDay", "مرخصی"},
        {"OnDuty", "امورخدمتی"},
        {"Agent", "مامور"},
        {"Mission", "ماموریت"},
        {"Session", "نشست"},
        {"User", "کاربر"},
        {"UndTreat", "اعزام‌به‌بهداری" }
    };
        
    public static string ToPersianName(this Type type)
    {
        string value = "";
        if (dic.ContainsKey(type.Name))
            dic.TryGetValue(type.Name, out value);

        return value;
    }

    public static string ToEnglishName(this string persian)
    {
        //var assembly = Assembly.GetExecutingAssembly();

        //if (dic.ContainsValue(persian))
        //    return assembly.GetType(dic.FirstOrDefault(x => x.Value == persian).Key).Name;

        if (dic.ContainsValue(persian))
            return dic.FirstOrDefault(x => x.Value == persian).Key;

        return null;
    }
}
