using System.Numerics;
using BenchmarkDotNet.Attributes;
using Evo.Primitives;

namespace Evo.Benchmarks
{
    public class UnsignedThreeParamBenchmarkBase : UnsignedTwoParamBenchmarkBase
    {
        [ParamsSource(nameof(ValuesTuple))]
        public (BigInteger, UInt256) C;
    }
}
