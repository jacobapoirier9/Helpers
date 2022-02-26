using Helpers;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class LocalJsvServiceClient : JsvServiceClient, IServiceClient
    {
        //private string GetPath<TResponse>(IReturn<TResponse> requestDto)
        //{
        //    var path = ReflectionHelpers.Attr<RouteAttribute>(typeof(TResponse));
        //    return path.Path;
        //}
        private string FileName<TResponse>(string httpVerb, IReturn<TResponse> requestDto)
        {
            var route = typeof(TResponse).Attr<RouteAttribute>();
            return Uri.EscapeDataString(httpVerb + "|" + route.Path) + ".json";
        }

        //private TResponse FromFile<TResponse>(string httpVerb, IReturn<TResponse> requestDto)
        //{
        //    var fileName = FileName(requestDto);
        //    if (File.Exists(fileName))
        //    {
        //        return File.ReadAllText(fileName).FromJson<TResponse>();
        //    }
        //    else
        //    {
                
        //    }
        //}

        //private TResponse TryFromFile<TResponse>(string fileName)
        //{
        //    if (File.Exists(fileName))
        //    {
        //        return File.ReadAllText(fileName).FromJson<TResponse>();
        //    }
        //    else
        //    {
                
        //    }
        //}

        private bool TryFromFile<TResponse>(string fileName, out string contents)
        {
            if (File.Exists(fileName))
            {
                contents = File.ReadAllText(fileName);
                return true;
            }
            else
            {
                contents = string.Empty;
                return false;
            }    
        }
        private void WriteToFile(string fileName, string contents)
        {
            File.WriteAllText(fileName, contents);
        }

        public override TResponse CustomMethod<TResponse>(string httpVerb, IReturn<TResponse> requestDto)
        {
            var fileName = FileName(httpVerb, requestDto);
            if (TryFromFile<TResponse>(fileName, out var contents))
            {
                return contents.FromJson<TResponse>();
            }
            else
            {
                
            }


            throw new NotImplementedException();
        }

        public TResponse CustomMethod<TResponse>(string httpVerb, object requestDto)
        {
            throw new NotImplementedException();
        }

        public void CustomMethod(string httpVerb, IReturnVoid requestDto)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> CustomMethodAsync<TResponse>(string httpVerb, string relativeOrAbsoluteUrl, object request, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> CustomMethodAsync<TResponse>(string httpVerb, IReturn<TResponse> requestDto, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> CustomMethodAsync<TResponse>(string httpVerb, object requestDto, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task CustomMethodAsync(string httpVerb, IReturnVoid requestDto, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public TResponse Delete<TResponse>(string relativeOrAbsoluteUrl)
        {
            throw new NotImplementedException();
        }

        public TResponse Delete<TResponse>(IReturn<TResponse> requestDto)
        {
            throw new NotImplementedException();
        }

        public TResponse Delete<TResponse>(object requestDto)
        {
            throw new NotImplementedException();
        }

        public void Delete(IReturnVoid requestDto)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> DeleteAsync<TResponse>(string relativeOrAbsoluteUrl, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> DeleteAsync<TResponse>(IReturn<TResponse> requestDto, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> DeleteAsync<TResponse>(object requestDto, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(IReturnVoid requestDto, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public TResponse Get<TResponse>(string relativeOrAbsoluteUrl)
        {
            throw new NotImplementedException();
        }

        public TResponse Get<TResponse>(IReturn<TResponse> requestDto)
        {
            throw new NotImplementedException();
        }

        public TResponse Get<TResponse>(object requestDto)
        {
            throw new NotImplementedException();
        }

        public void Get(IReturnVoid requestDto)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> GetAsync<TResponse>(string relativeOrAbsoluteUrl, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> GetAsync<TResponse>(IReturn<TResponse> requestDto, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> GetAsync<TResponse>(object requestDto, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task GetAsync(IReturnVoid requestDto, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> GetCookieValues()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TResponse> GetLazy<TResponse>(IReturn<QueryResponse<TResponse>> queryDto)
        {
            throw new NotImplementedException();
        }

        public TResponse Patch<TResponse>(string relativeOrAbsoluteUrl, object requestDto)
        {
            throw new NotImplementedException();
        }

        public TResponse Patch<TResponse>(IReturn<TResponse> requestDto)
        {
            throw new NotImplementedException();
        }

        public TResponse Patch<TResponse>(object requestDto)
        {
            throw new NotImplementedException();
        }

        public void Patch(IReturnVoid requestDto)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> PatchAsync<TResponse>(IReturn<TResponse> requestDto, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> PatchAsync<TResponse>(object requestDto, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task PatchAsync(IReturnVoid requestDto, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public TResponse Post<TResponse>(string relativeOrAbsoluteUrl, object request)
        {
            throw new NotImplementedException();
        }

        public TResponse Post<TResponse>(IReturn<TResponse> requestDto)
        {
            throw new NotImplementedException();
        }

        public TResponse Post<TResponse>(object requestDto)
        {
            throw new NotImplementedException();
        }

        public void Post(IReturnVoid requestDto)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> PostAsync<TResponse>(string relativeOrAbsoluteUrl, object request, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> PostAsync<TResponse>(IReturn<TResponse> requestDto, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> PostAsync<TResponse>(object requestDto, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task PostAsync(IReturnVoid requestDto, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public TResponse PostFile<TResponse>(string relativeOrAbsoluteUrl, Stream fileToUpload, string fileName, string mimeType)
        {
            throw new NotImplementedException();
        }

        public TResponse PostFilesWithRequest<TResponse>(object request, IEnumerable<UploadFile> files)
        {
            throw new NotImplementedException();
        }

        public TResponse PostFilesWithRequest<TResponse>(string relativeOrAbsoluteUrl, object request, IEnumerable<UploadFile> files)
        {
            throw new NotImplementedException();
        }

        public TResponse PostFileWithRequest<TResponse>(Stream fileToUpload, string fileName, object request, string fieldName = "upload")
        {
            throw new NotImplementedException();
        }

        public TResponse PostFileWithRequest<TResponse>(string relativeOrAbsoluteUrl, Stream fileToUpload, string fileName, object request, string fieldName = "upload")
        {
            throw new NotImplementedException();
        }

        public void Publish(object requestDto)
        {
            throw new NotImplementedException();
        }

        public void PublishAll(IEnumerable<object> requestDtos)
        {
            throw new NotImplementedException();
        }

        public Task PublishAllAsync(IEnumerable<object> requestDtos, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task PublishAsync(object requestDto, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public TResponse Put<TResponse>(string relativeOrAbsoluteUrl, object requestDto)
        {
            throw new NotImplementedException();
        }

        public TResponse Put<TResponse>(IReturn<TResponse> requestDto)
        {
            throw new NotImplementedException();
        }

        public TResponse Put<TResponse>(object requestDto)
        {
            throw new NotImplementedException();
        }

        public void Put(IReturnVoid requestDto)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> PutAsync<TResponse>(string relativeOrAbsoluteUrl, object request, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> PutAsync<TResponse>(IReturn<TResponse> requestDto, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> PutAsync<TResponse>(object requestDto, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task PutAsync(IReturnVoid requestDto, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public TResponse Send<TResponse>(object requestDto)
        {
            throw new NotImplementedException();
        }

        public TResponse Send<TResponse>(string httpMethod, string relativeOrAbsoluteUrl, object request)
        {
            throw new NotImplementedException();
        }

        public List<TResponse> SendAll<TResponse>(IEnumerable<object> requestDtos)
        {
            throw new NotImplementedException();
        }

        public Task<List<TResponse>> SendAllAsync<TResponse>(IEnumerable<object> requestDtos, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public void SendAllOneWay(IEnumerable<object> requests)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> SendAsync<TResponse>(object requestDto, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> SendAsync<TResponse>(string httpMethod, string absoluteUrl, object request, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public void SendOneWay(object requestDto)
        {
            throw new NotImplementedException();
        }

        public void SendOneWay(string relativeOrAbsoluteUri, object requestDto)
        {
            throw new NotImplementedException();
        }

        public void SetCookie(string name, string value, TimeSpan? expiresIn = null)
        {
            throw new NotImplementedException();
        }

        public void SetCredentials(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }


    

    public static class HostFileEditor
    {
        public class ServerOption
        {
            public string Name { get; set; }

            public string Ip { get; set; }
        }

        public class ServerEntry
        {
            public string Name { get; set; }

            public string Ip { get; set; }
            public string Comment { get; set; }
        }

        private const string _hostFilePath = @"D:\MyDev\hosts.txt";
        private const string _dataFile = @"D:\MyDev\Options.json";

        public static List<ServerOption> GetServersOptions()
        {
            var so = new List<ServerOption>() 
            { 
                new ServerOption { Name = "google.com", Ip = "8.8.8.8" },
                new ServerOption { Name = "web01", }
            };

            File.WriteAllText(_dataFile, so.ToJson());

            return so;
        }


        public static void ReadEntries(string filePath = _hostFilePath)
        {
            var lines = GetEntries(filePath);
           
        }

        private static List<ServerEntry> GetEntries(string filePath)
        {
            var text = File.ReadAllText(filePath);
            //var matches = Regex.Matches(text, @"^\d*\.\d*\.\d*\.\d*\s\S*", RegexOptions.Multiline);
            var matches = Regex.Matches(text, @"^\d*\.\d*\.\d*\.\d*\s\S*\s*#.*$", RegexOptions.Multiline);
            var entries = new List<ServerEntry>();

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
                var parts = Regex.Split(match.Value, @"\s").ToList();


                var t = parts.GetRange(2, parts.Count - 2);
                entries.Add(new ServerEntry
                {
                    Ip = parts[0],
                    Name = parts[1],
                    Comment = parts.GetRange(2, parts.Count - 2).Join(" ")
                });
            }

            return entries;
        }

        
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            
        }

    }

    public static class Tls
    {

        private static readonly Random _random = new Random();
        private static int GenerateNumber(int max = 500) => _random.Next(0, max);

        public static void RunTest()
        {
            var p = 149;
            var g = 17;

            Console.WriteLine("Server > Client (Cert Info)");
            Console.WriteLine($"{nameof(p)}: {p}");
            Console.WriteLine($"{nameof(g)}: {g}");
            Console.WriteLine();


            var clientPrivateKey = 8; // Client rivate key
            var clientMasterKey = Math.Pow(g, clientPrivateKey) % p; // Master Key

            Console.WriteLine("Client Calculations");
            Console.WriteLine($"{nameof(clientPrivateKey)}: {clientPrivateKey}");
            Console.WriteLine($"{nameof(clientMasterKey)}: {clientMasterKey}");
            Console.WriteLine();


            Console.WriteLine("Client > Server");
            Console.WriteLine($"{nameof(clientMasterKey)}: {clientMasterKey}");
            Console.WriteLine();

            var serverPrivateKey = 6;
            var serverMasterKey = Math.Pow(g, serverPrivateKey) % p;
            Console.WriteLine("Server Calculations");
            Console.WriteLine($"{nameof(serverPrivateKey)}: {serverPrivateKey}");
            Console.WriteLine($"{nameof(serverMasterKey)}: {serverMasterKey}");
            Console.WriteLine();

            Console.WriteLine("Server > Client");
            Console.WriteLine($"{nameof(serverMasterKey)}: {serverMasterKey}");
            Console.WriteLine();

            
            var clientSessionKey = Math.Pow(serverMasterKey, clientPrivateKey) % p;
            var serverSessionKey = Math.Pow(clientMasterKey, serverPrivateKey) % p;

            Console.WriteLine("Private Key Agreement");
            Console.WriteLine($"{nameof(clientSessionKey)}: {clientSessionKey}");
            Console.WriteLine($"{nameof(serverSessionKey)}: {serverSessionKey}");
            Console.WriteLine(clientSessionKey == serverSessionKey);
            Console.WriteLine();
        }
    }
}
