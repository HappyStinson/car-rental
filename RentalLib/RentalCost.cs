namespace RentalLib;

public class RentalCost
{
    public string BookingNumber { get; set; }
    public decimal TotalCost { get; set; }

    public RentalCost()
    {
        TotalCost = 0;
    }

// keep this here ? hmm maybe not.
    public void CalculateRent(IRental rental)
    {
        TotalCost = 13.37M;
        // decimal baseCost = BaseDailyRent * rental.DaysRented;

        // decimal cost = rental.CarType switch
        // {
        //     CarType.StationWagon => baseCost * _stationWagonRate + BasePricePerKm * rental.TotalKm,
        //     CarType.Truck => baseCost * _truckRate + BasePricePerKm * rental.TotalKm * _truckRate,
        //     _ => baseCost, // default type is Car
        // };

        // // just for testing, extract to UserInterface somehow, rental cost class or struct? inside rental object?
        // WriteLine($"Antal dagar: {rental.DaysRented}");
        // WriteLine($"All the costs: {BaseDailyRent}, {BasePricePerKm}, {_stationWagonRate}, {_truckRate}, {baseCost}. Total {cost} kr.");

        // return cost;
    }
}