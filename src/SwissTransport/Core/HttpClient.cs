using System;
using System.Net;
using System.Threading.Tasks;

namespace SwissTransport.Core
{
    public class HttpClient : IHttpClient
    {
        private readonly WebClient _client;

        public HttpClient(ICredentials credentials, IWebProxy proxy)
        {
            _client = new WebClient
            {
                Credentials = credentials ?? throw new ArgumentNullException(nameof(credentials)),
                Proxy = proxy ?? throw new ArgumentNullException(nameof(proxy))
            };
        }
        
        public void Dispose()
        {
            _client?.Dispose();
        }

        public Task<string> GetAsyncString(Uri uri)
        {
            if(uri is null)
                throw new ArgumentNullException(nameof(uri));

            return _client.DownloadStringTaskAsync(uri);
        }

        public async Task<TObject> GetAsyncObject<TObject>(Uri uri, Func<string, TObject> converter)
        {
            if(uri is null)
                throw new ArgumentNullException(nameof(uri));
            
            if(converter is null)
                throw new ArgumentNullException(nameof(uri));

            return converter.Invoke(await GetAsyncString(uri));
        }
    }
}