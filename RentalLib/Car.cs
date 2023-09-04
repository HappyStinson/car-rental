namespace RentalLib;

public enum CarType
{
    Car,
    StationWagon,
    Truck
}

public class Car
{
    // fields

    // 



    // read-only reg nummer ABC123 eller DEF456G
    public string LicensePlateNumber { get; }
    public uint OdometerReading { get; } // not possible to change externally only from within the car via method
    public static readonly string CarTypeString = "Småbil"; // perhaps delete
    public CarType Type;
    
    public Car(string licensePlateNumber, uint odometerReading = 0, CarType type = CarType.Car)
    {
        LicensePlateNumber = licensePlateNumber; // check correct format
        OdometerReading = odometerReading;
        Type = type;
    }

    // public void AddDistanceToOdometer(uint distance) => OdometerReading += distance;
    
    public virtual string CarInfo()
    {
        return $"{Type} med registreringsnummer {LicensePlateNumber} har kört {OdometerReading} km."; // Type will not work here
    }
}

public class StationWagon : Car
{
    public StationWagon(string licensePlateNumber, uint odometerReading) : base(licensePlateNumber, odometerReading)
    {
        // CarType = "Kombi"; // solve this
    }
}
