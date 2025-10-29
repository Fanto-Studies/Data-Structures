using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Collections;

namespace StackExample
{
    public class Performance
    {
        public void TestBasicStackPerformance()
        {
            const int count = 1000000;
            Stack stack = new Stack();
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                stack.Push(i);
            }
            for (int i = 0; i < count; i++)
            {
                stack.Pop();
            }
            sw.Stop();
            Console.WriteLine($" [Basic Stack] Push and Pop time from {count} values: {sw.ElapsedMilliseconds} ms");
        }

        public void TestGenericStackPerformance()
        {
            const int count = 1000000;
            Stack<int> stack = new Stack<int>();
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                stack.Push(i);
            }
            for (int i = 0; i < count; i++)
            {
                stack.Pop();
            }
            sw.Stop();
            Console.WriteLine($" [Generic Stack] Push and Pop time from {count} values: {sw.ElapsedMilliseconds} ms");
        }

        
    }
}
