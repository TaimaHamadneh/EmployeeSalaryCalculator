public class Developer : Employee
{
    protected bool TaskCompleted { get; set; }
    private const decimal Commission = 0.03m;

    public Developer(int id, string name, decimal loggedHours, decimal wage,
         bool taskCompletes) : base(id, name, loggedHours, wage)
    {
        this.TaskCompleted = taskCompletes;
    }

    protected override decimal Calculate()
    {
        return base.Calculate() + CalculateBonus();
    }

    private decimal CalculateBonus()
    {
        if (TaskCompleted) 
            return base.Calculate() * Commission;
        return 0;
    }

    public override string ToString()
    {
        return base.ToString() +
            $"\nCompleted: ${(TaskCompleted ? "Yes":"No")}" +
            $"\nBouns: ${Math.Round(CalculateBonus(), 2):N}" +
            $"\nNet Salary: ${Math.Round(this.Calculate(), 2):N}";
    }
}
