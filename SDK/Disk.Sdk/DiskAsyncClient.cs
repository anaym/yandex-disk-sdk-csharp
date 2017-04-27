using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Disk.SDK.Utils;

namespace Disk.SDK
{
    public class DiskAsyncClient
    {
        public DiskAsyncClient(string accessToken)
        {
            AccessToken = accessToken;
        }

        public string AccessToken { get; }

        public async Task<IEnumerable<DiskItemInfo>> GetListAsync(string path = "/")
        {
            var request = HttpUtilities.CreateRequest(AccessToken, path);
            request.Method = WebdavResources.PropfindMethod;
            var requestState = new RequestState { Request = request, RequestArgument = WebdavResources.ItemDetailsBody, ResponseArgument = path };
            var result = await HttpAsyncUtilities.SendFullRequest(requestState);

            using (var reader = new StreamReader(result.Item1))
            {
                var responseString = reader.ReadToEnd();
                var items = ResponseParser.ParseItems(requestState.ResponseArgument, responseString);
                return items;
            }
        }

        public async Task<DiskItemInfo> GetItemInfoAsync(string path)
        {
            var request = HttpUtilities.CreateRequest(this.AccessToken, path);
            request.Method = WebdavResources.PropfindMethod;
            var requestState = new RequestState { Request = request, RequestArgument = WebdavResources.ItemDetailsBody, ResponseArgument = path };
            var result = await HttpAsyncUtilities.SendFullRequest(requestState);

            using (var reader = new StreamReader(result.Item1))
            {
                var responseString = reader.ReadToEnd();
                var item = ResponseParser.ParseItem(null, responseString);
                return item;
            }
        }

        public async Task MakeDirectoryAsync(string fullPath)
        {
            var request = HttpUtilities.CreateRequest(this.AccessToken, fullPath);
            request.Method = WebdavResources.MakedirMethod;
            await HttpAsyncUtilities.SendEmptyRequestAsync(request);
        }

        public async Task RemoveAsync(string path)
        {
            var request = HttpUtilities.CreateRequest(this.AccessToken, path);
            request.Method = WebdavResources.DeleteMethod;
            await HttpAsyncUtilities.SendEmptyRequestAsync(request);
        }

        public async Task MoveAsync(string source, string destination)
        {
            var request = HttpUtilities.CreateRequest(this.AccessToken, source);
            request.Headers["Destination"] = destination;
            request.Method = WebdavResources.MoveMethod;
            await HttpAsyncUtilities.SendEmptyRequestAsync(request);
        }

        public async Task CopyAsync(string source, string destination)
        {
            var request = HttpUtilities.CreateRequest(this.AccessToken, source);
            request.Headers["Destination"] = destination;
            request.Method = WebdavResources.CopyMethod;
            await HttpAsyncUtilities.SendEmptyRequestAsync(request);
        }
    }
}