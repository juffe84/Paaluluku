// Tekemättä Arc, Clothoid, Landxml import
// Tehty sivumitta linestä
// Tehty Paaluluku
/**
 * Landxml Alignment solver
 */

using Paaluluku;
//X,Y menee nurinkurin maantieteellisesti. Eli tämä x=maantieteellisesti y
Point point = new Point(24470507.081,6819469.684);
Line line = new Line(24470500.265, 6819429.588, 24470543.969, 6819487.727);

Console.WriteLine("etäisyys viivasta " + Distance.LaskeEtaisyys(point, line) + "m");
Console.WriteLine("Paaluluku "+Distance.LaskePaalu(point,line));
Console.WriteLine("Onko vasemmalla? " + Distance.IsLeft(point, line)); //turha Laske etäisyys palauttaa nyt - merkin, jos vasemmalla
