using System;
using System.Threading;
using System.Threading.Tasks;

namespace ServerCore
{
    // C# 완벽 가이드라는 책에서 나온 예제 (메모리 배리어)
    class Program
    {
        int _answer;
        bool _complete;

        void A()
        {
            _answer = 123;
            Thread.MemoryBarrier(); // Barrier 1
            _complete = true;
            Thread.MemoryBarrier(); // Barrier 2
        }

        void B()
        {
            Thread.MemoryBarrier(); // Barrier 3
            if(_complete )
            {
                Thread.MemoryBarrier(); // Barrier 4
                Console.WriteLine(_answer);
            }
        }

        static void Main(string[] args)
        {

        }
    }
}