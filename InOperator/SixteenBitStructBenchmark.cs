using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace InOperator
{
    public class SixteenBitStructBenchmark
    {
        [Benchmark]
        [Arguments(100000000)]
        public void BenchmarkIncrementByRef(int limit)
        {
            SixteenBitStruct sixteenBitStruct = new SixteenBitStruct();
            int counter = 0;
            do
            {
                IncrementByRef(ref sixteenBitStruct);
                counter++;
            }
            while (limit != counter);
        }

        [Benchmark]
        [Arguments(100000000)]
        public void BenchmarkIncrementByIn(int limit)
        {
            SixteenBitStruct sixteenBitStruct = new SixteenBitStruct();
            int counter = 0;
            do
            {
                IncrementIn(sixteenBitStruct);
                counter++;
            }
            while (limit != counter);
        }

        private void IncrementByRef(ref SixteenBitStruct sixteenBitStruct)
        {
            double sum = sixteenBitStruct.D1 + sixteenBitStruct.D2;
        }

        private void IncrementIn(in SixteenBitStruct sixteenBitStruct)
        {
            double sum2 = sixteenBitStruct.D1 + sixteenBitStruct.D2;
        }
    }

    public struct SixteenBitStruct
    {
        public double D1 { get; }
        public double D2 { get; }
    }
}
