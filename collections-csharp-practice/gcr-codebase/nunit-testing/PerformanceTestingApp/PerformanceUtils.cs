using System.Threading;

namespace PerformanceTestingApp
{
    public class PerformanceUtils
    {
        public string LongRunningTask()
        {
            Thread.Sleep(3000); // 3 seconds
            return "Completed";
        }
    }
}
