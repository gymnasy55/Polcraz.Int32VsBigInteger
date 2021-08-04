using BenchmarkDotNet.Running;
using Int32VsBigInteger.Benchmarks.Boxing;
using Int32VsBigInteger.Benchmarks.Configs;
using Int32VsBigInteger.Benchmarks.Extensions;
using Int32VsBigInteger.Benchmarks.Unboxing;

namespace IntVsBigInteger.Cli
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var boxingAndUnboxingConfig = BoxingAndUnboxingConfig.Instance;

            var boxingAndUnboxingTypes = new[]
            {
                typeof(BoxingInt32Benchmark),
                typeof(BoxingBigIntegerBenchmark),
                typeof(UnboxingInt32Benchmark),
                typeof(UnboxingBigIntegerBenchmark)
            };

            BenchmarkRunner.Run(boxingAndUnboxingTypes.ToBenchmarkInfos(boxingAndUnboxingConfig));
        }
    }
}