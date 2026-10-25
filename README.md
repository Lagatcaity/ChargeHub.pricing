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
        +CalculatePrice(decimal kwh) decimal*
    }

    ChargingStation <|-- AcStation
    ChargingStation <|-- DcStation
    class Vehicle{
        +string Id
        +double Batterykwh
        +int percent
        +GetReport()string

    }
    Interface IReportable
```{+GetReport()string
}
Vehicle..|> IReportable
ChargingStation..|> IReportable

## Resultat

Dagens intäkter: 432 kr.