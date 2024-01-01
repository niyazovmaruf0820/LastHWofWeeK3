class Square : Rectangle
{
    public Square(){}
    public Square(double side) : base(side, side){}
    public Square(string color,bool field,double side) : base (side,side,color,field){}
    public double GetSide()
    {
        return base.GetLength();
    }
    public void SetSide(double side)
    {
      base.SetLength(side);
    }
    public override void SetWidth(double side)
    {
        base.SetWidth(side);
    }
    public override void SetLength(double side)
    {
        base.SetLength(side);
    }
    public override string ToString()
    {
        return $"Square [{base.ToString()}]";
    }
}