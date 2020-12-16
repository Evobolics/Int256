using System.Numerics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Evo.Primitives;

namespace Evo.Benchmarks
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [MemoryDiagnoser]
    public class DivideUnsigned : UnsignedTwoParamBenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public BigInteger Divide_BigInteger()
        {
            return (A.Item1 / B.Item1);
        }

        [Benchmark]
        public UInt256 Divide_UInt256()
        {
            UInt256.Divide(A.Item2, B.Item2, out UInt256 res);
            return res;
        }
    }
}
