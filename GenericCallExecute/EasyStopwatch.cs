using System.Diagnostics;

namespace GenericCallExecute
{
    /// <summary>
    /// Easy use of Stopwatch.
    /// 
    /// Starts when instantiated.
    /// Returns duration when stopped.
    /// 
    /// Usage:
    /// * var stopwatch = new EasyStopwatch();
    /// * var duration = stopwatch.Stop();
    /// </summary>
    public class EasyStopwatch
    {
        private Stopwatch Stopwatch { get; set; }

        /// <summary>
        /// Stop Stopwatch and return duration in milliseconds.
        /// </summary>
        /// <returns></returns>
        public long Stop()
        {
            Stopwatch.Stop();
            return Stopwatch.ElapsedMilliseconds;
        }


        /// <summary>
        /// Create and start Stopwatch.
        /// </summary>
        public EasyStopwatch()
        {
            Stopwatch = new Stopwatch();
            Stopwatch.Start();
        }
    }
}
