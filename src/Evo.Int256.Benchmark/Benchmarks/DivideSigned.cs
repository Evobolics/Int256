using System.Numerics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Evo.Primitives;

namespace Evo.Benchmarks
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [MemoryDiagnoser]
    public class DivideSigned : SignedTwoParamBenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public BigInteger Divide_BigInteger()
        {
            return (A.Item1 / B.Item1);
        }

        [Benchmark]
        public Int256 Divide_Int256()
        {
            Int256.Divide(A.Item2, B.Item2, out Int256 res);
            return res;
        }
    }
}
