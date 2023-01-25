namespace Patterns.Behavior.Strategy.WithoutStrategy;
public class Employee
{
    string _type = string.Empty;
    public Employee(string type)
    {
        _type = type;
    }
    public string GetEmployeeType() => _type;
    public int GetPaidLeaves()
    {
        if (GetEmployeeType().ToLower() == "management".ToLower())
            return 15;
        else if (GetEmployeeType().ToLower() == "permanent".ToLower())
            return 10;
        else if (GetEmployeeType().ToLower() == "contract".ToLower())
            return 5;
        else if (GetEmployeeType().ToLower() == "daily wedges".ToLower())
            return 0;

        return 0;
    }
}
