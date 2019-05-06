using System;
using System.Text.RegularExpressions;

public static class StringExtensionMethods
{
    public static bool VerifyThisIsNumber(this string str)
    {
        Regex regex = new Regex(@"\d+");
        if (regex.IsMatch(str))
            return true;

        return false;
    }
    public static bool VerifyThisIsFloatOrDouble(this string str)
    {
        Regex regex = new Regex(@"\d*\.\d+%?");
        if (regex.IsMatch(str))
            return true;

        return false;
    }
    public static bool VerifyThisIsEnglishChars(this string str)
    {
        Regex regex = new Regex(@"^[a-zA-Z0-9\_]+$");
        if (regex.IsMatch(str))
            return true;
        
        return false;
    }
}
