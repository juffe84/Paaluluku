// Tekemättä Arc, Clothoid, Landxml import
// Tehty sivumitta linestä
// Tehty Paaluluku
/**
 * Landxml Alignment solver
 */

using Paaluluku;

//X,Y menee nurinkurin maantieteellisesti. Eli tämä x=maantieteellisesti y
Point point = new Point(24470507.081, 6819469.684);
Line line = new Line(24470500.265, 6819429.588, 24470543.969, 6819487.727);

DistanceResult result = Distance.LaskeEtaisyys(point, line);

Console.WriteLine("Paaluluku: " + result.paaluLuku);
Console.WriteLine("Sivumitta: " + result.pisteEtaisyysLinjasta);