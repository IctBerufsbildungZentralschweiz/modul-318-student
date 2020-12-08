using System;
using System.Threading.Tasks;

namespace SwissTransport.Extensions
{
    public static class TaskExtension
    {
        public static TResult GetResult<TResult>(this Task<TResult> task)
        {
            if (task is null)
                throw new ArgumentNullException(nameof(task));

            task.Wait();
            return task.Result;
        }
    }
}