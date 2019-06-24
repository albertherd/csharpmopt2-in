using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace InOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<SixteenBitStructBenchmark>();
            BenchmarkRunner.Run<SixteenBitStructBenchmarkReadonly>();
        }
    }
}
