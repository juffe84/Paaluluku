namespace Paaluluku;

public class Distance
{
    public static double LaskeEtaisyys(Point _point, Line _line)
    {
        double x0;
        double y0;
        double x1;
        double y1;
        double x2;
        double y2;

        x0 = _point.x;
        y0 = _point.y;

        x1 = _line.x1;
        y1 = _line.y1;

        x2 = _line.x2;
        y2 = _line.y2;

        double Dx = (x2 - x1);
        double Dy = (y2 - y1);
        double numerator = Math.Abs(Dy * x0 - Dx * y0 - x1 * y2 + x2 * y1);
        double denominator = Math.Sqrt(Dx * Dx + Dy * Dy);


        if (denominator == 0)
        {
            //  return this.dist2(point, linePointA);
        }

        return numerator / denominator;
    }

    public static bool IsLeft(Point _point, Line _line)
    {
        //return ((linePointB.X - linePointA.X) * (point.Y - linePointA.Y) - (linePointB.Y - linePointA.Y) * (point.X - linePointA.X)) > 0;
        return ((_line.x2 - _line.x1) * (_point.y - _line.y1) - (_line.y2 - _line.y1) * (_point.x - _line.x1)) > 0;
    }
}