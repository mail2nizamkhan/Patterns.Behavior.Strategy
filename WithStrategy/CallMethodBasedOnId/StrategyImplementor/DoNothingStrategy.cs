using Patterns.Behavior.Strategy.WithStrategy.CallMethodBasedOnId.StrategyInterface;

namespace Patterns.Behavior.Strategy.WithStrategy.CallMethodBasedOnId.StrategyImplementor
{
    public class DoNothingStrategy : ICallMethodStrategy
    {
        public void CallMethod()
        {
            Console.WriteLine("DoNothing method is called");
        }
    }
}
