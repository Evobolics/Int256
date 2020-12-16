using System.Numerics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Evo.Primitives;
using Evo.Constants;

namespace Evo.Benchmarks
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [MemoryDiagnoser]
    public class RightShiftSigned : SignedIntTwoParamBenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public BigInteger RightShift_BigInteger()
        {
            return (A.Item1 >> D.Item1) % Numbers.TwoTo256;
        }

        [Benchmark]
        public Int256 RightShift_Int256()
        {
            A.Item2.RightShift(D.Item1, out Int256 res);
            return res;
        }
    }
}
