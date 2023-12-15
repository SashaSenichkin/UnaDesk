namespace Trigonometry;

/// <summary>
/// Triangle types
/// </summary>
public enum TriangleType
{
    /// <summary>
    /// all angle less then 90 degree
    /// </summary>
    Sharp,
    
    /// <summary>
    /// one angle 90 degree
    /// </summary>
    Square,
    
    /// <summary>
    /// one angle more then 90 degree (obtuse by docs, bun not so funny)
    /// </summary>
    Stupid
}