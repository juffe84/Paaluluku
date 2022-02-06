namespace Paaluluku;

public static class Distance
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
        double numerator = (Dy * x0 - Dx * y0 - x1 * y2 + x2 * y1);
        double denominator = Math.Sqrt(Dx * Dx + Dy * Dy);
        double b2 = numerator / denominator;

        return numerator / denominator;
    }

    public static bool IsLeft(Point _point, Line _line)
    {
        //return ((linePointB.X - linePointA.X) * (point.Y - linePointA.Y) - (linePointB.Y - linePointA.Y) * (point.X - linePointA.X)) > 0;
        return ((_line.x2 - _line.x1) * (_point.y - _line.y1) - (_line.y2 - _line.y1) * (_point.x - _line.x1)) > 0;
    }
    
    public static double LaskePaalu(Point _point, Line _line)
    {
        //b² ==numerator/denominator
        //c²==suora x1,y1--x0,y0
        //a = √(c² - b²)
        //paaluluku 0 kohdassa ==alkupiste
        double b2 = LaskeEtaisyys(_point, _line);
        double dx = _line.x1 - _point.x;
        double dy = _line.y1 - _point.y;
        double dxy = Math.Sqrt(dx * dx + dy * dy);
        double a = Math.Sqrt(dxy * dxy - b2 * b2);
        
        return a;
    }
}