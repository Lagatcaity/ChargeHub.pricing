using System;

namespace ChargeHub.Pricing;

    public class Vehicle
    {
        public string Id { get; }
        public double BatteryKwh { get; }
        public int Percent { get; private set; }

        public Vehicle(string id, double batteryKwh, int percent)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Id must be provided.", nameof(id));

            if (batteryKwh <= 0)
                throw new ArgumentOutOfRangeException(nameof(batteryKwh), "BatteryKwh must be greater than 0.");

            if (percent < 0 || percent > 100)
                throw new ArgumentOutOfRangeException(nameof(percent), "Percent must be between 0 and 100.");

            Id = id;
            BatteryKwh = batteryKwh;
            Percent = percent;
        }

        public void Charge(double kwh)
        {
            if (kwh <= 0)
                throw new ArgumentOutOfRangeException(nameof(kwh), "kwh must be greater than 0.");

            double increasedPercent = (kwh / BatteryKwh) * 100;
            Percent = (int)Math.Min(100, Percent + increasedPercent);
        }
    }
