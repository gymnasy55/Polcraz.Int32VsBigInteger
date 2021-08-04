# Polcraz.Int32VsBigInteger
Simple benchmarks of boxing/unboxing Int32 and BigInteger in C#.

## Int32VsBigInteger.Models
The project where the models used in the benchmarks are stored.

`<Type>Models.cs` - file of the certain `<Type>` models.

## Int32VsBigInteger.Benchmarks
Project with BL layer. Contains:
* `Extensions` - helper functions;
* `Configs` - configs of benchmark types;
* `Boxing` - boxing benchmarks;
* `Unboxing` - unboxing benchmarks;

## Int32VsBigInteger.Cli
Benchmark launch project. Please start project in `Release Configuration`.

## My Configuration
```
BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.1110 (20H2/October2020Update)
Intel Core i5-4570 CPU 3.20GHz (Haswell), 1 CPU, 4 logical and 4 physical cores
.NET SDK=5.0.202
[Host]     : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
DefaultJob : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
```
## My Results
|                                       Method |      Mean |     Error |    StdDev |
|---------------------------------------------:|:---------:|:---------:|:---------:|
|                    Boxing BigInteger (123) | 9.6624 ns | 0.2210 ns | 0.4413 ns |
|                         Boxing Int32 (123) | 4.8652 ns | 0.1718 ns | 0.2110 ns |
|                  Unboxing BigInteger (123) | 3.0281 ns | 0.0082 ns | 0.0077 ns |
|                       Unboxing Int32 (123) | 0.3873 ns | 0.0302 ns | 0.0282 ns |
|   Boxing BigInteger (Int32.MaxValue + 123) | 9.5616 ns | 0.0431 ns | 0.0382 ns |
| Unboxing BigInteger (Int32.MaxValue + 123) | 3.0282 ns | 0.0106 ns | 0.0099 ns |

