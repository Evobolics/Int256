using System.Numerics;
using BenchmarkDotNet.Attributes;
using Evo.Primitives;

namespace Evo.Benchmarks
{
    public class SignedThreeParamBenchmarkBase : SignedTwoParamBenchmarkBase
    {
        [ParamsSource(nameof(ValuesTuple))]
        public (BigInteger, Int256) C;
    }
}
