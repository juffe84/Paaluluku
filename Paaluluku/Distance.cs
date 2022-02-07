namespace Paaluluku;

public static class Distance
{
    public static DistanceResult LaskeEtaisyys(Point _point, Line _line)
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

        /*
         * Paaluluvun laskeminen
         */
        double b2 = numerator / denominator;
        double dx = x1 - x0;
        double dy = y1 - y0;
        double dxy = Math.Sqrt(dx * dx + dy * dy);
        double a = Math.Sqrt(dxy * dxy - b2 * b2);

        //return numerator / denominator;
        return new DistanceResult(b2, a);
    }

    public static DistanceResult SolveArc(Point _point, Arc _arc)
    {
        //keskipisteen ja annetun pisteen välimatka:
        double dxyCenter_Point;
        double distance;
        double dxyStart_Point;
        double dxyEnd_Point;
        //double radius; ei kannata radiusta laskea, koska annettu riittävän tarkasti lähtötiedoissa
        dxyCenter_Point = Math.Sqrt((_point.x - _arc.centerX) * (_point.x - _arc.centerX) +
                                    (_point.y - _arc.centerY) * (_point.y - _arc.centerY));
        distance = dxyCenter_Point - _arc.radius;
        /*  
          radius = Math.Sqrt((_arc.startX - _arc.centerX) * (_arc.startX - _arc.centerX) +
                             (_arc.startY - _arc.centerY) * (_arc.startY - _arc.centerY));
      */
        double deltaX = _point.x - _arc.centerX;
        double deltaY = _point.y - _arc.centerY;

        double dXAlku= _arc.startX - _arc.centerX;;
        double dYAlku= _arc.startY - _arc.centerY;;

        double dXLoppu= _arc.endX - _arc.centerX;;
        double dYLoppu= _arc.endY - _arc.centerY;;
        
        //kaikki kulmat, jotka osuu alun ja lopun välille ovat arcin sisällä.
        //https://stackoverflow.com/questions/66352469/using-atan2-with-offset-circle
        double alkurad=Math.Atan2(dYAlku,dXAlku);
        double loppurad=Math.Atan2(dYLoppu,dXLoppu);
        
        double pisterad=Math.Atan2(deltaY,deltaX);
        
        //double gon = rad * 63.6619772368;
        //Console.WriteLine(gon);
        if (pisterad<alkurad&&pisterad>loppurad)
        {
            return new DistanceResult(distance, 1);
        }
        else
        {
            Console.WriteLine(pisterad);
            Console.WriteLine(alkurad);
            Console.WriteLine(loppurad);
            return new DistanceResult(1, 1);
        }
        
        
    }

      
    /*
    public static bool IsLeft(Point _point, Line _line)
    {
        //return ((linePointB.X - linePointA.X) * (point.Y - linePointA.Y) - (linePointB.Y - linePointA.Y) * (point.X - linePointA.X)) > 0;
        return ((_line.x2 - _line.x1) * (_point.y - _line.y1) - (_line.y2 - _line.y1) * (_point.x - _line.x1)) > 0;
    }
*/
}