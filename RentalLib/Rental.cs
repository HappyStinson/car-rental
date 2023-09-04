namespace RentalLib;

public class Rental
{
    public string BookingNumber { get; }
    public string LicensePlateNumber { get; set; } // maybe better to store the whole car?
    public string CustomerID { get; set; }
    public CarType carType;
    //public Car Car { get; set; }
    public DateTime PickUpDate { get; set; }
    public uint TravelledKilometersBeforeRent { get; }

    // used for calculating cost
    public int daysRented { get; set; }
    public uint totalKm { get; set; }

// Begin rental / pick-up
    public Rental(Car car, string customerID)
    {
        BookingNumber = $"{car.LicensePlateNumber}-{car.OdometerReading}";
    }

    public Rental(string customerID, Car car)
    {
        BookingNumber = $"{car.LicensePlateNumber}-{car.OdometerReading}";
        LicensePlateNumber = car.LicensePlateNumber;
        CustomerID = customerID;
        carType = car.Type;
        PickUpDate = DateTime.Now;
        TravelledKilometersBeforeRent = car.OdometerReading;
    }

// End rental / drop-off
    public void DropOffCar(DateTime dropOff, uint travelledKilometersAfterRent)
    {
        daysRented = (dropOff - PickUpDate).Days;
        totalKm = travelledKilometersAfterRent - TravelledKilometersBeforeRent;
    }
}
