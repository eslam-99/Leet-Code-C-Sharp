public class ParkingSystem
{

    private int[] Lots { get; set; }
    
    public ParkingSystem(int big, int medium, int small)
    {
        Lots = new int[] { big, medium, small };
    }
    
    public bool AddCar(int carType)
    {
        if (Lots[carType - 1] > 0)
        {
            Lots[carType - 1]--;
            return true;
        }
        return false;
    }
}