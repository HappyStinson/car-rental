using static System.Console; // already included in csproj?

namespace RentalLib;

public class UserInterface : IUserInterface
{
    public UserInterface() {}

    public void ShowInfoForRentingCar()
    {
        WriteLine("Enter the licence plate number and customer ID, separated by a space:");
    }

    public void ShowBookingDetails(IRental rental)
    {
        WriteLine($"Booking Details: {rental.BookingNumber}");
    }

    public void ShowCostDetails(RentalCost costs)
    {
        WriteLine($"Costs for Booking: {costs.BookingNumber}");
        WriteLine($"Total cost Car: {costs.TotalCost}kr.");
    }

    public string[] GetInputForRentingCar()
    {
        var input = ReadLine();
        
        // check that we have license plate and customer id
        // return as two strings?

        // would be nice with a static class to verify user input with regex etc.

        // to allow more licenseplates i dont want to modify SetLicensePlateNumber

        input = "ABC123 9005042345";

        return input.Split(" ");
    }

    public int GetUserInput()
    {
        if (Int32.TryParse(ReadLine(), out int number))
        {
            return number;
        }
        else
        {
            return -1;
        }
    }
}