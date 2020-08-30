using System;
using System.Threading.Tasks;

namespace SwissTransport.Extensions
{
    public static class TaskExtension
    {
        public static T GetResult<T>(this Task<T> task)
        {
            if (task is null)
                throw new ArgumentNullException(nameof(task));

            task.Wait();
            return task.Result;
        }
    }
}