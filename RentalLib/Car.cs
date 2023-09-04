using System.Text.RegularExpressions;

namespace RentalLib;

public enum CarType
{
    Car,
    StationWagon,
    Truck
}

public class Car : ICar
{
    public string? LicensePlateNumber { get; private set; }
    public uint OdometerReading { get; private set; }
    public CarType Type { get; set; }
    
    public Car()
    {
        LicensePlateNumber = null;
        OdometerReading = 0;
        Type = CarType.Car;
    }

    // not use this one in factory?   
    public Car(string licensePlateNumber, uint odometerReading = 0, CarType type = CarType.Car)
    {
        LicensePlateNumber = licensePlateNumber; // check correct format
        OdometerReading = odometerReading;
        Type = type;
    }

    public void SetLicensePlateNumber(string licensePlateNumber)
    {
        if (LicensePlateNumber == null)
        {
            // Valid Swedish formats are ABC123 and ABC12D (excluding O)
            Regex formatChecker = new(@"^[A-Za-z]{3}\d{2,3}[A-Za-z^oO]?$", RegexOptions.IgnoreCase);
            if (formatChecker.IsMatch(licensePlateNumber))
            {
                LicensePlateNumber = licensePlateNumber;
            }
        }
    }
    public void AddDistanceToOdometer(uint distance) => OdometerReading += distance;
    
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
