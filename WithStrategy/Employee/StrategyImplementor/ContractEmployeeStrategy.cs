using Patterns.Behavior.Strategy.WithStrategy.Employee.StrategyInterface;

namespace Patterns.Behavior.Strategy.WithStrategy.Employee.StrategyImplementor
{
    public class ContractEmployeeStrategy : IEmployeeStrategy
    {
        public string GetEmployeeType() => "Contract";
        public int GetPaidLeaves() => 5;
    }
}
