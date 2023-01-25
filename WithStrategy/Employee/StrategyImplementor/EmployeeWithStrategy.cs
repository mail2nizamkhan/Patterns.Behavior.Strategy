using Patterns.Behavior.Strategy.WithStrategy.Employee.StrategyInterface;

namespace Patterns.Behavior.Strategy.WithStrategy.Employee.StrategyImplementor
{
    public class EmployeeWithStrategy
    {
        private readonly Dictionary<string, IEmployeeStrategy> _employeeStrategy;
        string _type = string.Empty;

        public EmployeeWithStrategy(Dictionary<string, IEmployeeStrategy> employeeStrategy, string type)
        {
            _employeeStrategy = employeeStrategy;
            _type = type;
        }
        public string GetEmployeeType() => _employeeStrategy[_type].GetEmployeeType();
        public int GetPaidLeaves() => _employeeStrategy[_type].GetPaidLeaves();
    }
}