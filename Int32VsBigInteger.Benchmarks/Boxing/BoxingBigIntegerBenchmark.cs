using BenchmarkDotNet.Attributes;
using Int32VsBigInteger.Models;

namespace Int32VsBigInteger.Benchmarks.Boxing
{
    public class BoxingBigIntegerBenchmark
    {
        [Benchmark(Description = "Boxing BigInteger (123)")]
        public object BoxingBigInteger() => BigIntegerModels.BigInteger1;
        
        [Benchmark(Description = "Boxing BigInteger (Int32.MaxValue + 123)")]
        public object BoxingBigIntegerMoreThanMaxInt32() => BigIntegerModels.BigInteger2;
    }
}