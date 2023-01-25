using Patterns.Behavior.Strategy.WithoutStrategy;
using Patterns.Behavior.Strategy.WithStrategy.CallMethodBasedOnId.StrategyImplementor;
using Patterns.Behavior.Strategy.WithStrategy.CallMethodBasedOnId.StrategyInterface;
using Patterns.Behavior.Strategy.WithStrategy.Employee.StrategyImplementor;
using Patterns.Behavior.Strategy.WithStrategy.Employee.StrategyInterface;

Console.WriteLine("Welcome to Strategy Design pattern implementation!");
Console.WriteLine("First example contains an Employee class, you pass the employee type to it & it can return you employee type and a calculated Paid leaves for the same.");

Console.WriteLine("Let's see the old way first, where One class is having entire logic on the basis of if/else");
Employee permanentEmployee = new Employee("Permanent");
Employee contractEmployee = new Employee("Contract");
Employee dailyWedgeEmployee = new Employee("Daily Wedges");
Console.WriteLine();

Console.WriteLine($"Employee of type {permanentEmployee.GetEmployeeType()} is enititled for {permanentEmployee.GetPaidLeaves()} paid leaves");
Console.WriteLine($"Employee of type {contractEmployee.GetEmployeeType()}  is enititled for {contractEmployee.GetPaidLeaves()} paid leaves");
Console.WriteLine($"Employee of type {dailyWedgeEmployee.GetEmployeeType()} is enititled for {dailyWedgeEmployee.GetPaidLeaves()} paid leaves");
Console.WriteLine();

Dictionary<string, IEmployeeStrategy> empStrategy = new Dictionary<string, IEmployeeStrategy>();
empStrategy.Add("Permanent", new PermanentEmployeeStrategy());
empStrategy.Add("Contract", new ContractEmployeeStrategy());
empStrategy.Add("Daily Wedges", new DailyWegesEmployeeStrategy());
Console.WriteLine();

Console.WriteLine("Now with Strategy implemented");
EmployeeWithStrategy EmployeeWithStrategy = new EmployeeWithStrategy(empStrategy, "Contract");
Console.WriteLine($"Employee of type {EmployeeWithStrategy.GetEmployeeType()} is enititled for {EmployeeWithStrategy.GetPaidLeaves()} paid leaves");
Console.WriteLine("----------------------------------------------------------------------");
Console.WriteLine("Example 2");
Console.WriteLine("Call Methods Based On Id without Strategy pattern");
CallMethodsBasedOnId CallMethodsBasedOnId = new CallMethodsBasedOnId();
CallMethodsBasedOnId.CallRelatedMethod(1);

Console.WriteLine("Call Methods Based On Id With Strategy pattern");
Dictionary<int, ICallMethodStrategy> _callMethodStrategy = new Dictionary<int, ICallMethodStrategy>
{
    { 1, new DoSomethingStrategy() },
    { 2, new DoSomethingElseStrategy() },
    { 3, new DoSomethingDynamicStrategy() },
    { 4, new DoNothingStrategy() }
};

CallMethodsBasedOnIdWithStrategy CallMethodsBasedOnIdWithStrategy = new CallMethodsBasedOnIdWithStrategy(_callMethodStrategy);
CallMethodsBasedOnIdWithStrategy.CallRelatedMethod(3);





