namespace RentalLib;

public class Car
{
    // fields

    // 



    // read-only reg nummer ABC123 eller DEF456G
    public string LicensePlateNumber { get; }
    public uint OdometerReading { get; } // not possible to change externally only from within the car via method
    public static readonly string CarType = "Småbil";
    
    public Car(string licensePlateNumber, uint odometerReading = 0)
    {
        LicensePlateNumber = licensePlateNumber; // check correct format
        OdometerReading = odometerReading;
    }
    
    public virtual string CarInfo()
    {
        return $"{CarType} med registreringsnummer {LicensePlateNumber} har kört {OdometerReading} km.";
    }
}

public class StationWagon : Car
{
    public StationWagon(string licensePlateNumber, uint odometerReading) : base(licensePlateNumber, odometerReading)
    {
        // CarType = "Kombi"; // solve this
    }
}
