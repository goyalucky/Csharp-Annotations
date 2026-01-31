using System;
using System.Threading;

namespace LogExecutionDemo
{
    public class PerformanceTest
    {
        [LogExecutionTime]
        public void FastMethod()
        {
            Thread.Sleep(200);
        }

        [LogExecutionTime]
        public void SlowMethod()
        {
            Thread.Sleep(700);
        }

        public void NormalMethod()
        {
            Thread.Sleep(300);
        }
    }
}