using System.Numerics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Evo.Constants;
using Evo.Primitives;

namespace Evo.Benchmarks
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [MemoryDiagnoser]
    public class ExpSigned : SignedIntTwoParamBenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public BigInteger Exp_BigInteger()
        {
            return BigInteger.ModPow(A.Item1, D.Item1, Numbers.TwoTo256);
        }

        [Benchmark]
        public Int256 Exp_Int256()
        {
            Int256.Exp(A.Item2, D.Item2, out Int256 res);
            return res;
        }
    }
}
