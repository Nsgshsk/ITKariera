using AbstractionEx1;

string[] tmp;
List<ColoredFigure> figures = new List<ColoredFigure>();
int x;
if (int.TryParse(Console.ReadLine(), out x))
{
	for (int i = 1; i <= x; i++)
	{
		tmp = Console.ReadLine().Split(" ").ToArray();
        switch (tmp[0])
		{
			case "Triangle": figures.Add(new Triangle(tmp[1], double.Parse(tmp[2]))); break;
			case "Square": figures.Add(new Square(tmp[1], double.Parse(tmp[2]))); break;
			case "Circle": figures.Add(new Circle(tmp[1], double.Parse(tmp[2]))); break;
			default: Console.WriteLine("No shape found! Try again!"); i--; break;
		}
	}
	foreach (var item in figures)
	{
		item.Show();
	}
}
else
{
	Console.WriteLine("Error!\nEnding program!");
}