namespace RentalLib;

public interface IUserInterface
{
    public void ShowInfoForRentingCar();
    public void ShowBookingDetails(IRental rental);
    public void ShowCostDetails(RentalCost costs);
    public string[] GetInputForRentingCar();
    public int GetUserInput();
}