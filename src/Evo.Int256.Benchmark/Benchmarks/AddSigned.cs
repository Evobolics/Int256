using System.Numerics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Evo.Constants;
using Evo.Primitives;

namespace Evo.Benchmarks
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [MemoryDiagnoser]
    public class AddSigned : SignedTwoParamBenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public BigInteger Add_BigInteger()
        {
            return (A.Item1 + B.Item1) % Numbers.TwoTo256;
        }

        [Benchmark]
        public Int256 Add_Int256()
        {
            Int256.Add(A.Item2, B.Item2, out Int256 res);
            return res;
        }
    }
}
