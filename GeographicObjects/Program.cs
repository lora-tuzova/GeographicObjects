// See https://aka.ms/new-console-template for more information




abstract class GeoObject
{
    protected double x_coord;
    protected double y_coord;
    protected string name;
    protected string description;

    protected virtual void getInformation() { }
}

class River : GeoObject
{
    double speed;
    double length;

    public void getInformation()
    {
        Console.WriteLine($"The name of the river is {name}, it is located on {x_coord};{y_coord}. It's speed is {speed} and the total length is {length}");
    }
}

class Mountain : GeoObject
{
    double highestPoint;
}
