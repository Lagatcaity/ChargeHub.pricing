namespace ChargeHub.Pricing;
public abstract class ChargingStation : IReportable
{ public string Id { get; }
public decimal MaxKw {get; }
protected ChargingStation(string id, decimal maxKw)
{
    Id = id;
    MaxKw = maxKw;
}
public abstract decimal CalculatePrice(decimal kWh);
public string GetReport()
{
    return $"Station {Id}: {MaxKw} kW";
}
}