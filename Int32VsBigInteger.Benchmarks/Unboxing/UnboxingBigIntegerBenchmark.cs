using System.Numerics;
using BenchmarkDotNet.Attributes;
using Int32VsBigInteger.Models;

namespace Int32VsBigInteger.Benchmarks.Unboxing
{
    public class UnboxingBigIntegerBenchmark
    {
        [Benchmark(Description = "Unboxing BigInteger (123)")]
        public BigInteger UnboxingBigInteger() => (BigInteger) BigIntegerModels.BigInteger1Object;

        [Benchmark(Description = "Unboxing BigInteger (Int32.MaxValue + 123)")]
        public BigInteger UnboxingBigIntegerMoreThanMaxInt32() => (BigInteger) BigIntegerModels.BigInteger2Object;
    }
}