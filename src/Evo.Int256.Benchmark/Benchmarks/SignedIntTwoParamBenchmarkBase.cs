using System.Numerics;
using BenchmarkDotNet.Attributes;
using Evo.Primitives;

namespace Evo.Benchmarks
{
    public class SignedIntTwoParamBenchmarkBase : SignedBenchmarkBase
    {
        [ParamsSource(nameof(ValuesTuple))]
        public (BigInteger, Int256) A;

        [ParamsSource(nameof(ValuesIntTuple))]
        public (int, Int256) D;
    }
}
