// See https://aka.ms/new-console-template for more information

using Paaluluku;

Point point = new Point(-1.22, -22.22);

Line line = new Line(0.333, -0.43, 1000, 1000);

Distance distance = new Distance(point, line);

Console.WriteLine("etäisyys linjasta " + distance.LaskeEtaisyys() + "m");
Console.WriteLine("Onko vasemmalla? " + distance.IsLeft(point, line));