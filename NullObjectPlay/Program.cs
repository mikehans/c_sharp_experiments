// See https://aka.ms/new-console-template for more information
IEmployee emp1 = new Employee();
IEmployee emp2 = Employee.NULL;
IEmployee emp3 = new Employee();

if (emp1.IsTimeToPay(DateTime.Now.AddMinutes(1)))
{
    System.Console.WriteLine(emp1.Pay());
}
else
{
    System.Console.WriteLine("Not paying emp1 today");
}

if (emp2.IsTimeToPay(DateTime.Now.AddMinutes(1)))
{
    System.Console.WriteLine(emp2.Pay());
}
else
{
    System.Console.WriteLine("Not paying emp2 today");
}

if (emp3.IsTimeToPay(DateTime.Now.AddMinutes(-1)))
{
    System.Console.WriteLine(emp3.Pay());
}
else
{
    System.Console.WriteLine("Not paying emp3 today");
}
