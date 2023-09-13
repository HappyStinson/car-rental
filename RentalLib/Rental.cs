namespace RentalLib;

public class Rental : IRental
{
    public string? BookingNumber { get; private set; }
    public string CarLicensePlateNumber { get; set; }
    public string CustomerID { get; set; }
    public CarType CarType { get; set; }
    public DateTime PickUpDate { get; set; }
    public uint TravelledKilometersBeforeRent { get; private set; }

    // used for calculating cost
    public int DaysRented { get; set; }
    public uint TotalKm { get; set; }

    public Rental()
    {
        BookingNumber = null;
    }

// Begin rental / pick-up
    public Rental(ICar car, string customerID)
    {
        BookingNumber = $"{car.LicensePlateNumber}-{car.OdometerReading}";
    }

    public Rental(string customerID, ICar car)
    {
        BookingNumber = $"{car.LicensePlateNumber}-{car.OdometerReading}";
        CarLicensePlateNumber = car.LicensePlateNumber;
        CustomerID = customerID;
        CarType = car.Type;
        PickUpDate = DateTime.Now;
        TravelledKilometersBeforeRent = car.OdometerReading;
    }

    public void PickUp(ICar car, string customerID)
    {
        BookingNumber = $"{car.LicensePlateNumber}-{car.OdometerReading}";

        CarLicensePlateNumber = car.LicensePlateNumber;
        CustomerID = customerID;
        CarType = car.Type;
        PickUpDate = DateTime.Now;
        TravelledKilometersBeforeRent = car.OdometerReading;
    }

// End rental / drop-off
    public void DropOffCar(DateTime dropOff, uint travelledKilometersAfterRent)
    {
        DaysRented = (dropOff - PickUpDate).Days;
        TotalKm = travelledKilometersAfterRent - TravelledKilometersBeforeRent;
    }
}
