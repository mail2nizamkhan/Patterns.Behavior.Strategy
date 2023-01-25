using Patterns.Behavior.Strategy.WithStrategy.Employee.StrategyInterface;

namespace Patterns.Behavior.Strategy.WithStrategy.Employee.StrategyImplementor
{
    public class PermanentEmployeeStrategy : IEmployeeStrategy
    {
        public string GetEmployeeType() => "Permanent";
        public int GetPaidLeaves() => 10;
    }
}
