namespace Trigonometry;

public static class Calculator
{
    /// <summary>
    /// default accuracy
    /// </summary>
    public const double DeltaConst = 0.0001d;
    
    /// <summary>
    /// Get angle type, calculated by sides 
    /// </summary>
    /// <param name="delta">accuracy rate</param>
    /// <param name="sides">Side lengths, any order</param>
    /// <returns></returns>
    public static TriangleType GetTriType(double delta, params double[] sides) 
    {
        if (sides.Length != 3)
        {
            throw new ArgumentException("need three sides");
        }
        
        if (sides.Any(x => x <= 0))
        {
            throw new ArgumentException("length have to be positive, not null");
        }
        
        if (delta < 0)
        {
            throw new ArgumentException("delta have to be positive");
        }
        
        var ordered = sides.ToList();
        ordered.Sort();
        var othersPow = Math.Pow(ordered[0], 2) + Math.Pow(ordered[1], 2);
        var maxSidePow = Math.Pow(ordered[2], 2);
        var diff = maxSidePow - othersPow;

        if (Math.Abs(diff) < delta)
            return TriangleType.Square;
        if (diff < 0)
            return TriangleType.Sharp;
        return TriangleType.Stupid;
    }
}