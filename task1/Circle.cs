
class Circle : Shape
{
    protected double Radius = 1.0;
    public Circle(){}
    public Circle(double radius)
    {
        Radius = radius;
    }
    public Circle(double radius, string color, bool filled) : base(color, filled)
    {
        Radius = radius;
    }
    public double GetRadius()
    {
        return Radius;
    }
    public void SetRadius(double radius)
    {
        Radius = radius;
    }
    public override double GetArea()
    {
        return 3.14 * Radius * Radius;
    }
    public override double GetPerimeter()
    {
        return 2 * 3.14 * Radius;
    }
    public override string ToString()
    {
        return $"{base.ToString()}\nRadius: {Radius}";
    }
}