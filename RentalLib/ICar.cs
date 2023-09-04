namespace RentalLib;

public interface ICar
{
    public string LicensePlateNumber { get; }
    public uint OdometerReading { get; }
    public CarType Type { get; set; }
    
    public void SetLicensePlateNumber(string licensePlateNumber);
}