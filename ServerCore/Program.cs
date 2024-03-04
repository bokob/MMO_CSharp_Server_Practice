using System;
using System.Threading;
using System.Threading.Tasks;

namespace ServerCore
{
    class Program
    {
        // 락 구현 방법
        // 1. 근성
        // 2. 양보
        // 3. 갑질
        static object _lock = new object();
        static SpinLock _lock2 = new SpinLock();

        class Reward
        {

        }

        static ReaderWriterLockSlim _lock3 = new ReaderWriterLockSlim();

        // 99.999%
        static Reward GetRewardById(int Id)
        {
            _lock3.EnterReadLock();

            _lock3.ExitReadLock();

            return null;
        }

        // 0.001%
        void AddReward(Reward reward)
        {
            _lock3.EnterWriteLock();

            _lock3.ExitWriteLock();
        }

        static void Main(string[] args)
        {
            lock(_lock)
            {

            }
        }
    }
}