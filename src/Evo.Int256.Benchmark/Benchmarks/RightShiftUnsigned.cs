using System.Numerics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Evo.Primitives;
using Evo.Constants;

namespace Evo.Benchmarks
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [MemoryDiagnoser]
    public class RightShiftUnsigned : UnsignedIntTwoParamBenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public BigInteger RightShift_BigInteger()
        {
            return (A.Item1 >> D.Item1) % Numbers.TwoTo256;
        }

        [Benchmark]
        public UInt256 RightShift_UInt256()
        {
            A.Item2.RightShift(D.Item1, out UInt256 res);
            return res;
        }
    }
}
