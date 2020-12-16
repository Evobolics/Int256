using System.Numerics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Evo.Primitives;
using Evo.Constants;

namespace Evo.Benchmarks
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [MemoryDiagnoser]
    public class MultiplyUnsigned : UnsignedTwoParamBenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public BigInteger Multiply_BigInteger()
        {
            return (A.Item1 * B.Item1) % Numbers.TwoTo256;
        }

        [Benchmark]
        public UInt256 Multiply_UInt256()
        {
            UInt256.Multiply(A.Item2, B.Item2, out UInt256 res);
            return res;
        }
    }
}
