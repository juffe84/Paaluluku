// Tekemättä Arc, Clothoid, Landxml import
// Tehty sivumitta linestä
// Tehty Paaluluku
/**
 * Landxml Alignment solver
 */

using Paaluluku;

//X,Y menee nurinkurin maantieteellisesti. Eli tämä x=maantieteellisesti y
Point point = new Point(45.97, 112.243);
Line line = new Line(0, 0, 40, 100);
Arc arc = new Arc("cw", 35.065834, 77.443252, 48.497498, 35.369726, 77.789610, 108.718368, 40.700626,
    100.734503, 70.000000, 120.000000, 96.988947, 47.042339);


DistanceResult result = Distance.LaskeEtaisyys(point, line);
DistanceResult resultArc = Distance.SolveArc(point, arc);
Console.WriteLine("Paaluluku Arc:" + resultArc.paaluLuku);
Console.WriteLine("Sivumitta Arc: " + resultArc.pisteEtaisyysLinjasta);
Console.WriteLine("Paaluluku: " + result.paaluLuku);
Console.WriteLine("Sivumitta: " + result.pisteEtaisyysLinjasta);