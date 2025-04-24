List<subContractor> subContractors = new List<subContractor>();
while (true)
{
    Console.WriteLine("Please enter the name of the subcontractor");
    string conName = Console.ReadLine();

    Console.WriteLine("Please enter the ID number of the subcontractor");
    int conNum = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter the year the subcontractor started");
    int conYear = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter the month the subcontractor started");
    int conMonth = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter the day of the month the subcontractor started");
    int conDay = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter the shift type for the contractor 1 for day | 2 for night");
    int conShift = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter the hourly pay of the subcontractor");
    double conPay = double.Parse(Console.ReadLine());

    subContractor x = new subContractor(conName,conNum,conYear,conMonth,conDay,conShift,conPay);
    subContractors.Add(x);

    Console.WriteLine("Would you like to continue?\n1 for yes\n2 for No");
    int continueChoice = int.Parse(Console.ReadLine());

    if (continueChoice == 1)
    {
        continue;
    }
    else if (continueChoice == 2)
    {
        break;
    }
}
foreach (subContractor x in subContractors)
{
    Console.WriteLine($"\nHow long did {x.getName()} work for this week?");
    int hoursWorked = int.Parse(Console.ReadLine());
    Console.WriteLine($"\n{x.getName()} has an employee id of {x.getNumber()}.\nThey were hired on {x.getStartDate()} and currently is being paid {x.getHourlyPay()}$ an hour\nIf {x.getName()} worked for {hoursWorked} hours, he would be owed {x.calcPay(hoursWorked)}$");
}
public class Contractor
{
    private string name;
    private int number;
    private DateTime startDate;
    public Contractor()
    {
        this.name = "Unknown Name";
        this.number = 0;
        Console.WriteLine("Please remember to populate the member varaiables!");
    }
    public Contractor(string name, int number, int startYear, int startMonth, int startDay)
    {
        this.name = name;
        this.number = number;
        this.startDate = new DateTime(startYear, startMonth, startDay);
    }
    public string getName()
    {
        return this.name;
    }
    public void setName(string name)
    {
        this.name = name;
    }
    public int getNumber()
    {
        return this.number;
    }
    public void setNumber(int number)
    {
        this.number = number;
        return;
    }
    public void setStartDate(int startYear, int startMonth, int startDay)
    {
        this.startDate = new DateTime(startYear, startMonth, startDay);
        return;
    }
    public DateTime getStartDate()
    {
        return this.startDate;
    }
}

public class subContractor : Contractor
{
    //1 = day | 2 = night | 0 = unknown
    private int shift;
    private double hourlyPay;
    public subContractor()
        : base()
    {
        this.hourlyPay = 0;
        this.shift = 0;
    }
    public subContractor(string name, int number, int startYear, int startMonth, int startDay, int shift, double hourlyPay)
        : base(name, number, startYear, startMonth, startDay)
    {
        this.shift = shift;
        this.hourlyPay = hourlyPay;
    }
    public int getShift()
    {
        return this.shift;
    }
    public void setShift(int shift)
    {
        this.shift = shift;
        return;
    }
    public double getHourlyPay()
    {
        return this.hourlyPay;
    }
    public void setHourlyPay(double hourlyPay)
    {
        this.hourlyPay = hourlyPay;
        return;
    }
    public double calcPay(double hours)
    {
        double pay = 0;
        if (shift == 1)
        {
            pay = hours * hourlyPay;
        }
        else if (shift == 2)
        {
            pay = hours * hourlyPay * 1.03;
        }
        else
        {
            Console.WriteLine("Shift was not entered correctly, enter 1 of day shift or 2 for night shift");
        }
            return pay;
    }
}

