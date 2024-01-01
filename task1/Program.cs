System.Console.WriteLine("-----------------------------------------The Circle---------------------------------------");
Circle circle = new Circle();
circle.SetRadius(1.0);
circle.SetFilled(true);
circle.SetColor("blue");
System.Console.WriteLine("Radius: " + circle.GetRadius());
System.Console.WriteLine("Color: " + circle.GetColor());
System.Console.WriteLine("Area: " + circle.GetArea());
System.Console.WriteLine("Perimeter: " + circle.GetPerimeter());


System.Console.WriteLine("-------------------------------------The Rectangle------------------------------------");
Rectangle rectangle = new Rectangle();
rectangle.SetWidth(2.0);
rectangle.SetLength(2.0);
rectangle.SetFilled(true);
rectangle.SetColor("blue-violet");
System.Console.WriteLine("width: " + rectangle.GetWidth());
System.Console.WriteLine("length: " + rectangle.GetLength());
System.Console.WriteLine("Color: " + rectangle.GetColor());
System.Console.WriteLine("Area: " + rectangle.GetArea());
System.Console.WriteLine("Perimeter: " + rectangle.GetPerimeter());


System.Console.WriteLine("-------------------------------------The Square------------------------------------------");
Square square = new Square();
square.SetSide(5.0);
square.SetFilled(true);
square.SetColor("green");
System.Console.WriteLine("side: " + square.GetSide());
System.Console.WriteLine("Color: " + square.GetColor());