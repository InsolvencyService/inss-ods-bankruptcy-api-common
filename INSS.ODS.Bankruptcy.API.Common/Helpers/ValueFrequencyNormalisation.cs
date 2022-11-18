namespace INSS.ODS.Bankruptcy.API.Common.Helpers;

public static class ValueFrequencyNormalisation
{
    /// <summary>
    /// Calculates a value as per-month
    /// </summary>
    /// <param name="amount">Value to be normalised</param>
    /// <param name="frequency">Frequency of specified value</param>
    /// <returns>A normalised (per-month) equvialent of specified amount.
    /// Replaces nulls with zero.</returns>
    public static decimal Normalise(decimal? amount, string frequency)
    {
        if (!amount.HasValue) { return 0; }
        if (amount == 0) { return 0; }
        if (String.IsNullOrEmpty(frequency)) { return amount ?? 0;}
        
        switch (frequency)
        {
            case "per week":
                return Math.Round((amount.Value * 52) / 12, 2);
            case "per fortnight":
                return Math.Round((amount.Value * 26) / 12, 2);
            case "per 4 weeks":
                return Math.Round((amount.Value * 52/4) / 12, 2);
            case "per year":
                return Math.Round(amount.Value / 12, 2);
            case "per month":
                return Math.Round(amount.Value, 2);
            case "per quarter":
                return Math.Round((amount.Value*4)/12, 2);
        }

        return 0;
    }

}
