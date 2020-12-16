using System.Numerics;
using BenchmarkDotNet.Attributes;
using Evo.Primitives;

namespace Evo.Benchmarks
{
    public class SignedTwoParamBenchmarkBase : SignedBenchmarkBase
    {
        [ParamsSource(nameof(ValuesTuple))]
        public (BigInteger, Int256) A;

        [ParamsSource(nameof(ValuesTuple))]
        public (BigInteger, Int256) B;
    }
}
