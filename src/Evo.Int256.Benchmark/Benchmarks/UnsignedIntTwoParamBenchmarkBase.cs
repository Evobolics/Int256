using System.Numerics;
using BenchmarkDotNet.Attributes;
using Evo.Primitives;

namespace Evo.Benchmarks
{
    public class UnsignedIntTwoParamBenchmarkBase : UnsingedBenchmarkBase
    {
        [ParamsSource(nameof(ValuesTuple))]
        public (BigInteger, UInt256) A;

        [ParamsSource(nameof(ValuesIntTuple))]
        public (int, UInt256) D;
    }
}
