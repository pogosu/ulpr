Console.WriteLine("Введите данные о зарплате:");
Console.Write("ФИО: ");
string fio = Console.ReadLine();
Console.Write("Ежемесячный оклад: ");
double oklad = double.Parse(Console.ReadLine());
Console.Write("Год поступления на работу: ");
int startYear = int.Parse(Console.ReadLine());
Console.Write("Процент надбавки: ");
double bonus = double.Parse(Console.ReadLine());
Console.Write("Количество рабочих дней в месяце: ");
int totalDays = int.Parse(Console.ReadLine());
Console.Write("Количество отработанных дней в месяце: ");
int workedDays = int.Parse(Console.ReadLine());

IPayment payment = new Payment(fio, oklad, startYear, workedDays, totalDays, bonus);

Console.WriteLine("Начисленная сумма: " + payment.CalculateBase());
Console.WriteLine("Удержанная сумма: " + payment.CalculateUderzheno());
Console.WriteLine("Сумма, выдаваемая на руки: " + payment.CalculateZP());
Console.WriteLine("Стаж работы: " + payment.CalculateStazh() + " лет");

interface IPayment
{
    double CalculateBase();
    double CalculateUderzheno();
    double CalculateZP();
    int CalculateStazh();
}

abstract class Employee : IPayment
{
    protected string fio;
    protected double oklad;
    protected int startYear;
    protected int workedDays;
    protected int totalDays;
    protected double bonus;


    public virtual double CalculateBase()
    {
        double baseEarn = oklad * (workedDays / (double)totalDays);
        double bonusAmount = baseEarn * (bonus / 100);
        return baseEarn + bonusAmount;
    }

    public virtual double CalculateUderzheno()
    {
        double pension = CalculateBase() * 0.01;
        double sum_nalog = CalculateBase() * 0.13;
        return pension + sum_nalog;
    }

    public virtual double CalculateZP()
    {
        return CalculateBase() - CalculateUderzheno();
    }

    public virtual int CalculateStazh()
    {
        return 2024 - startYear;
    }
}

class Payment : Employee
{
    public Payment(string fio, double oklad, int startYear, int workedDays, int totalDays, double bonus)
    {
        this.fio = fio;
        this.oklad = oklad;
        this.startYear = startYear;
        this.workedDays = workedDays;
        this.totalDays = totalDays;
        this.bonus = bonus;
    }

    public override double CalculateBase()
    {
        return base.CalculateBase();
    }

    public override double CalculateUderzheno()
    {
        return base.CalculateUderzheno();
    }

    public override double CalculateZP()
    {
        return base.CalculateZP();
    }

    public override int CalculateStazh()
    {
        return base.CalculateStazh();
    }
}