namespace RentalLib;

public interface IRental
{
    public string? BookingNumber { get; }
    public string CarLicensePlateNumber { get; set; }
    public string CustomerID { get; set; }
    public CarType CarType { get; set; }
    public DateTime PickUpDate { get; set; }
    public uint TravelledKilometersBeforeRent { get; }

    // used for calculating cost
    public int DaysRented { get; set; }
    public uint TotalKm { get; set; }

    public void PickUp(ICar car, string customerID);

    public void DropOffCar(DateTime dropOff, uint travelledKilometersAfterRent);

    // private int CalculateCost ?
}
