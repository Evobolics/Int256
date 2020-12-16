using System.Numerics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Evo.Primitives;
using Evo.Constants;

namespace Evo.Benchmarks
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [MemoryDiagnoser]
    public class SubtractUnsigned : UnsignedTwoParamBenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public BigInteger Subtract_BigInteger()
        {
            return (A.Item1 - B.Item1) % Numbers.TwoTo256;
        }

        [Benchmark]
        public UInt256 Subtract_UInt256()
        {
            UInt256.Subtract(A.Item2, B.Item2, out UInt256 res);
            return res;
        }
    }
}
