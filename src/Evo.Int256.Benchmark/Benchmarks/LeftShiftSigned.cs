using System.Numerics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Evo.Primitives;
using Evo.Constants;

namespace Evo.Benchmarks
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [MemoryDiagnoser]
    public class LeftShiftSigned : SignedIntTwoParamBenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public BigInteger LeftShift_BigInteger()
        {
            return (A.Item1 << D.Item1) % Numbers.TwoTo256;
        }

        [Benchmark]
        public Int256 LeftShift_Int256()
        {
            A.Item2.LeftShift(D.Item1, out Int256 res);
            return res;
        }
    }
}
