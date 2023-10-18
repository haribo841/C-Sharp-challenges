using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using System.Text.Json.Serialization;

namespace Benchmark
{


    [MemoryDiagnoser]
    [RankColumn]
    public class Method
    {
        [Benchmark]
        [Arguments(7, 5040)]
        [Arguments(1, 1)]
        [Arguments(9, 362880)]
        [Arguments(2, 2)]
        public int factorial(int num) => num > 1 ? num * factorial(--num) : +1;
        [Benchmark]
        [Arguments(7, 5040)]
        [Arguments(1, 1)]
        [Arguments(9, 362880)]
        [Arguments(2, 2)]
        public int Body(int num)
        {
            return num > 1 ? num * factorial(--num) : +1;
        }
        [Benchmark]
        [Arguments(7, 5040)]
        [Arguments(1, 1)]
        [Arguments(9, 362880)]
        [Arguments(2, 2)]
        public int factorialN(int num) => num > 1 ? num * factorial(num-1) : +1;
        [Benchmark]
        [Arguments(7, 5040)]
        [Arguments(1, 1)]
        [Arguments(9, 362880)]
        [Arguments(2, 2)]
        public int BodyN(int num)
        {
            return num > 1 ? num * factorial(num-1) : +1;
        }
        [Benchmark]
        [Arguments(7, 5040)]
        [Arguments(1, 1)]
        [Arguments(9, 362880)]
        [Arguments(2, 2)]
        public int BodyT(int num)
        {
            if (num > 1)
            {
                return num * factorial(--num);
            }
            else
            {
                return +1;
            }
        }
        [Benchmark]
        [Arguments(7, 5040)]
        [Arguments(1, 1)]
        [Arguments(9, 362880)]
        [Arguments(2, 2)]
        public int BodyNT(int num)
        {
            if (num > 1)
            {
                return num * factorial(num - 1);
            }
            else
            {
                return +1;
            }
        }
        [Benchmark]
        [Arguments(7, 5040)]
        [Arguments(1, 1)]
        [Arguments(9, 362880)]
        [Arguments(2, 2)]
        public int SwitchInst(int num)
        {
            switch (num)
            {
                case > 1:
                    return num * factorial(--num);
                default:
                    return +1;
            }
        }
        [Benchmark]
        [Arguments(7, 5040)]
        [Arguments(1, 1)]
        [Arguments(9, 362880)]
        [Arguments(2, 2)]
        public int SwitchInstT(int num)
        {
            switch (num)
            {
                case > 1:
                    return num * factorial(num - 1);
                default:
                    return +1;
            }
        }
        [Benchmark]
        [Arguments(7, 5040)]
        [Arguments(1, 1)]
        [Arguments(9, 362880)]
        [Arguments(2, 2)]
        public int SwitchExpr(int num)
        {
            return num switch
            {
                > 1 => num * factorial(--num),
                _ => +1,
            };
        }
        [Benchmark]
        [Arguments(7, 5040)]
        [Arguments(1, 1)]
        [Arguments(9, 362880)]
        [Arguments(2, 2)]
        public int SwitchExprT(int num)
        {
            return num switch
            {
                > 1 => num * factorial(num - 1),
                _ => +1,
            };
        }
        [Benchmark]
        [Arguments(7, 5040)]
        [Arguments(1, 1)]
        [Arguments(9, 362880)]
        [Arguments(2, 2)]
        public int factorialG(int num) => num <= 1 ? +1 : num * factorial(--num);
        [Benchmark]
        [Arguments(7, 5040)]
        [Arguments(1, 1)]
        [Arguments(9, 362880)]
        [Arguments(2, 2)]
        public int BodyG(int num)
        {
            return num <= 1 ? +1 : num * factorial(--num);
        }
        [Benchmark]
        [Arguments(7, 5040)]
        [Arguments(1, 1)]
        [Arguments(9, 362880)]
        [Arguments(2, 2)]
        public int factorialNG(int num) => num <= 1 ? +1 : num * factorial(num - 1);
        [Benchmark]
        [Arguments(7, 5040)]
        [Arguments(1, 1)]
        [Arguments(9, 362880)]
        [Arguments(2, 2)]
        public int BodyNG(int num)
        {
            return num <= 1 ? +1 : num * factorial(num - 1);
        }
        [Benchmark]
        [Arguments(7, 5040)]
        [Arguments(1, 1)]
        [Arguments(9, 362880)]
        [Arguments(2, 2)]
        public int BodyTG(int num)
        {
            if (num <= 1)
            {
                return +1;
            }
            else
            {
                return num * factorial(--num);
            }
        }
        [Benchmark]
        [Arguments(7, 5040)]
        [Arguments(1, 1)]
        [Arguments(9, 362880)]
        [Arguments(2, 2)]
        public int SwitchInstG(int num)
        {
            switch (num)
            {
                case <= 1:
                    return +1;
                default:
                    return num * factorial(--num);
            }
        }
        [Benchmark]
        [Arguments(7, 5040)]
        [Arguments(1, 1)]
        [Arguments(9, 362880)]
        [Arguments(2, 2)]
        public int SwitchExprGT(int num)
        {
            return num switch
            {
                <= 1 => +1,
                _ => num * factorial(--num),
            };
        }
        [Benchmark]
        [Arguments(7, 5040)]
        [Arguments(1, 1)]
        [Arguments(9, 362880)]
        [Arguments(2, 2)]
        public int SwitchInstNTG(int num)
        {
            switch (num)
            {
                case <= 1:
                    return +1;
                default:
                    return num * factorial(num - 1);
            }
        }
        [Benchmark]
        [Arguments(7, 5040)]
        [Arguments(1, 1)]
        [Arguments(9, 362880)]
        [Arguments(2, 2)]
        public int SwitchExprNTG(int num)
        {
            return num switch
            {
                <= 1 => +1,
                _ => num * factorial(num - 1)
            };
        }
        [Benchmark]
        [Arguments(7, 5040)]
        [Arguments(1, 1)]
        [Arguments(9, 362880)]
        [Arguments(2, 2)]
        public int BodyNTG(int num)
        {
            if (num <= 1)
            {
                return +1;
            }
            else
            {
                return num * factorial(num - 1);
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                var summary = BenchmarkRunner.Run<Method>();
            }
        }
    }
}