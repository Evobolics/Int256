using System.Numerics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Evo.Primitives;

namespace Evo.Benchmarks
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [MemoryDiagnoser]
    public class AddModSigned : SignedThreeParamBenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public BigInteger AddMod_BigInteger()
        {
            return ((A.Item1 + B.Item1) % C.Item1);
        }

        [Benchmark]
        public Int256 AddMod_Int256()
        {
            Int256.AddMod(A.Item2, B.Item2, C.Item2, out Int256 res);
            return res;
        }
    }
}
