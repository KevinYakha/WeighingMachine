using System;

class WeighingMachine
{
    public int Precision { get; }
    private double _weight;
    public double Weight 
    {
        get { return _weight; }
        set { _weight = value < 0 ? throw new ArgumentOutOfRangeException() : value; }
    }
    public string DisplayWeight
    {
        get { return $"{string.Format($"{{0:N{Precision}}}", Weight - TareAdjustment)} kg"; }
    }
    public double TareAdjustment { get; set; } = 5.0d;
    public WeighingMachine(int precision)
    {
        Precision = precision;
            }
}
