
namespace Patterns.Behavior.Strategy.WithoutStrategy
{
    public class CallMethodsBasedOnId
    {
        public void CallRelatedMethod(int id)
        {
            if (id == 1)
                DoSomething();
            else if (id == 2)
                DoSomethingElse();
            else if (id == 3)
                DoSomethingDynamic();
            else if (id == 4)
                DoNothing();
        }

        private void DoNothing()
        {
            Console.WriteLine("DoNothing method is called");
        }
        private void DoSomethingDynamic()
        {
            Console.WriteLine("DoSomethingDynamic method is called");
        }
        private void DoSomethingElse()
        {
            Console.WriteLine("DoSomethingElse method is called");
        }
        private void DoSomething()
        {
            Console.WriteLine("DoSomething method is called");
        }
    }
}
