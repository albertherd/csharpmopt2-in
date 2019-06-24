using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace InOperator
{
    public class SixteenBitStructBenchmarkReadonly
    {
        [Benchmark]
        [Arguments(100000000)]
        public void BenchmarkIncrementByRef(int limit)
        {
            SixteenBitStructReadonly sixteenBitStruct = new SixteenBitStructReadonly();
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
            SixteenBitStructReadonly sixteenBitStruct = new SixteenBitStructReadonly();
            int counter = 0;
            do
            {
                IncrementIn(sixteenBitStruct);
                counter++;
            }
            while (limit != counter);
        }

        private void IncrementByRef(ref SixteenBitStructReadonly sixteenBitStruct)
        {
            double sum = sixteenBitStruct.D1 + sixteenBitStruct.D2;
        }

        private void IncrementIn(in SixteenBitStructReadonly sixteenBitStruct)
        {
            double sum2 = sixteenBitStruct.D1 + sixteenBitStruct.D2;
        }
    }

    public readonly struct SixteenBitStructReadonly
    {
        public double D1 { get; }
        public double D2 { get; }
    }
}
