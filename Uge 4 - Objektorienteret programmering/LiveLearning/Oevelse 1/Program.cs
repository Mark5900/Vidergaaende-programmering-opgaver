using Oevelse_1;

List<Shape> shapes = new List<Shape>();

shapes.Add(new Circle(1, 2, 3));
shapes.Add(new Rectangle(4, 5, 6, 7));

foreach (Shape shape in shapes)
{
    Console.WriteLine(shape);
    shape.Area();
}