using RentalLib;

public class RentalService // not possible as static?
{
    public decimal BaseDailyRent { get; set; }
    public decimal BasePricePerKm { get; set; }
    private const decimal _stationWagonRate = 1.3M;
    private const decimal _truckRate = 1.5M;

    public RentalService()
    {
        BaseDailyRent = 0;
        BasePricePerKm = 0;
    }

    public decimal CalculateRentalCost(IRental rental)
    {
        decimal baseCost = BaseDailyRent * rental.DaysRented;

        decimal cost = rental.CarType switch
        {
            CarType.StationWagon => baseCost * _stationWagonRate + BasePricePerKm * rental.TotalKm,
            CarType.Truck => baseCost * _truckRate + BasePricePerKm * rental.TotalKm * _truckRate,
            _ => baseCost, // default type is Car
        };

        // just for testing
        WriteLine($"Antal dagar: {rental.DaysRented}");
        WriteLine($"All the costs: {BaseDailyRent}, {BasePricePerKm}, {_stationWagonRate}, {_truckRate}, {baseCost}. Total {cost} kr.");

        return cost;
    }
}