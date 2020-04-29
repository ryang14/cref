using System;
using System.IO;
using System.Linq;
using Grapevine.Interfaces.Server;
using Grapevine.Server;
using Grapevine.Server.Attributes;
using Grapevine.Shared;

namespace tools
{
    class API
    {
        private RestServer server;

        [RestResource]
        public class APIResource
        {

            [RestRoute(HttpMethod = HttpMethod.GET, PathInfo = "/")]
            public IHttpContext Root(IHttpContext context)
            {
                var filepath = Path.Combine(context.Server.PublicFolder.FolderPath,
                                            context.Server.PublicFolder.IndexFileName);
                Console.WriteLine(filepath);

                context.Response.ContentType = ContentType.DEFAULT.FromExtension(filepath);
                context.Response.SendResponse(new FileStream(filepath, FileMode.Open));

                return context;
            }
        }

        public API()
        {
            server = new RestServer();
            server.Host = "+";
            server.LogToConsole().Start();
        }

        ~API()
        {
            server.Stop();
        }
    }
}