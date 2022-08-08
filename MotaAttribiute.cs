using System;

public class MotaAttribute : Attribute{
    public string Description{ get; set; }

    public MotaAttribute(string v) => Description = v;
}