internal class Program
{
    private static void Main(string[] args)
    {
        IFigure figure = new Rectangle(120,100);
        IFigure clonedFigure = figure.Clone();
        figure.GetInfo();
        clonedFigure.GetInfo();

        figure = new Circle(40);
        clonedFigure = figure.Clone();
        figure.GetInfo();
        clonedFigure.GetInfo();

        Console.ReadKey();
    }
}

interface IFigure
{
    IFigure Clone();
    void GetInfo();
}

class Rectangle : IFigure
{
    int width;
    int height;
    public Rectangle(int w, int h)
    {
        width = w;
        height = h;
    }
    public IFigure Clone()
    {
        return new Rectangle(this.width, this.height);
    }
    public void GetInfo()
    {
        Console.WriteLine($"Прямоугольник высотой - {height} и шириной - {width}");
    }
}

class Circle : IFigure
{
    int radius;
    public Circle(int r)
    {
        radius = r;
    }

    public IFigure Clone()
    {
        return new Circle(this.radius);
    }

    public void GetInfo()
    {
        Console.WriteLine($"Круг радиусом - {radius}");
    }
}

//class Client
//{
//    void Operation()
//    {
//        Prototype prototype = new ConcretePrototype1(1);
//        Prototype clone = prototype.Clone();
//        prototype = new ConcretePrototype2(2);
//        clone = prototype.Clone();
//    }
//}

//abstract class Prototype
//{
//    public int Id { get; set; }

//    public Prototype(int id)
//    {
//        this.Id = id;
//    }

//    public abstract Prototype Clone();
//}

//class ConcretePrototype1 : Prototype
//{
//    public ConcretePrototype1(int id) : base(id)
//    { }

//    public override Prototype Clone()
//    {
//        return new ConcretePrototype1(Id);
//    }
//}

//class ConcretePrototype2 : Prototype
//{
//    public ConcretePrototype2(int id) : base(id)
//    { }

//    public override Prototype Clone()
//    {
//        return new ConcretePrototype2(Id);
//    }
//}