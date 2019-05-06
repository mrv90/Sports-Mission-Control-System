using System;

public static class ExtensionMethods
{
    public static Int16 ToInt16(this string str)
    {
        if (!string.IsNullOrWhiteSpace(str) && str.VerifyThisIsNumber())
            return Convert.ToInt16(str);

        return 0;
    }
    public static Int32 ToInt32(this string str)
    {
        if (!string.IsNullOrWhiteSpace(str) && str.VerifyThisIsNumber())
            return Convert.ToInt32(str);

        return 0;
    }
    public static Int64 ToInt64(this string str)
    {
        if (!string.IsNullOrWhiteSpace(str) && str.VerifyThisIsNumber())
            return Convert.ToInt64(str);

        return 0;
    }
    public static UInt16 ToUInt16(this string str)
    {
        if (!string.IsNullOrWhiteSpace(str) && str.VerifyThisIsNumber())
            return Convert.ToUInt16(str);

        return 0;
    }
    public static UInt32 ToUInt32(this string str)
    {
        if (!string.IsNullOrWhiteSpace(str) && str.VerifyThisIsNumber())
            return Convert.ToUInt32(str);

        return 0;
    }
    public static UInt64 ToUInt64(this string str)
    {
        if (!string.IsNullOrWhiteSpace(str) && str.VerifyThisIsNumber())
            return Convert.ToUInt64(str);

        return 0;
    }
    public static decimal ToDecimal(this string str)
    {
        if (!string.IsNullOrWhiteSpace(str) && str.VerifyThisIsNumber())
            return Convert.ToDecimal(str);

        return 0;
    }
}