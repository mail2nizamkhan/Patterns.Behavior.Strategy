using Patterns.Behavior.Strategy.WithStrategy.CallMethodBasedOnId.StrategyInterface;

namespace Patterns.Behavior.Strategy.WithStrategy.CallMethodBasedOnId.StrategyImplementor
{
    internal class DoSomethingElseStrategy : ICallMethodStrategy
    {
        public void CallMethod()
        {
            Console.WriteLine("DoSomethingElse method is called");
        }
    }
}
