public class DcStation : ChargingStation
{ public DcStation(string id)
:base(id, 150m)
{}
public override decimal CalculatePrice(decimal kWh)
{ return kWh * 5.00m + 10m;}}