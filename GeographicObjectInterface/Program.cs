// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;

interface IGeoObject
{
    double X_coord { get; set; }
    double Y_coord { get; set; }
    string Name { get; set; }
    string Description { get; set; }
    void getInformation() { }
}

class River : IGeoObject
{
    double speed;
    double length;
    double x_coord;
    double y_coord;
    string name;
    string description;

    public double X_coord { get { return x_coord; } set { x_coord = value; } }
    public double Y_coord { get { return y_coord; } set { y_coord = value; } }
    public string Name { get { return name; } set { name = value; } }
    public string Description { get { return description; } set { description = value; } }
    void IGeoObject.getInformation()
    {
        Console.WriteLine($"The name of the river is {name}, it is located on {x_coord};{y_coord}. It's speed is {speed} and the total length is {length}");
    }
}

class Mountain : IGeoObject
{
    double highestPoint;
    double x_coord;
    double y_coord;
    string name;
    string description;

    public double X_coord { get { return x_coord; } set { x_coord = value; } }
    public double Y_coord { get { return y_coord; } set { y_coord = value; } }
    public string Name { get { return name; } set { name = value; } }
    public string Description { get { return description; } set { description = value; } }
    void IGeoObject.getInformation()
    {
        Console.WriteLine($"The name of the mountain is {name}, it is located on {x_coord};{y_coord}. It's highest point is {highestPoint}");
    }
}
