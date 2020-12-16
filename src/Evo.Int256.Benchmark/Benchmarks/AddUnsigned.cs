using System.Numerics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Evo.Primitives;
using Evo.Constants;

namespace Evo.Benchmarks
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [MemoryDiagnoser]
    public class AddUnsigned : UnsignedTwoParamBenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public BigInteger Add_BigInteger()
        {
            return (A.Item1 + B.Item1) % Numbers.TwoTo256;
        }

        [Benchmark]
        public UInt256 Add_UInt256()
        {
            UInt256.Add(A.Item2, B.Item2, out UInt256 res);
            return res;
        }
    }
}
