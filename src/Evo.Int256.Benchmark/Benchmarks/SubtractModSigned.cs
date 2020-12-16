using System.Numerics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Evo.Primitives;

namespace Evo.Benchmarks
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [MemoryDiagnoser]
    public class SubtractModSigned : SignedThreeParamBenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public BigInteger SubtractMod_BigInteger()
        {
            return ((A.Item1 - B.Item1) % C.Item1);
        }

        [Benchmark]
        public Int256 SubtractMod_Int256()
        {
            Int256.SubtractMod(A.Item2, B.Item2, C.Item2, out Int256 res);
            return res;
        }
    }
}
