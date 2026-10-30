public static class Reports
{
    public static decimal ParseKwh(string text)
    {
        try
        {
            return decimal.Parse(text);
        }
        catch (FormatException ex)
        {
            throw new ArgumentException($"Ogiltigt värde: {text}", ex);
        }
    }
}