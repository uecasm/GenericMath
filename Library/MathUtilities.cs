#if NET7_0_OR_GREATER
using System.Numerics;
#endif

namespace Library;

public static class MathUtilities
{
    public static T Add<T>(T a, T b) where T : struct, INumber<T>
    {
        return a + b;
    }
}