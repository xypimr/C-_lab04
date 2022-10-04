namespace task02;

public class CarComparer : IComparer<Car>
{
    public static string? mode { get; set; }
    public int Compare(Car? car1, Car? car2)
    {
        int ans;
        switch (mode)
        {
            case "year" :
            {
                ans = car1.ProductionYear.CompareTo(car2.ProductionYear);
                break;
            }
            case "speed":
            {
                ans = car1.MaxSpeed.CompareTo(car2.MaxSpeed);
                break;
            }
            default:
            {
                ans = car1.Name.CompareTo(car2.Name);
                break;
            }
        }
        return ans;
    }
}