using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using Evo.Primitives;
using Evo.Constants;
using Evo.Statics;

namespace Evo.Benchmarks
{
    public class UnsingedBenchmarkBase
    {
        public IEnumerable<BigInteger> Values => Enumerable.Concat(new[] { Numbers.UInt256Max }, UnaryOps.RandomUnsigned(1));

        public IEnumerable<UInt256> ValuesUint256 => Values.Select(x => (UInt256)x);

        public IEnumerable<(BigInteger, UInt256)> ValuesTuple => Values.Select(x => (x, (UInt256)x));

        public IEnumerable<int> ValuesInt => UnaryOps.RandomInt(3);

        public IEnumerable<UInt256> ValuesIntUint256 => ValuesInt.Select(x => (UInt256)x);

        public IEnumerable<(int, UInt256)> ValuesIntTuple => ValuesInt.Select(x => (x, (UInt256)x));
    }
}
