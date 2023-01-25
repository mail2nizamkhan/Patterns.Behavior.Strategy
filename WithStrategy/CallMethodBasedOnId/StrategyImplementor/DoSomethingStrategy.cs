using Patterns.Behavior.Strategy.WithStrategy.CallMethodBasedOnId.StrategyInterface;

namespace Patterns.Behavior.Strategy.WithStrategy.CallMethodBasedOnId.StrategyImplementor
{
    public class DoSomethingStrategy : ICallMethodStrategy
    {
        public void CallMethod()
        {
            Console.WriteLine("DoSomething method is called");
        }
    }
}
