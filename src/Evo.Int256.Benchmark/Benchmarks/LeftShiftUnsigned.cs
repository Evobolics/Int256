using System.Numerics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Evo.Primitives;
using Evo.Constants;

namespace Evo.Benchmarks
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [MemoryDiagnoser]
    public class LeftShiftUnsigned : UnsignedIntTwoParamBenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public BigInteger LeftShift_BigInteger()
        {
            return (A.Item1 << D.Item1) % Numbers.TwoTo256;
        }

        [Benchmark]
        public UInt256 LeftShift_UInt256()
        {
            A.Item2.LeftShift(D.Item1, out UInt256 res);
            return res;
        }
    }
}
