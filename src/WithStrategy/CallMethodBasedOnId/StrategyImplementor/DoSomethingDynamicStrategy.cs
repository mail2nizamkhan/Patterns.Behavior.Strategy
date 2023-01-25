using Patterns.Behavior.Strategy.WithStrategy.CallMethodBasedOnId.StrategyInterface;

namespace Patterns.Behavior.Strategy.WithStrategy.CallMethodBasedOnId.StrategyImplementor
{
    internal class DoSomethingDynamicStrategy : ICallMethodStrategy
    {
        public void CallMethod()
        {
            Console.WriteLine("DoSomethingDynamic method is called");
        }
    }
}
