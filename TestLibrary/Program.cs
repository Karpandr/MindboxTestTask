using MindboxTestTask.Base;
using MindboxTestTask.Figures;

Console.WriteLine("Hello, World!");
int gf = 44444;
byte aj = unchecked((byte)gf);
byte ajj = (byte)gf;
Figure circ = new Circle(0, 0, 10.7);
var gj = circ.Area;
Side a = new Side(0, 0, 300, 0);
//Figure g = new Figure();
//var g = MindboxTestTask.Figures.Figure;
Point aaa = new Point(0, 0);
Point bbb = new Point(0, 10);
//Side a = new Side(aaa, bbb);
Side a1 = new Side(300, 0, 0, 0);
Console.WriteLine(a.Equals(a1));
Console.WriteLine("A.Start: " + a.Start.GetHashCode());
Console.WriteLine("A.End: " + a.End.GetHashCode());
Console.WriteLine("A1.Start: " + a1.Start.GetHashCode());
Console.WriteLine("A1.End: " + a1.End.GetHashCode());
Console.WriteLine(a.GetHashCode());
Console.WriteLine(a1.GetHashCode());

Side b = new Side(0, 0, 0, 400);
Side c = new Side(0, 400, 300, 0);

Side aa = new Side(300, 0, 0, 400);
Side bb = new Side(0, 0, 300, 0);
Side cc = new Side(0, 400, 1, 0);
var g = a.Length;
var n = a.Length;
Figure triangle = new Triangle(0, 0, 300, 0,0, 400);
//var t = triangle.CalculateArea();
Figure xtriangle = new Triangle(0, 0, 0, 400, 300, 0);
//Figure xtriangle1 = new Triangle(2, 0, 4, 0, 6, 0);
Figure triangle1 = new Triangle(300, 0, 0, 400, 1, 0);
var eq = triangle.Equals(triangle1);
Console.WriteLine("triangle:" + triangle.GetHashCode());
Console.WriteLine("triangle1:" + triangle1.GetHashCode());
var isr = (triangle as Triangle).IsRightAngled;
var circarea = circ.Area;
var trianglecarea = triangle.Area;

Console.ReadLine();