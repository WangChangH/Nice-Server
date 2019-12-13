using System;
using System.Threading;
using NLog;
using Server;

namespace APP
{
    class Program
    {
        private static void Main(string[] args)
        {
            // 异步方法全部会回掉到主线程
            SynchronizationContext.SetSynchronizationContext(OneThreadSynchronizationContext.Instance);

            try
            {
                Log.Error("Test。。。");
            }catch(Exception e)
            {
                Log.Error(e);
            }

        }
    }
}
