namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    public class OtherPensionDto
    {
        public int Id { get; set; }
        public decimal? Value { get; set; }
        public string Frequency { get; set; }
        public string Type { get; set; }
    }
}