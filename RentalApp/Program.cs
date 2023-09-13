using RentalLib;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var rentalService = Factory.CreateRentalService(55, 12);

rentalService.RentCar();
rentalService.ReturnCar();



// var car = Factory.CreateCar();
// car.SetLicensePlateNumber("ABC123");

// Car wagon = new("UBB451", 1337, CarType.StationWagon);
// Car truck = new("KHT480", 2598, CarType.Truck);

// var rental = Factory.CreateRental();
// rental.PickUp(car, "9010162197");
// Rental rental2 = new("9010162197", wagon);
// Rental rental3 = new("9010162197", truck);
// var bookingNumber = rental.BookingNumber;

// WriteLine(rental.BookingNumber);

// // Enter booking number
// DateTime dropOff = new(2023, 9, 8);
// DateTime dropOff2 = new(2023, 10, 4);
// DateTime dropOff3 = new(2023, 11, 4);
// uint travelledKilometersAfterRent = rental.TravelledKilometersBeforeRent + 50;

// rental.DropOffCar(dropOff, travelledKilometersAfterRent);
// rental2.DropOffCar(dropOff2, travelledKilometersAfterRent + 10);
// rental3.DropOffCar(dropOff3, travelledKilometersAfterRent + 397);

// var cost = rentalService.CalculateRent(rental);
// WriteLine($"Total cost Car: {cost}kr.");

// var cost2 = CalculateRentalCost(rental2);
// WriteLine($"Total cost Kombi: {cost2}kr.");

// var cost3 = CalculateRentalCost(rental3);
// WriteLine($"Total cost Lastbil: {cost3}kr.");
