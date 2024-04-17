Square sq = new Square();
Right_Triangle rt = new Right_Triangle();
Isosceles_Triangle it = new Isosceles_Triangle();
Equilateral_Triangle et = new Equilateral_Triangle();
Console.WriteLine(" ");
sq.Area();
rt.Area();
it.Area();
et.Area();
Console.WriteLine(" ");
sq.PrintFeatures();
rt.PrintFeatures();
it.PrintFeatures();
et.PrintFeatures();

interface IFigure
{
    void Area();
    void PrintFeatures();
}

abstract class Figure: IFigure
{
    public virtual void Area()
    {

    }

    public virtual void PrintFeatures()
    {

    }
}

abstract class Quadrangle : Figure
{
    public int a;
}

abstract class Triangle : Figure
{
    public int a, b, c;
}

class Square : Quadrangle
{
    public Square()
    {
        Console.WriteLine("Введите свойства квадрата: ");
        Console.Write("Введите длину сторон: ");
        a = int.Parse(Console.ReadLine());
    }

    public override void Area()
    {
        Console.WriteLine("Площадь квадрата: " + (a * a));
    }

    public override void PrintFeatures()
    {
        Console.WriteLine("Свойства квадрата: ");
        Console.WriteLine("Строна равна: " + a);
    }
}

class Right_Triangle : Triangle
{
    public Right_Triangle()
    {
        Console.WriteLine("Введите свойства прямоугольного треугольника");
        Console.Write("Введите длину первого катета: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Введите длину второго катета: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("Ввидите длину гипотенузы: ");
        c = int.Parse(Console.ReadLine());
    }

    public override void Area()
    {
        int s = (a * b) / 2;
        Console.WriteLine("Площадь прямоугольного треугольника " + s);
    }

    public override void PrintFeatures()
    {
        Console.WriteLine("Свойства прямоугольного треугольника: ");
        Console.WriteLine("Первый катет: " + a);
        Console.WriteLine("Второй катет: " + b);
        Console.WriteLine("Гипотенуза:  " + c);
    }

}

class Isosceles_Triangle : Triangle
{
    public Isosceles_Triangle()
    {
        Console.WriteLine("Введите свойства равнобедренного треугольника:");
        Console.Write("Введите равные стороны: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Введите оставшуюся сторону: ");
        c = int.Parse(Console.ReadLine());
    }

    public override void Area()
    {
        int p = (a + a + c) / 2;
        int s = (int)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Console.WriteLine("Площадь равнобедренного треугольника: " + s);
    }

    public override void PrintFeatures()
    {
        Console.WriteLine("Свойства равнобедренного треугольника");
        Console.WriteLine("Равные стороны: " + a);
        Console.WriteLine("Оставшаяся сторона: " + c);
    }
}

class Equilateral_Triangle : Triangle
{
    public Equilateral_Triangle()
    {
        Console.WriteLine("Введите свойства равностороннего треугольника");
        Console.Write("Введите длину сторон: ");
        a = int.Parse(Console.ReadLine());
    }

    public override void Area()
    {
        int s = (int)(((a * a) * Math.Sqrt(3)) / 4);
        Console.WriteLine("Площадь равностороннего треугольника: " + s);
    }

    public override void PrintFeatures()
    {
        Console.WriteLine("Свойства равностороннего треугольника: ");
        Console.WriteLine("Стороны: " + a);
    }
}
