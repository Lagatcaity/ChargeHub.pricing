using ChargeHub.Pricing;
var ac1 = new AcStation("AC1");
var ac2 = new AcStation("AC2");
var dc1 = new DcStation("DC1");

var sessions = new List<(ChargingStation station, decimal kwh)>

{
    (ac1, 20m),
    (dc1, 20m),
    (ac2, 12m),
    (dc1, 40m)
};
decimal total = 0m;
foreach (var session in sessions)
{
   total += session.station.CalculatePrice(session.kwh);
}
Console.WriteLine($"Dagens intäkter: {total : F2} kr");