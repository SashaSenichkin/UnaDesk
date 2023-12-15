using Trigonometry;
using static Trigonometry.Calculator;

namespace TrigonometryTest;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests
{
    [Test]
    public void CheckCalculations()
    {
        Assert.AreEqual(TriangleType.Sharp, GetTriType(0, 1, 1, 1));
        
        Assert.AreEqual(TriangleType.Stupid, GetTriType(DeltaConst, 10, 1, 1));
        Assert.AreEqual(TriangleType.Stupid, GetTriType(DeltaConst, 1, 10, 1));
        Assert.AreEqual(TriangleType.Stupid, GetTriType(DeltaConst, 1, 1, 10));
        Assert.AreEqual(TriangleType.Square, GetTriType(DeltaConst, 3, 4, 5));
        Assert.AreEqual(TriangleType.Square, GetTriType(DeltaConst, 4, 5, 3));
        Assert.AreEqual(TriangleType.Square, GetTriType(DeltaConst, 5, 4, 3));
    }
    
    [Test]
    public void DeltaTest()
    {
       
        Assert.AreEqual(TriangleType.Square, GetTriType(DeltaConst, 3.00001d, 4, 5));
        Assert.AreEqual(TriangleType.Square, GetTriType(DeltaConst, 4, 5.0000001d, 3));
        Assert.AreEqual(TriangleType.Square, GetTriType(DeltaConst, 5, 3, 4.000001d));
    }
    
    [Test]
    public void CheckErrors()
    {
        Assert.Throws<ArgumentException>(() => GetTriType(DeltaConst, 4, -1));
        Assert.Throws<ArgumentException>(() => GetTriType(DeltaConst, 5, 4, 0));
        Assert.Throws<ArgumentException>(() => GetTriType(DeltaConst, 5, 4, -1));
        Assert.Throws<ArgumentException>(() => GetTriType(-1, 5, 4, 4));
    }
}