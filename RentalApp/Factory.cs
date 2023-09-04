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
}