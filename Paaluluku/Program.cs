// Tekemättä Arc, Clothoid, Landxml import
// Tehty sivumitta linestä
// Tehty Paaluluku
/**
 * Landxml Alignment solver
 */

using Paaluluku;

//X,Y menee nurinkurin maantieteellisesti. Eli tämä x=maantieteellisesti y
Point point = new Point(24470545.002, 6819503.765);
Line line = new Line(24470500.265, 6819429.588, 24470543.969, 6819487.727);
Arc arc = new Arc("cw", 41.125570, 109.821170, 58.857618, 42.244623, 52.769902, 73.746890, 24470544.778496,
    6819488.337282, 24470584.666041, 6819498.352086, 24470576.556914, 6819446.208969);


DistanceResult result = Distance.LaskeEtaisyys(point, line);
DistanceResult resultArc = Distance.SolveArc(point, arc);
Console.WriteLine(resultArc.paaluLuku);
Console.WriteLine("Sivumitta Arc: " + resultArc.pisteEtaisyysLinjasta);
Console.WriteLine("Paaluluku: " + result.paaluLuku);
Console.WriteLine("Sivumitta: " + result.pisteEtaisyysLinjasta);