namespace ChargeHub.Pricing;
public abstract class ChargingStation
{ public string Id { get; }
public decimal MaxKw {get; }
protected ChargingStation(string id, decimal maxKw)
{
    Id = id;
    MaxKw = maxKw;
}
public abstract decimal CalculatePrice(decimal kWh, DateTime startTime, DateTime endTime);
}