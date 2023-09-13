using RentalLib;

public static class Factory
{
    public static ICar CreateCar()
    {
        return new Car();
    }

    public static IRental CreateRental()
    {
        return new Rental();
    }

    public static IDataAccess CreateDataAccess()
    {
        return new DataAccess();
    }

    public static IUserInterface CreateUserInterface()
    {
        return new UserInterface();
    }

    public static RentalService CreateRentalService(decimal baseDailyRent = 0, decimal basePricePerKm = 0)
    {
        return new RentalService(baseDailyRent, basePricePerKm, CreateDataAccess(), CreateUserInterface());
    }
}