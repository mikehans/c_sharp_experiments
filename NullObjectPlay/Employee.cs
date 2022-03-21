public class Employee : IEmployee
{

    private class NullEmployee : IEmployee
    {
        public bool IsTimeToPay(DateTime time)
        {
            return false;
        }

        public string Pay()
        {
            return "Skipping Null Employee";
        }
    }

    public static readonly IEmployee NULL = new NullEmployee();

    public bool IsTimeToPay(DateTime time)
    {
        if (time >= DateTime.Now)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string Pay()
    {
        return "Paying this employee";
    }
}
