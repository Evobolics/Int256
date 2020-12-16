using System.Numerics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Evo.Primitives;

namespace Evo.Benchmarks
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [MemoryDiagnoser]
    public class MultiplyModUnsigned : UnsignedThreeParamBenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public BigInteger MultiplyMod_BigInteger()
        {
            return ((A.Item1 * B.Item1) % C.Item1);
        }

        [Benchmark]
        public UInt256 MultiplyMod_UInt256()
        {
            UInt256.MultiplyMod(A.Item2, B.Item2, C.Item2, out UInt256 res);
            return res;
        }
    }
}
