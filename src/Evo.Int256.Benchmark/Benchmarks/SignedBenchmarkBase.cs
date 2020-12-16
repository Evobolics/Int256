using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using Evo.Primitives;
using Evo.Constants;
using Evo.Statics;

namespace Evo.Benchmarks
{
    public class SignedBenchmarkBase
    {
        public IEnumerable<BigInteger> Values => Enumerable.Concat(new[] { Numbers.Int256Max }, UnaryOps.RandomSigned(1));

        public IEnumerable<BigInteger> ValuesPositive => Values.Where(x => x.Sign >= 0);

        public IEnumerable<Int256> ValuesInt256 => Values.Select(x => (Int256)x);

        public IEnumerable<(BigInteger, Int256)> ValuesTuple => Values.Select(x => (x, (Int256)x));

        public IEnumerable<(BigInteger, Int256)> ValuesTuplePositive => ValuesPositive.Select(x => (x, (Int256)x));

        public IEnumerable<int> ValuesInt => UnaryOps.RandomInt(3);

        public IEnumerable<Int256> ValuesIntInt256 => ValuesInt.Select(x => (Int256)x);

        public IEnumerable<(int, Int256)> ValuesIntTuple => ValuesInt.Select(x => (x, (Int256)x));
    }
}
