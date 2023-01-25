
using Patterns.Behavior.Strategy.WithStrategy.CallMethodBasedOnId.StrategyInterface;

namespace Patterns.Behavior.Strategy.WithStrategy.CallMethodBasedOnId.StrategyImplementor
{
    public class CallMethodsBasedOnIdWithStrategy
    {
        private readonly Dictionary<int, ICallMethodStrategy> _callMethodStrategy;

        public CallMethodsBasedOnIdWithStrategy(Dictionary<int, ICallMethodStrategy> callMethodStrategy)
        {
            _callMethodStrategy = callMethodStrategy;
        }

        public void CallRelatedMethod(int id)
        {
            _callMethodStrategy[id].CallMethod();
        }
    }
}
