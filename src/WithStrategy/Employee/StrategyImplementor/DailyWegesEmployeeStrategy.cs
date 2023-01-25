using Patterns.Behavior.Strategy.WithStrategy.Employee.StrategyInterface;

namespace Patterns.Behavior.Strategy.WithStrategy.Employee.StrategyImplementor
{
    public class DailyWegesEmployeeStrategy : IEmployeeStrategy
    {
        public string GetEmployeeType() => "DailyWeges";
        public int GetPaidLeaves() => 0;
    }
}
