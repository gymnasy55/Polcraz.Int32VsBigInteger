using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;

namespace Int32VsBigInteger.Benchmarks.Configs
{
    public class BoxingAndUnboxingConfig : ManualConfig
    {
        public static readonly IConfig Instance = new BoxingAndUnboxingConfig();
        
        private BoxingAndUnboxingConfig()
        {
            AddJob(Job.Default);
            AddColumn(TargetMethodColumn.Method);
            AddColumn(StatisticColumn.Mean);
            AddColumn(StatisticColumn.Error);
            AddColumn(StatisticColumn.StdDev);
            AddLogger(ConsoleLogger.Default);
            AddExporter(PlainExporter.Default);
            WithOptions(ConfigOptions.JoinSummary);
            WithOptions(ConfigOptions.DontOverwriteResults);
            WithOptions(ConfigOptions.KeepBenchmarkFiles);
        }
    }
}