using System;

class Square : Shape
{
    private double _side;

    // onstructor that accepts the color and the side, and then call the base constructor with the color.
    public Square(string color, double side) : base (color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}