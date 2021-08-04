using BenchmarkDotNet.Attributes;
using Int32VsBigInteger.Models;

namespace Int32VsBigInteger.Benchmarks.Unboxing
{
    public class UnboxingInt32Benchmark
    {
        [Benchmark(Description = "Unboxing Int32 (123)")]
        public int UnboxingInt32() => (int) Int32Models.Int32Object;
    }
}