using EtlKit;

var partner = new Partner 
{
    FirstName = "Andy",
    LastName = "Booth"
};

var decisionTable = new DecisionTable<Employee>() 
    .AddCondition<int>("Aged over", (employee, years) => employee.Dob > DateOnly.FromDateTime(DateTime.UtcNow).AddYears(-years))
    .AddAction<bool>("Is minor", (employee, isMinor) => employee.IsMinor = isMinor);

var validator = new Validator<Partner>()
    .AddRule(p => p.FirstName is not null)
    .AddRule(p => p.LastName is not null);

if (validator.IsValid(partner) == false)
{
    Console.WriteLine("Partner invalid");
}

public record Partner 
{
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public DateOnly Dob { get; init; }
}

public class Employee 
{
    public string? FullName { get; set; }
    public DateOnly Dob { get; set; }
    public bool IsMinor { get; set; }
}
