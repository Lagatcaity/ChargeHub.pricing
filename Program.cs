using System.Collections.Generic;
using ChargeHub.Pricing;

var ac1 = new AcStation("AC-01");
var ac2 = new AcStation("AC-02");
var dc1 = new DcStation("Dc-01");
var vehicle = new Vehicle("1", 75, 0);
List<IReportable> reportables = new()
{vehicle,
ac1,
dc1,
 };
 foreach(var item in reportables)
 {
     Console.WriteLine(item.GetReport());
 }

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
Console.WriteLine($"Dagens intäkter: {total:F2} kr");