namespace SwissTransport.Core
{
    using System;
    using System.Threading.Tasks;

    public interface IHttpClient : IDisposable
    {
        Task<string> GetAsyncString(Uri uri);

        Task<TObject> GetAsyncObject<TObject>(Uri uri, Func<string, TObject> converter);
    }
}