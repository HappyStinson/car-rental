using RentalLib;

namespace RentalLibUnitTests;

public class RentalUnitTests
{
    [Fact]
    public void TestPrintHello()
    {
        // arrange
        string expected = "Hello from RentalLib";
        Rental rental = new();

        // act
        string actual = rental.Hello();

        // assert
        Assert.Equal(expected, actual);
    }
}