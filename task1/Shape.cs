using System.Reflection.Metadata;

abstract class Shape
{
    protected string Color = "red";
    protected bool Filled = true;
    public Shape(){}
    public Shape(string color, bool filled)
    {
        Color = color;
        Filled = filled;
    }
    public string GetColor()
    {
        return Color;
    }
    public void SetColor(string color)
    {
        Color = color;
    }
    public bool IsFilled()
    {
        return Filled;
    }
    public void SetFilled(bool filled)
    {
        Filled = filled;
    }
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public override string ToString()
    {
        return $"Shape[ color ={Color} filled= {Filled}]";
    }
}