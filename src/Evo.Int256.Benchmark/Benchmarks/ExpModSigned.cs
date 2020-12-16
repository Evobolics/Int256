using System.Numerics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Evo.Primitives;

namespace Evo.Benchmarks
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [MemoryDiagnoser]
    public class ExpModSigned : SignedBenchmarkBase
    {
        [ParamsSource(nameof(ValuesTuple))]
        public (BigInteger, Int256) A;

        [ParamsSource(nameof(ValuesTuplePositive))]
        public (BigInteger, Int256) B;

        [ParamsSource(nameof(ValuesTuplePositive))]
        public (BigInteger, Int256) C;

        [Benchmark(Baseline = true)]
        public BigInteger ExpMod_BigInteger()
        {
            return BigInteger.ModPow(A.Item1, B.Item1, C.Item1);
        }

        [Benchmark]
        public Int256 ExpMod_Int256()
        {
            Int256.ExpMod(A.Item2, B.Item2, C.Item2, out Int256 res);
            return res;
        }
    }
}
