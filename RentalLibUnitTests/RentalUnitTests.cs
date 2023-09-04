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
}