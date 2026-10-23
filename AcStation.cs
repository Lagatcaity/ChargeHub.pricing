namespace ChargeHub.Pricing;
public class AcStation : ChargingStation
{ public AcStation(string id)
:base(id, 11m)
{}
public override decimal CalculatePrice(decimal kWh)
{ return kWh * 3.50m;}}