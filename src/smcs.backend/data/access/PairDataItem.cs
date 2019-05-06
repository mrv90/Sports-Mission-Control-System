using System;

public class PairDataItem
{
    public Int32 Id { get; set; }
    public string Value { get; set; }

    public PairDataItem(Int32 id, string value)
    {
        this.Id = id;
        this.Value = value;
    }

    public override string ToString()
    {
        return Value;
    }
}