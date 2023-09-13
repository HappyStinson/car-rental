namespace RentalLib;

public class DataAccess : IDataAccess
{
    private List<ICar> _cars;
    private List<IRental> _rentals;
    public DataAccess()
    {
        _cars = new List<ICar>();
        _rentals = new List<IRental>();
    }

    public void AddNewCar(ICar car, string licensePlateNumber)
    {
        car.SetLicensePlateNumber(licensePlateNumber);
        car.Type = CarType.Car;
        _cars.Add(car);
    }

    public void AddNewRental(IRental rental)
    {
        // var rental2 = Factory.CreateRental();
        _rentals.Add(rental);
    }

    public ICar GetCar(string licensePlateNumber)
    {
        return _cars.Find(x => x.LicensePlateNumber == licensePlateNumber);
    }

    public IRental GetRental(string bookingNumber)
    {
        // gets empty rental if we pass in null
        return _rentals.Find(x => x.BookingNumber == bookingNumber);
    }
}