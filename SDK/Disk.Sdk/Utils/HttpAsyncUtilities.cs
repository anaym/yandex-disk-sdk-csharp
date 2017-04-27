using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Disk.SDK.CommonServices;

namespace Disk.SDK.Utils
{
    internal static class HttpAsyncUtilities
    {
        public static async Task SendEmptyRequestAsync(WebRequest request)
        {
            var tcs = new TaskCompletionSource<bool>();
            HttpUtilities.SendEmptyRequest(request, e =>
            {
                if (e == null)
                    tcs.SetResult(true);
                else
                    tcs.SetException(e);
            });
            await tcs.Task;
        }

        public static async Task<Tuple<Stream, RequestState>> SendFullRequest(RequestState requestState)
        {
            var tcs = new TaskCompletionSource<Tuple<Stream, RequestState>>();
            HttpUtilities.SendFullRequest(requestState, (s, r, e) =>
            {
                if (e == null)
                    tcs.SetResult(Tuple.Create(s, r));
                else
                    tcs.SetException(e);
            });
            return await tcs.Task;
        }
    }
}