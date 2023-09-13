using RentalLib;

public class RentalService // not possible as static?
{
    public decimal BaseDailyRent { get; set; }
    public decimal BasePricePerKm { get; set; }

    private const decimal _stationWagonRate = 1.3M;
    private const decimal _truckRate = 1.5M;

    private IDataAccess _dataAccess;
    private IUserInterface _userInterface;

    public RentalService()
    {
        BaseDailyRent = 0;
        BasePricePerKm = 0;

        _dataAccess = null;
        _userInterface = null;
    }

    public RentalService(decimal baseDailyRent, decimal basePricePerKm, IDataAccess dataAccess, IUserInterface userInterface)
    {
        BaseDailyRent = baseDailyRent;
        BasePricePerKm = basePricePerKm;

        _dataAccess = dataAccess;
        _userInterface = userInterface;
    }

    public void RentCar()
    {
        _userInterface.ShowInfoForRentingCar();
        var input = _userInterface.GetInputForRentingCar();

        var licensePlateNumber = input[0];
        var customerID = input[1];

        // check if car is new or previously created
        ICar car = _dataAccess.GetCar(licensePlateNumber);
        if (car == null)
        {
            _dataAccess.AddNewCar(Factory.CreateCar(), licensePlateNumber);
            car = _dataAccess.GetCar(licensePlateNumber);
        }

        // time to create rental when we have a car
        _dataAccess.AddNewRental(Factory.CreateRental());
        var rental = _dataAccess.GetRental(null);
        rental.PickUp(car, customerID);

        _userInterface.ShowBookingDetails(rental);
    }

    public void ReturnCar()
    {
        // implement this properly...


        // Enter booking number
        var bookingNumber = "ABC123-0";
        var rental = _dataAccess.GetRental(bookingNumber);


        DateTime dropOff = new(2023, 9, 8);
        uint travelledKilometersAfterRent = rental.TravelledKilometersBeforeRent + 50;
        rental.DropOffCar(dropOff, travelledKilometersAfterRent);

        _userInterface.ShowCostDetails(CalculateRent(rental));
    }

    public RentalCost CalculateRent(IRental rental)
    {
        RentalCost costs = new(); // use Factory?
        decimal baseCost = BaseDailyRent * rental.DaysRented;

        // decimal cost = rental.CarType switch
        // {
        //     CarType.StationWagon => baseCost * _stationWagonRate + BasePricePerKm * rental.TotalKm,
        //     CarType.Truck => baseCost * _truckRate + BasePricePerKm * rental.TotalKm * _truckRate,
        //     _ => baseCost, // default type is Car
        // };

        // just for testing, extract to UserInterface somehow, rental cost class or struct? inside rental object?
        // WriteLine($"Antal dagar: {rental.DaysRented}");
        // WriteLine($"All the costs: {BaseDailyRent}, {BasePricePerKm}, {_stationWagonRate}, {_truckRate}, {baseCost}. Total {cost} kr.");

        costs.BookingNumber = rental.BookingNumber;
        costs.TotalCost = baseCost;

        return costs;
    }
}