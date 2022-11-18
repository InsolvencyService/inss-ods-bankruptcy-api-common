namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model;

public class LegacyAddress
{
    public int Id { get; set; }
    public string Line1 { get; set; }
    public string Line2 { get; set; }
    public string Line3 { get; set; }
    public string Line4 { get; set; }
    public string Postcode { get; set; }
    public string County { get; set; }
    public string Country { get; set; }

    public string FullAddress
    {
        get
        {
            var addressFields = new List<string>();

            //Only add to array if not empty!
            if (!string.IsNullOrWhiteSpace(Line1)) addressFields.Add(Line1);
            if (!string.IsNullOrWhiteSpace(Line2)) addressFields.Add(Line2);
            if (!string.IsNullOrWhiteSpace(Line3)) addressFields.Add(Line3);
            if (!string.IsNullOrWhiteSpace(Line4)) addressFields.Add(Line4);
            if (!string.IsNullOrWhiteSpace(County)) addressFields.Add(County);
            if (!string.IsNullOrWhiteSpace(Postcode)) addressFields.Add(Postcode);
            if (!string.IsNullOrWhiteSpace(Country)) addressFields.Add(Country);

            return string.Join(", ", addressFields.ToArray());
        }
    }
}