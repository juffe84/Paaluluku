namespace Paaluluku;

public class DistanceResult
{
    public double pisteEtaisyysLinjasta;
    public double paaluLuku;

    public DistanceResult(double _pisteEtaisyysLinjasta, double _paaluLuku)
    {
        this.paaluLuku = _paaluLuku;
        this.pisteEtaisyysLinjasta = _pisteEtaisyysLinjasta;
    }
}