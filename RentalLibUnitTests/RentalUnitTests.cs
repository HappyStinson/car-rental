using RentalLib;

namespace RentalLibUnitTests;

public class RentalUnitTests
{
    [Fact]
    public void TestNewRentalCreatesBookingNumber()
    {
        // arrange
        var licensePlateNumber = "ABC123";
        var customerID = "9005071234";
        Car car = new(licensePlateNumber);
        var expected = "ABC123-0";
        Rental rental = new(customerID, car);

        // act
        var actual = rental.BookingNumber;

        // assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestDropOffRentalCar()
    {
        // arrange
        var rental = ArrangeNewRental();
        int expectedDays = 36;
        uint expectedKm = 50;
        var pickUp = DateTime.Now;
        var dropOff = pickUp.AddDays(expectedDays);
        uint actualKmsAfterRent = rental.TravelledKilometersBeforeRent + 50;

        // act
        rental.DropOffCar(dropOff, actualKmsAfterRent);

        // assert
        Assert.Equal(expectedDays, rental.DaysRented);
        Assert.Equal(expectedKm, rental.TotalKm);
    }

    private Rental ArrangeNewRental()
    {
        var licensePlateNumber = "ABC123";
        var customerID = "9005071234";
        Car car = new(licensePlateNumber);

        return new Rental(customerID, car);
    }
}