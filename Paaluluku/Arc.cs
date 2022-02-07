namespace Paaluluku;

public class Arc
{
    public string rot;
    public double chord;
    public double dirEnd;
    public double dirStart;
    public double length;
    public double radius;
    public double staStart;
    public double startX;
    public double startY;
    public double endX;
    public double endY;
    public double centerX;
    public double centerY;

    public Arc(string _rot, double _chord, double _dirEnd, double _dirStart, double _length, double _radius, double _staStart, double _startX, double _startY, double _endX, double _endY, double _centerX, double _centerY)
    {
        this.rot = _rot;
        this.chord = _chord;
        this.dirEnd = _dirEnd;
        this.dirStart = _dirStart;
        this.length = _length;
        this.radius = _radius;
        this.staStart = _staStart;
        this.startX = _startX;
        this.startY = _startY;
        this.endX = _endX;
        this.endY = _endY;
        this.centerX = _centerX;
        this.centerY = _centerY;
    }
}