using BenchmarkDotNet.Attributes;
using Int32VsBigInteger.Models;

namespace Int32VsBigInteger.Benchmarks.Boxing
{
    public class BoxingInt32Benchmark
    {
        [Benchmark(Description = "Boxing Int32 (123)")]
        public object BoxingInt32() => Int32Models.Int32;
    }
}