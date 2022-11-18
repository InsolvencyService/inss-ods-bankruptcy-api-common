namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model;

public class StringDto
{
    public string Value { get; set; }

    public StringDto(string value)
    {
        Value = value;
    }

    public override string ToString()
    {
        return Value;
    }
}
