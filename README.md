# ChargeHub Pricing

Ett C#-konsolprogram som beräknar dagens intäkter
från AC- och DC-laddstationer.

## Prissättning

- AC: 3,50 kr per kWh
- DC: 5,00 kr per kWh plus 10 kr i startavgift

## Klassdiagram

```mermaid
classDiagram
    class ChargingStation {
        <<abstract>>
        +string Id
        +decimal MaxKw
        +CalculatePrice(decimal kwh) decimal
        +GetReport() string
    }

    class AcStation
    class DcStation

    class Vehicle {
        +string Id
        +double BatteryKwh
        +int Percent
        +GetReport() string
    }

    class IReportable {
        <<interface>>
        +GetReport() string
    }

    ChargingStation <|-- AcStation
    ChargingStation <|-- DcStation
    Vehicle ..|> IReportable
    ChargingStation ..|> IReportable
```

## Resultat

Dagens intäkter: 432 kr.