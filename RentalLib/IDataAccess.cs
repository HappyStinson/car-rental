namespace RentalLib;

public interface IDataAccess
{
    public void AddNewCar(ICar car, string licensePlateNumber);
    public void AddNewRental(IRental rental);
    public ICar GetCar(string licensePlateNumber);

    public IRental GetRental(string bookingNumber);
}