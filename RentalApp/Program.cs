using RentalLib;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Car car = new("ABC123");
Car wagon = new("UBB451", 1337, CarType.StationWagon);
Car truck = new("KHT480", 2598, CarType.Truck);

Rental rental = new("9010162197", car);
Rental rental2 = new("9010162197", wagon);
Rental rental3 = new("9010162197", truck);
var bookingNumber = rental.BookingNumber;

WriteLine(rental.BookingNumber);

// Enter booking number
DateTime dropOff = new(2023, 9, 5);
DateTime dropOff2 = new(2023, 10, 4);
DateTime dropOff3 = new(2023, 11, 4);
uint travelledKilometersAfterRent = rental.TravelledKilometersBeforeRent + 50;

rental.DropOffCar(dropOff, travelledKilometersAfterRent);
rental2.DropOffCar(dropOff2, travelledKilometersAfterRent + 10);
rental3.DropOffCar(dropOff3, travelledKilometersAfterRent + 397);

var cost = CalculateRentalCost(rental);
WriteLine($"Total cost Car: {cost}kr.");

var cost2 = CalculateRentalCost(rental2);
WriteLine($"Total cost Kombi: {cost2}kr.");

var cost3 = CalculateRentalCost(rental3);
WriteLine($"Total cost Lastbil: {cost3}kr.");


decimal CalculateRentalCost(Rental rental) // make static when used as handler func
{
    decimal baseDailyRent = 55; // move to handler class ?
    decimal basePricePerKm = 12; // move to handler
    const decimal stationWagonRate = 1.3M; // keep the rates with the cars?
    const decimal truckRate = 1.5M;

    decimal baseCost = baseDailyRent * rental.daysRented;

    decimal cost = rental.carType switch
    {
        CarType.StationWagon => baseCost * stationWagonRate + basePricePerKm * rental.totalKm,
        CarType.Truck => baseCost * truckRate + basePricePerKm * rental.totalKm * truckRate,
        _ => baseCost, // default type is Car
    };

    WriteLine($"Antal dagar: {rental.daysRented}");
    WriteLine($"All the costs: {baseDailyRent}, {basePricePerKm}, {stationWagonRate}, {truckRate}, {baseCost}. Total {cost} kr.");

    return cost;
}

// try my logic here

// 