using System;
using System.Threading.Tasks;

namespace SwissTransport.Core
{
    public interface IHttpClient : IDisposable
    {
        Task<string> GetAsyncString(Uri uri);
        Task<TObject> GetAsyncObject<TObject>(Uri uri, Func<string, TObject> converter);
    }
}