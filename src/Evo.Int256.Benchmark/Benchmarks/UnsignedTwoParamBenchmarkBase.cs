using System.Numerics;
using BenchmarkDotNet.Attributes;
using Evo.Primitives;

namespace Evo.Benchmarks
{
    public class UnsignedTwoParamBenchmarkBase : UnsingedBenchmarkBase
    {
        [ParamsSource(nameof(ValuesTuple))]
        public (BigInteger, UInt256) A;

        [ParamsSource(nameof(ValuesTuple))]
        public (BigInteger, UInt256) B;
    }
}
